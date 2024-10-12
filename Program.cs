//Liskov substitution principle:

public abstract class Elektronika
{
    public abstract void Working();
}

public class Telefon : Elektronika
{
    public override void Working()
    {
        Console.WriteLine("Telefon Isleyir");
    }
}

public class Kompyuter : Elektronika
{
    public override void Working()
    {
        Console.WriteLine("Kompyuter isleyir");
    }
}

//class Program
//{
/*    static void Main(string[] args)
    {
        Elektronika elektronikAlet = new Telefon();
        elektronikAlet.Working(); // Telefon

        elektronikAlet = new Kompyuter();
        elektronikAlet.Working(); // Kompyuter
    }
}*/


//Interface segregation principle:

public interface ICapMasini
{
    void RengliCapEt();
}

public interface IScanner
{
    void ScanEt();
}

//Dependency Inversion Principle

public interface IMotor
{
    void Islet();
}

public class BenzinliMotor : IMotor
{
    public void Islet()
    {
        Console.WriteLine("Benzinli motor Isleyir");
    }
}

public class DizelMotor : IMotor
{
    public void Islet()
    {
        Console.WriteLine("Dizel motor Isleyir");
    }
}

public class ElektrikliMotor : IMotor
{
    public void Islet()
    {
        Console.WriteLine("Elektrikli motor Isleyir");
    }
}

public class Masin
{
    private IMotor _motor;

    public Masin(IMotor motor)
    {
        _motor = motor;
    }

    public void MotorIslet()
    {
        _motor.Islet();
    }
}

class Program
{
    static void Main(string[] args)
    {

        Masin benzinliAraba = new Masin(new BenzinliMotor());
        benzinliAraba.MotorIslet(); // Benzinli motor

        Masin dizelAraba = new Masin(new DizelMotor());
        dizelAraba.MotorIslet(); // Dizel motor

        Masin elektrikliAraba = new Masin(new ElektrikliMotor());
        elektrikliAraba.MotorIslet(); // Elektrikli motor
    }
}