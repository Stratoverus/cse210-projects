using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress1 = new("1841 W. Expressman St.", "Apache Junction", "Arizona", "USA");
        Customer myCustomer1 = new("Keith Eberhard", myAddress1);
        Product myProduct1 = new("Laptop", 121, 1299.99, 1);
        Product myProduct2 = new("Desktop Computer", 120, 1999.99, 2);
        List<Product> products1 = [myProduct1, myProduct2];
        Order myOrder1 = new(myCustomer1, products1);

        Console.WriteLine($"{myOrder1.DisplayLabels}");

        Address myAddress2 = new("2898 W. 820 N.", "Provo", "Utah", "UK");
        Customer myCustomer2 = new("British Keith", myAddress2);
        Product myProduct3 = new("Graphics Card", 143, 999.99, 1);
        Product myProduct4 = new("Motherboard", 189, 199.99, 1);
        List<Product> products2 = [myProduct3, myProduct4];
        Order myOrder2 = new(myCustomer2, products2);

        Console.WriteLine($"{myOrder2.DisplayLabels}");
    }
}