using System;

class Drink
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Drink(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Barista
{
    public string Name { get; set; }

    public Barista(string name)
    {
        Name = name;
    }

    public void MakeDrink(Drink drink, Customer customer)
    {
        Console.WriteLine($"{Name} готує {drink.Name} для {customer.Name}.");
        customer.ReceiveDrink(drink);
    }
}

class Customer
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public void OrderDrink(Barista barista)
    {
        Console.WriteLine("Виберіть напій: 1. Матча 2. Лате на кокосовому 3. Чай каркаде");
        string choice = Console.ReadLine() ?? "1";

        Drink drink = choice switch
        {
            "1" => new Drink("Матча", 50),
            "2" => new Drink("Лате на кокосовому", 70),
            "3" => new Drink("Чай каркаде", 40),
            _ => new Drink("Вода", 20)
        };

        barista.MakeDrink(drink, this);
    }

    public void ReceiveDrink(Drink drink)
    {
        Console.WriteLine($"{Name} отримав(ла) {drink.Name}. Смачного!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть ваше ім'я:");
        string customerName = Console.ReadLine() ?? "Гість";
        Customer customer = new Customer(customerName);
        Barista barista = new Barista("Аліса");

        customer.OrderDrink(barista);
    }
}
