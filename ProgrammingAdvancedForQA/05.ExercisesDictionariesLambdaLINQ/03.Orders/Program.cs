Dictionary<string, List<decimal>> products = new();

string input = Console.ReadLine();

while (input != "buy")
{
    string[] inputArray = input.Split();
    string product = inputArray[0];
    decimal price = decimal.Parse(inputArray[1]);
    decimal quantity = decimal.Parse(inputArray[2]);

    if (!products.ContainsKey(product))
    {
        products.Add(product, new List<decimal>());
        products[product].Add(price);
        products[product].Add(quantity);
    }
    else
    {
        products[product][0] = price;
        products[product][1] += quantity;
    }
    input = Console.ReadLine();
}

foreach(var product in products)
{
    string currentProductName = product.Key;
    decimal currentProductPrice = product.Value[0];
    decimal currentProductQuantity = product.Value[1];

    decimal currentProductAmount = currentProductPrice * currentProductQuantity;

    Console.WriteLine($"{currentProductName} -> {currentProductAmount:F2}");
}