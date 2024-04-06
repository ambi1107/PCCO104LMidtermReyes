using System;

class Program
{
    static void Main(string[] args)
    {
        const int baseFanPower = 10;
        int fanSpeed;
        char oscillateOption;

        do
        {
            Console.WriteLine("Enter fan speed (1, 2, or 3):");
            string speedInput = Console.ReadLine();
            if (!int.TryParse(speedInput, out fanSpeed) || fanSpeed < 1 || fanSpeed > 3)
            {
                Console.WriteLine("Invalid input. Please enter a valid fan speed.");
                continue;
            }

            Console.WriteLine("Oscillate option (Y/N):");
            string oscillateInput = Console.ReadLine();
            if (!char.TryParse(oscillateInput, out oscillateOption) || (oscillateOption != 'Y' && oscillateOption != 'N'))
            {
                Console.WriteLine("Invalid input. Please enter 'Y' or 'N'.");
                continue;
            }

            break; 
        } while (true);

        if (oscillateOption == 'Y')
        {
            for (int i = 1; i <= baseFanPower * fanSpeed; i++)
            {
                Console.WriteLine(new string('~', i));
            }
            for (int i = baseFanPower * fanSpeed - 1; i >= 1; i--)
            {
                Console.WriteLine(new string('~', i));
            }
        }
        else
        {
            string steadyOutput = new string('~', baseFanPower * fanSpeed);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(steadyOutput);
            }
        }
    }
}
