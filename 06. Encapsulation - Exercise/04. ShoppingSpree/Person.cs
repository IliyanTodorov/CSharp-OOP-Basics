using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    private string name;
    private double money;
    private List<Product> bagOfProducts;

    public Person(string name, double money)
    {
        BagOfProducts = new List<Product>();

        Name = name;
        Money = money;
    }

    public string Name
    {
        get
        {
            return name;
        }
        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            name = value;
        }
    }

    public double Money
    {
        get { return money; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            money = value;
        }
    }
    
    public List<Product> BagOfProducts                  
    {
        get { return bagOfProducts; }
        private set { bagOfProducts = value; }
    }

    public void Add(Product product)
    {
        double cost = product.Cost;
        if (cost > Money)
        {
            Console.WriteLine($"{Name} can't afford {product.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} bought {product.Name}");
            BagOfProducts.Add(product);
            Money -= cost;
        }
    }

    public override string ToString()
    {
        if (BagOfProducts.Count == 0)
        {
            return $"{Name} - Nothing bought";
        }
        else
        {
            return $"{Name} - {String.Join(", ", BagOfProducts.Select(p => p.ToString()))}";
        }
    }
}
