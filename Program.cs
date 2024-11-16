using System.Runtime.CompilerServices;

abstract class Delivery
{
    public abstract void Address();
    public abstract void Name();
    public abstract void SecondName();
    public abstract void PhoneNumber();
}

class HomeDelivery : Delivery
{
    public override void Address()
    { }
    public override void Name()
    { }
    public override void SecondName()
    { }
    public override void PhoneNumber()
    { }
}

class PickPointDelivery : Delivery
{
    public override void Address()
    { }
    public override void Name()
    { }
    public override void SecondName()
    { }
    public override void PhoneNumber()
    { }
}

class ShopDelivery : Delivery
{
    public override void Address()
    { }
    public override void Name()
    { }
    public override void SecondName()
    { }
    public override void PhoneNumber()
    { }
}

class Order<TDelivery,
TStruct> where TDelivery : Delivery
{
    public TDelivery Delivery;

    public int Number;

    public string Description;

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public void DisplayName()
    {
        Console.WriteLine(Delivery.Name);
    }

    public void DisplaySecondName()
    {
        Console.WriteLine(Delivery.SecondName);
    }

    public void DisplayPhoneNumber()
    {
        Console.WriteLine(Delivery.PhoneNumber);
    }
}    

