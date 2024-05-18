using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();


        do
        {
            menu.DisplayMenu();
            if (menu.getOption() == 1)
            {
                Breathing breathingActivity = new Breathing("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingActivity.Run();
            }

            if (menu.getOption() == 2)
            {
                Reflecting reflectingActivity = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.Run();
            }

            if (menu.getOption() == 3)
            {
                Listing listingActivity = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.Run();
            }

        } while (menu.getOption() != 4);


    }
}