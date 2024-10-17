using Resources.Enums;
using Resources.Models;
using Resources.Services;

namespace MainApp.Menus;

internal class ProductMenu
{
    private readonly ProductService _productService = new();
    public void CreateMenu()
    {
        Product product = new Product();

        Console.Clear();
        Console.WriteLine("Create New Product");

        Console.Write("Enter Product Name: ");
        product.ProductName = Console.ReadLine()!;

        Console.Write("Enter Price for product in SEK: ");
        product.Price = Console.ReadLine()!;


        var result = _productService.AddToList(product);

        switch(result)
        {
            case ResultStatus.Success:
                Console.WriteLine("\nProduct was successfully created.");
                break;

            case ResultStatus.Exists:
                Console.WriteLine("\nProduct already exist in list.");
                break;
            
            case ResultStatus.Failed:
                Console.WriteLine("\nSomething went wrong.");
                break;

            case ResultStatus.SuccessWithErrors:
                Console.WriteLine("\nProduct created successfully, but unable to add to list.");
                break;
        }



        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public void ViewAllMenu()
    {
        var productList = _productService.GetAllProducts();

        Console.Clear();
        Console.WriteLine("View All Products\n");

        if (productList.Any())
        {
            foreach (Product product in productList)
            {
                Console.WriteLine($"Product Id:{product.Id} \nProduct Name:{product.ProductName} \nPrice:{product.Price}kr \n ");
            }
        }

        else
        {
            Console.WriteLine("No Products in list. Try adding a product by using the create menu.\n");
        }

        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }



}
