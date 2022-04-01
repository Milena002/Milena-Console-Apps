using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App04
{
    internal class NewsApp
    {
        public NewsList NewsList { get; set; } = new NewsList();
       

        private void SelectOptions(int choice)
        {
            if (choice == 1)
            {
                AddMessage();
                Run();
            }
            else if (choice == 2)
            {

               
                Run();
            }
            else if (choice == 3)
            {

                
                Run();
            }
            else
            {

                Environment.Exit(0);
            }
        }
        public void Run()
        {
            ConsoleHelper.OutputHeading("Students Marks");

            string[] choices =
            {
              "Add a Message Post",
               "Add a Photo Post",
               "Display All Posts",
               "Quit"

            };

            ConsoleHelper.OutputTitle("Please selecet the option you wish to use:");
            int choice = ConsoleHelper.SelectChoice(choices);
            SelectOptions(choice);
        }

        private void AddMessage()
        { 
            Console.Write("Please enter your name > ");
            string name = Console.ReadLine();

            Console.Write("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsList.AddPost(post);
        }
    }
}
