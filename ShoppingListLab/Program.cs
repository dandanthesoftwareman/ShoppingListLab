using System.Collections;
bool orderMore = true;
double cartTotal = 0;
Console.WriteLine("Welcome to the CandyShack!");

Dictionary<string, double> menu = new Dictionary<string, double>()
{
    {"Chocolate Bar", 1.99},
    {"Jelly Beans", 4.50},
    {"Sucker", .35},
    {"Nougat Bar", 2.50},
    {"Sour Straws", 1.99},
    {"Caramel Bites", 3.25},
    {"Fizzy Drops", .99},
    {"Licorice", 2.35},
    {"Oversized Lollipop", 75.00}
};
List<string> shoppingList = new List<string>();

Console.WriteLine("Here is our menu at the CandyShack");

while(orderMore)
{
    //Display menu
    Console.WriteLine(String.Format("{0,-20} | {1,-20}", "Item", "Price"));
    Console.WriteLine("===============================");
    foreach (KeyValuePair<string, double> kvp in menu)
    {
        Console.WriteLine(String.Format("{0,-20} | {1,-20}", $"{kvp.Key}", $"${kvp.Value}"));
    }

    Console.WriteLine("What would you like to buy?");
    string choice = Console.ReadLine();
    
    if (menu.ContainsKey(choice)) 
    {
        shoppingList.Add(choice);
        Console.WriteLine($"Added {choice} to cart at ${menu[choice]}");
        while (true)
        {
            Console.WriteLine("Would you like to order anything else? (y/n)");
            string response = Console.ReadLine().ToLower();
            if (response == "y")
            {
                Console.WriteLine("");
                break;
            }
            else if (response == "n")
            {
                orderMore = false;
                break;
            }
            else
            {
                continue;
            }
        }
    } 
    else
    {
        Console.WriteLine("Sorry, but we don't carry any of those at the CandyShack. Please try again.");
        Console.WriteLine("");
    }
}
Console.WriteLine("Thanks for your order!");
Console.WriteLine("Here's what you got:");
Console.WriteLine("===============================");

foreach (string i in shoppingList)
{
    Console.WriteLine(String.Format("{0,-20} | {1,-20}", $"{i}", $"${menu[i]}"));
    cartTotal += menu[i];
}

Console.WriteLine($"Your total is: ${cartTotal}");
