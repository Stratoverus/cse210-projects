using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress1 = new("1841 W. Expressman St.", "Apache Junction", "Arizona", "USA");
        Customer myCustomer1 = new("Keith Eberhard", myAddress1);
        Product myProduct1 = new("Laptop", 121, 1299.99, 1);
        Product myProduct2 = new("Desktop Computer", 120, 1999.99, 2);
        List<Product> products1 = new(myProduct1, myProduct2);
        Order myOrder1 = new(myCustomer1, products1);

        Address myAddress2 = new("2898 W. 820 N.", "Provo", "Utah", "UK");
        Customer myCustomer2 = new("British Keith", myAddress2);
        Product myProduct2 = 
              
    }
}