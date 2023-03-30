using System;
using System.Text;

// Базовий абстрактний клас транспортного засобу
public abstract class Vehicle
{
    private int speed;
    private int year;
    private string producer;
    private string model;

    public Vehicle(int speed, int year, string producer, string model)
    {
        this.speed = speed; //максимальна швидкість
        this.year = year; //рік
        this.producer = producer; //виробник
        this.model = model; //модель
    }

    public virtual void Drive()
    {
        Console.WriteLine("Їдемо"); 
    }

    // Абстрактний метод, що буде реалізовано в похідних класах
    public abstract void Repair();
    protected void StartEngine()
    {
        Console.WriteLine("Заведення двигуна"); 
    }
}

// Клас, що наслідується від Vehicle
public class Car : Vehicle
{
    private bool hasBody;

    public Car(int speed, int year, string producer, string model, bool hasBody)
        : base(speed, year, producer, model)
    {
        this.hasBody = hasBody; //наявність кузова
    }

    public override void Drive()
    {

        Console.WriteLine("Поїздка на машині"); 
    }

    public override void Repair()
    {
        Console.WriteLine("Ремонт машини"); 
    }
}

// Клас, що наслідується від Vehicle
public class Motorcycle : Vehicle
{
    private int Size;

    public Motorcycle(int speed, int year, string producer, string model, int Size)
        : base(speed, year, producer, model)
    {
        this.Size = Size; //розмір 
    }

    public override void Drive()
    {
        Console.WriteLine("Поїздка на мото"); 
    }

    public override void Repair()
    {
        Console.WriteLine("Ремонт мото"); 
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        // Створення об'єктів класів
        Car car = new Car(210, 2013, "Volkswagen", "beetle", true);
        Motorcycle motorcycle = new Motorcycle(120, 1992,  "Jawa Moto", "Jawa-350", 2080);

        // Виклик методів об'єктів
        car.Drive();
        motorcycle.Drive();

        car.Repair();
        motorcycle.Repair();
    }
}
