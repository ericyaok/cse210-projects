using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Order!");

        Customer customer1 = new Customer("Eric", new Address("7 Great Street","GreenVille","Ohio","USA"));
        Customer customer2 = new Customer("Deric Doe", new Address("7 Grace AVE","Ville","London","UK"));

        Product product1 = new Product("Computer","AL009",1200,5);
        Product product2 = new Product("Table","AL3011",100,2);
        Product product3 = new Product("Broom","AL22",200,6);
        Product product4 = new Product("Ball","AL09",120,2);

        List<Product> productList1 = new List<Product>{product1,product2};
        List<Product> productList2 = new List<Product>{product3,product4};

        Order order1 = new Order(customer1,productList2);
        Order order2 = new Order(customer2,productList1);

        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine(order1.CalcTotalCost());
          

    }
}