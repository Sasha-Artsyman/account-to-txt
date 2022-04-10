using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("---  Account to .txt  ---");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Product + number + price");
        Console.WriteLine("(Press key 'End' to save)");
        Console.WriteLine("-------------------------\n");

        try
        {
            // создание файла
            StreamWriter ListOfNotes = new StreamWriter("D:\\Account.txt");
            ListOfNotes.WriteLine("Account dated " + DateTime.Today.ToShortDateString() + ":");
            ListOfNotes.WriteLine("-------------------------");

            int num0 = 1;
            bool save0 = false;
            int sum = 0;

            do
            {
                Console.Write("{0}. ", num0);

                string productInromation = Console.ReadLine();

                var productInromationPar = productInromation.Split(" ");

                ListOfNotes.WriteLine(Convert.ToString(num0) + ". " + productInromationPar[0] + " .......... " + (Convert.ToInt32(productInromationPar[1]) * Convert.ToInt32(productInromationPar[2])) + " $");
                sum += Convert.ToInt32(productInromationPar[1]) * Convert.ToInt32(productInromationPar[2]);
                num0++;

                if (Console.ReadKey(true).Key == ConsoleKey.End)
                {
                    ListOfNotes.WriteLine("-------------------------");
                    ListOfNotes.WriteLine("Total .......... " + sum + " $");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Total .......... " + sum + " $");
                    Console.Write("Payment: ");

                    int payment = Convert.ToInt32(Console.ReadLine());
                    ListOfNotes.WriteLine("Payment .......... " + payment + " $");

                    ListOfNotes.WriteLine("Change .......... " + (payment - sum) + " $");
                    Console.WriteLine("Change .......... " + (payment - sum) + " $");

                    Console.WriteLine("\nSaving...");
                    save0 = true;
                }
            }
            while (!save0);


            ListOfNotes.Close();
        }
        catch (Exception e0)
        {
            Console.WriteLine("Exception: " + e0.Message);
        }

        Console.ReadLine();

    }
}