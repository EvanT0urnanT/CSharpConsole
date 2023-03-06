class Program
{


    static double calculateSalary(int salary, double taxes)
    {
        return salary * (1 - taxes / 100);
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Quel est votre Salaire Brut : ");
        bool salaryInInt = int.TryParse(Console.ReadLine().Replace("€", ""), out int salary);
        Console.WriteLine("\nQuel est votre Taux d'imposition : ");
        double taxes = double.Parse(Console.ReadLine().Replace("%", ""));
        Console.WriteLine("\nVous avez un salaire de : " + salary + "€ Brut" + "\nImposable a " + taxes + "%");
        Console.WriteLine("\nVous gagnez donc : " + Math.Round(calculateSalary(salary, taxes), 2) + "€ Net");
        switch (salary)
        {
            case >= 50000:
                Console.WriteLine("Je vous conseille de faire des dons à des associations tels que l'Oeuvre des Pupilles pour réduire votre Imposition");
                break;

            case <= 1500 * 12:
                Console.WriteLine("Ce salaire est normal pour un alternant");
                break;

            default:
                Console.WriteLine("Venez travailler chez CESI vous gagnerez 100000€ brut");
                break;
        }
        Console.ReadLine();
    }
}
