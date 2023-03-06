class Program
{


    static double calculateSalary(double salary, double taxes)
    {
        return salary * (1 - taxes/100);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Quel est votre Salaire Brut : ");
        double salary = double.Parse(Console.ReadLine().Replace("€",""));
        Console.WriteLine("\nQuel est votre Taux d'imposition : ");
        double taxes = double.Parse(Console.ReadLine().Replace("%",""));
        Console.WriteLine("\nVous avez un salaire de : " + salary + "€ Brut");
        Console.WriteLine("\nImposable a " + taxes + "%");
        Console.WriteLine("\nVous gagnez donc : " +Math.Round(calculateSalary(salary, taxes),2) +"€ Net");
        Console.ReadLine();
    }
}
