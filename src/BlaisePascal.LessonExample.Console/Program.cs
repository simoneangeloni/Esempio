using BlaisePascal.LessonExample3E.Domain;

public class Program //Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
    public static void Main()
    {
        Console.WriteLine("Inserisci il nome del cliente");
        string nomeCliente = Console.ReadLine();
        Console.WriteLine($"Benvenuto {nomeCliente} nella Easy Class 3E");
        Console.WriteLine("Inserisci il numero di pacchi che vuoi spedire");
        int numeroPacchiComprati = int.Parse(Console.ReadLine());
        
        int costoSpediziioneSingoloPacco = 5;
        string tipoConsegna = "Standard";
        int costoTotale = costoSpediziioneSingoloPacco + numeroPacchiComprati;
        Console.WriteLine($"il tipo di consegna scelto è: {tipoConsegna}");
        Console.WriteLine("Il costo totale della spedizione è: " + costoTotale + " euro");
        Enemy newEnemy = new Enemy();
        Vehicle newVehicle = new Vehicle("ab34");
        string license =newVehicle.LicensePlate;


    }
}
