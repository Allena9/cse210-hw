using System;

class Program
{
    static void Main(string[] args)
    {
        int menu = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            menu = Int32.Parse(Console.ReadLine());

            if(menu == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if(menu == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }
            else if(menu == 3)
            {
                ListingActivity list = new ListingActivity();
                list.Run();
            }
            else if(menu != 4)
            {
                Console.WriteLine("Invalid Input, try again.");
                Thread.Sleep(1000);
            }
        }while(menu != 4);
    }
}