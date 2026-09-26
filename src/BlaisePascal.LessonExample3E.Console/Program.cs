public class Program //Questa è una classe
{
    // Metodo di entrata per esecuzione del codice
  public static void Main()
    {
       Console.WriteLine("Benvenuto nella Easy Class 3E");

        int numeroPacchiComprati = 2;
        int costoSpediziioneSingoloPacco = 5;
        string tipoConsegna = "Standard";
        int costoTotale = costoSpediziioneSingoloPacco + numeroPacchiComprati;
        Console.WriteLine($"il tipo di consegna scelto è: {tipoConsegna}");
        Console.WriteLine("Il costo totale della spedizione è: "+costoTotale + " euro");
    }
}
