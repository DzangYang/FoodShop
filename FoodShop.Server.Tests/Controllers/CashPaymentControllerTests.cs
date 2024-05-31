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
using FoodShop.Application.Services.CashPaymentService;


namespace FoodShop.Server.Tests.Controllers;
public class CashPaymentControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<ICashPaymentService> _serviceMock;
    private readonly CashPaymentController _sut;

    public CashPaymentControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<ICashPaymentService>>();
        _sut = new CashPaymentController(_serviceMock.Object);
    }

    [Fact]
    public async Task DebitCashFromTheUser_WhenTheAmountOfMoney_IsNotNegative()
    {
        //Arrage(Подготовка)
        var amount = 200;

        _serviceMock.Setup(x => x.Cancellation(amount)).Returns(Task.CompletedTask);

        //Act(Действие)
        var result = await _sut.Decreese(amount);

        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult>();

        result.Should().BeOfType<OkResult>();

        _serviceMock.Verify(x => x.Cancellation(amount), Times.Once());

    }

    [Fact]
    public async Task GiveMeBackABadRequest_WhenTheAmountOfMoney_ToBeDebitedFromTheUser_IsNegative()
    {
        //Arrage(Подготовка)
        var amount = -200;

        _serviceMock.Setup(x => x.Cancellation(amount)).Returns(Task.CompletedTask);

        //Act(Действие)
        var result = await _sut.Decreese(amount);

        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult>();

        result.Should().BeOfType<BadRequestResult>();


        _serviceMock.Verify(x => x.Cancellation(amount), Times.Never());

    }

}
