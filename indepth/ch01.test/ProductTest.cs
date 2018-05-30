using System;
using System.Collections;
using Xunit;

public class ProductTest
{

    [Fact]
    public void TestName()
    {
        ArrayList products = Product.GetSampleProducts();
        foreach (var p in products)
        {
            Console.WriteLine("" + p);
        }
    }
}