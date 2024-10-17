namespace MainApp.Menus;

public class Menu
{
    private readonly ProductMenu _productMenu = new ProductMenu();

    public void MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Main Menu");
        Console.WriteLine("1. Create Product");
        Console.WriteLine("2. View All Products");
        Console.Write("\nEnter your choice from list: ");

        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                _productMenu.CreateMenu();
                break;

            case "2":
                _productMenu.ViewAllMenu();
                break;

            default:
                Console.WriteLine("\nNon-valid option, please try again by pressing any key.");
                Console.ReadKey();
                break;
        }

    }


}
