using System;

class Program
{
    static void Main(string[] args)
    {
        Order myOrder1 = new();
        myOrder1._customer = new Customer("Keith Eberhard", new Address("1841 W. Expressman St.", "Apache Junction", "Arizona", "USA"));
        myOrder1._products.Add(new Product("Laptop", 121, 1299.99, 1));
        

        Order myOrder2 = new();
              
    }
}