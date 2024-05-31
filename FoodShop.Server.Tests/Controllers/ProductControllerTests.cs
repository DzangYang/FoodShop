using AutoFixture;
using FluentAssertions;
using FoodShop.Application.DTO;
using FoodShop.Application.DTO.Requests;
using FoodShop.Application.Services.ProductService;
using FoodShop.Domain.Domain.Interfaces.IRepositoryes;
using FoodShop.Domain.Domain.Paginated;
using FoodShop.Server.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Moq;
using System.Threading.Tasks;

namespace FoodShop.Server.Tests.Controllers;
public class ProductControllerTests
{
    private readonly IFixture _fixture;
    private readonly Mock<IProductService> _serviceMock;
    private readonly ProductController _sut;


    public ProductControllerTests()
    {
        _fixture = new Fixture();
        _serviceMock = _fixture.Freeze<Mock<IProductService>>();
        _sut = new ProductController(_serviceMock.Object);
       
    }

    [Fact]
    public async Task GiveMeAPaginationResponse_WhenThePageSize_AndPageNumber_AreNotNegative()
    {
        //Arrage(Подготовка)
        var paginate = new CreatePaginateRequestDto()
        {
            PageSize = 5,
            PageNumber = 2
        };

        var productMock = _fixture.Create<PagedList<ProductDTO>>();
        _serviceMock.Setup(x => x.GetPaginate(paginate.PageNumber, paginate.PageSize)).ReturnsAsync(productMock);
        
        //Act(Действие)
        var result = await _sut.GetPaginated(paginate);
       


        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult<PagedList<ProductDTO>>>();
        result.Result.Should().BeAssignableTo<OkObjectResult>();
        result.Result.As<OkObjectResult>().Value
            .Should()
            .NotBeNull()
            .And.BeOfType(productMock.GetType());

        _serviceMock.Verify(x => x.GetPaginate(paginate.PageNumber, paginate.PageSize), Times.Once());
        
    }


    [Fact]
    public async Task GiveMeBackAPaginationResponse_WhenThePageNumber_AreNegative()
    {
        //Arrage(Подготовка)   
        var paginate = new CreatePaginateRequestDto()
        {
            PageNumber = -5,
            PageSize = 5
        };

        var productMock = _fixture.Create<PagedList<ProductDTO>>();
        _serviceMock.Setup(x => x.GetPaginate(paginate.PageSize, paginate.PageNumber)).ReturnsAsync(productMock);


        //Act(Действие)
        var result = await _sut.GetPaginated(paginate).ConfigureAwait(false);

        //Assert(Проверка)

        result.Should().NotBeNull();
      
        result.Result.Should().BeAssignableTo<BadRequestResult>();
        
        _serviceMock.Verify(x => x.GetPaginate(paginate.PageSize, paginate.PageNumber), Times.Never());

    }

    [Fact]
    public async Task GiveMeBackAPaginationResponse_WhenThePageSize_AreNegative()
    {

        //Arrage(Подготовка)

        var paginate = new CreatePaginateRequestDto()
        {
            PageSize = -5,
            PageNumber = 5
        };

        var productMock = _fixture.Create<PagedList<ProductDTO>>();
        _serviceMock.Setup(x => x.GetPaginate(paginate.PageSize, paginate.PageNumber)).ReturnsAsync(productMock);

        //Act(Действие)
        var result = await _sut.GetPaginated(paginate).ConfigureAwait(false);

        //Assert(Проверка)
        result.Should().NotBeNull();

        result.Result.Should().BeAssignableTo<BadRequestResult>();

        _serviceMock.Verify(x => x.GetPaginate(paginate.PageSize, paginate.PageNumber), Times.Never());

    }

    [Fact]
    public async Task GiveMeBackIsNotFound_WhenTheId_OfTheCategoryNull ()
    {

        //Arrage(Подготовка)

        var categoryId = _fixture.Create<Guid>();

        CategoryDto categoryDto = null;

        _serviceMock.Setup(x => x.GetCategoryById(categoryId)).ReturnsAsync(categoryDto);

        //Act(Действие)
        var result = await _sut.GetCategoryById(categoryId).ConfigureAwait(false);

        //Assert(Проверка)
        result.Should().NotBeNull();

        result.Result.Should().BeAssignableTo<NotFoundResult>();

        _serviceMock.Verify(x => x.GetCategoryById(categoryId), Times.Once());

    }

    [Fact]
    public async Task GiveMeBackACategory_WhenTheCategoryId_IsNotNull()
    {

        //Arrage(Подготовка)

        var categoryId = _fixture.Create<Guid>();

        CategoryDto categoryDto = new CategoryDto()
        {
            Id = Guid.NewGuid(),
            Name = "Test",
        };
        var categoryMock = categoryDto;
        _serviceMock.Setup(x => x.GetCategoryById(categoryId)).ReturnsAsync(categoryDto);

        //Act(Действие)
        var result = await _sut.GetCategoryById(categoryId).ConfigureAwait(false);

        //Assert(Проверка)
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ActionResult<CategoryDto>>();

        result.Result.Should().BeAssignableTo<OkObjectResult>();
        result.Result.As<OkObjectResult>().Value
             .Should()
             .NotBeNull()
             .And.BeOfType(categoryMock.GetType());

        _serviceMock.Verify(x => x.GetCategoryById(categoryId), Times.Once());

    }



}
