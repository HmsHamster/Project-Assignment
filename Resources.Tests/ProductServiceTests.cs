using Resources.Enums;
using Resources.Models;
using Resources.Services;

namespace Resources.Tests;

public class ProductServiceTests
{
    [Fact]
    public void AddToList_ShouldReturnSuccess_WhenProductAddedToList()
    {
        Product product = new Product { ProductName= "Acer Monitor 27\" 4k", Price = "8700kr"};
        ProductService productService = new ProductService();

        ResultStatus result = productService.AddToList(product);
        var productList = productService.GetAllProducts();

        Assert.Equal(ResultStatus.Success, result);
        Assert.Single(productList);
    }
}
