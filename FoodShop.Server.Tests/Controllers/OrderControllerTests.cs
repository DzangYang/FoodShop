using AutoFixture;
using FoodShop.Application.Services.OrderService;
using FoodShop.Application.Services.ProductService;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Server.Controllers;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using FoodShop.Application.DTO.Requests;
using Microsoft.AspNetCore.Mvc;
using FoodShop.Application.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using FoodShop.Domain.Domain.Entities;


namespace FoodShop.Server.Tests.Controllers;
public class OrderControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IOrderService> _serviceMock;
    private readonly OrderController _sut;
   

    public OrderControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IOrderService>>();
        _sut = new OrderController(_serviceMock.Object);
       
    }

    [Fact]
    public async Task CreateMeAnOrder_WhenTheSalesQuantityOrTotalPrice_OfTheOrderIsNotNegative()
    {
        //Arrage(Подготовка)
        var orderDto = _fixture.Create<CreateOrderDTO>();

        
        _serviceMock.Setup(x => x.Create(orderDto)).Returns(Task.CompletedTask);

        //Act(Действие)
        var result = await _sut.Create(orderDto);



        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult>();

        result.Should().BeOfType<OkResult>();


        _serviceMock.Verify(x => x.Create(orderDto), Times.Once());

    }

    [Fact]
    public async Task GiveMeBackABadReguqest_WhenASale_HasANegativeOrderQuantity()
    {
        //Arrage(Подготовка)
        var orderDto = new CreateOrderDTO()
        {
            Payment = _fixture.Create<WayOfPayment>(),
            Sales = new List<CreateOrderSaleDTO> // Создание списка
            {
                new CreateOrderSaleDTO() // Добавление объекта в список
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.NewGuid(),
                    Qantity = -2,
                    TotalPrice = 50
                }
            }
        };


        _serviceMock.Setup(x => x.Create(orderDto)).Returns(Task.CompletedTask);

        //Act(Действие)
        var result = await _sut.Create(orderDto);



        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult>();

        result.Should().BeOfType<BadRequestResult>();


        _serviceMock.Verify(x => x.Create(orderDto), Times.Never());

    }

    [Fact]
    public async Task GiveMeBackABadReguqest_WhenASale_HasANegativeOrderTotalPrice()
    {
        //Arrage(Подготовка)
        var orderDto = new CreateOrderDTO()
        {
            Payment = _fixture.Create<WayOfPayment>(),
            Sales = new List<CreateOrderSaleDTO> // Создание списка
            {
                new CreateOrderSaleDTO() // Добавление объекта в список
                {
                    Id = Guid.NewGuid(),
                    ProductId = Guid.NewGuid(),
                    Qantity = 10,
                    TotalPrice = -50
                }
            }
        };


        _serviceMock.Setup(x => x.Create(orderDto)).Returns(Task.CompletedTask);

        //Act(Действие)
        var result = await _sut.Create(orderDto);



        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult>();

        result.Should().BeOfType<BadRequestResult>();


        _serviceMock.Verify(x => x.Create(orderDto), Times.Never());

    }



}
