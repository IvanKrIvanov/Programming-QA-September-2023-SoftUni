using NUnit.Framework;
using System;
using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;
    
    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }
    
    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        string productName = "Banana";
        double productPrice = 100;
        int productQuantity = 10;

        string expectedInvertory = $"Product Inventory:{Environment.NewLine}{productName} - Price: ${productPrice:f2} - Quantity: {productQuantity}";

        // Act
        this._inventory.AddProduct(productName, productPrice, productQuantity);

        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.AreEqual(expectedInvertory, result);
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        string firstProduct = "Banana";
        double firstProductPrice = 100;
        int firstProductQuantity = 10;
        
        string secondProduct = "Apple";
        double secondProductPrice = 10;
        int secondProductQuantity = 5;

        string expectedOutput = $"Product Inventory:{Environment.NewLine}{firstProduct} - Price: ${firstProductPrice:f2} - Quantity: {firstProductQuantity}{Environment.NewLine}{secondProduct} - Price: ${secondProductPrice:f2} - Quantity: {secondProductQuantity}";

        // Act
        this._inventory.AddProduct(firstProduct, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(secondProduct, secondProductPrice, secondProductQuantity);

        string result = this._inventory.DisplayInventory();


        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange

        // Act
        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(0, result);
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        string firstProductName = "Bread";
        double firstProductPrice = 100;
        int firstProductQuantity = 2;

        string secondProductName = "Sushi";
        double secondProductPrice = 10;
        int secondProductQuantity = 5;

        double expectedTotalsum = 250;

        // Act
        this._inventory.AddProduct(firstProductName, firstProductPrice, firstProductQuantity);
        this._inventory.AddProduct(secondProductName, secondProductPrice, secondProductQuantity);

        double result = this._inventory.CalculateTotalValue();

        // Assert
        Assert.AreEqual(expectedTotalsum, result);
    }
}
