using System;

class Program{
    static void Main()
    {
        //My solution
        /*string[] products = ["Apple", "Banana", "Milk", "Bread", "Eggs"];
        double[] prices = [0.5, 1.0, 1.5, 2.0, 2.5];

        Console.Write($"Product List: \n1. {products[0]} - {prices[1]}$\n2. {products[1]} - {prices[0]}$\n3. {products[2]} - {prices[3]}$\n4. {products[3]} - {prices[2]}$\n5. {products[4]} - {prices[4]}$\n\n");

        string[] shoppingCart = [products[0], products[1], products[2]];

        Console.WriteLine("Shopping Cart:");
        Console.Write($"{shoppingCart[0]} - {prices[1]}$\n{shoppingCart[1]} - {prices[0]}$\n{shoppingCart[1]} - {prices[3]}$\n");
        */
        
        //Course solution
        string[] products = ["Apple", "Banana", "Milk", "Bread", "Eggs"];
        double[] prices = [1.0, 0.5, 1.5, 2.0, 2.5];

        Console.WriteLine("Product List:");
        Console.WriteLine("1. " + products[0] + " - " + prices[0] + "$");
        Console.WriteLine("2. " + products[1] + " - " + prices[1] + "$");
        Console.WriteLine("3. " + products[2] + " - " + prices[2] + "$");
        Console.WriteLine("4. " + products[3] + " - " + prices[3] + "$");
        Console.WriteLine("5. " + products[4] + " - " + prices[4] + "$");

        int[] cartItems = {0, 2, 3};

        double totalCost = prices[cartItems[0]] + prices[cartItems[1]] + prices[cartItems[2]];

        Console.WriteLine("Shopping Cart:");
        Console.WriteLine(products[cartItems[0]] + " - " + prices[cartItems[0]] + "$");
        Console.WriteLine(products[cartItems[1]] + " - " + prices[cartItems[1]] + "$");
        Console.WriteLine(products[cartItems[2]] + " - " + prices[cartItems[2]] + "$");
        Console.WriteLine("Total Cost: $" + totalCost);
    }
}