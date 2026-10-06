using BlaisePascal.LessonExample3E.Domain;

public class Program //Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        //Vehicle vehicle2 = new Vehicle(); //non esiste un costruttore senza parametri definito nella classe, quindi non è possibile creare un oggetto Vehicle senza passare almeno la targa come parametro
        Vehicle vehicle = new Vehicle("abc");
        string license = vehicle.LicensePlate;
        Console.WriteLine(license);



        /*
        Vehicle vehicle1 = new Vehicle("xyz", -1, 50, 75);
        Console.WriteLine(vehicle1.LicensePlate);
        Console.WriteLine(vehicle1.OdometerKm);
        Console.WriteLine(vehicle1.DailyRate);
        Console.WriteLine(vehicle1.FuelLevelPercentage);
        */
        Enemy enemy = new Enemy();
        enemy.setHealth(1);
        Console.WriteLine($"the enemy's healt is {enemy.Health}");

    }
}
