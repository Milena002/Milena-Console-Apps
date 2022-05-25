using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App04
{
    internal class NewsApp
    {
        public NewsList News { get; set; } = new NewsList();

        

        private void SelectOptions(int choice)
        {
            if (choice == 1)
            {
                PostMessage();
                Run();
            }
            else if (choice == 2)
            {

                PostImage();
                Run();
            }
            else if (choice == 3)
            {

                RemovePost();
                Run();
            }
            else if (choice == 4)
            {
                DisplayAll();
                Run();
            }
            else if (choice == 5)
            {
                DisplayByAuthor();
                Run();
            }
            
            else if (choice == 6)
            {
                AddComments();
                Run();
            }
            else if (choice == 7)
            {
                LikePost();
                Run();
            }
            else if (choice == 8)
            {
                UnlikePost();
                Run();
            }
            else
            {
                Quit();
               
            }
        }

        private void Quit()
        {
            Environment.Exit(0);
        }

        private void UnlikePost()
        {
            DisplayAll();
            int number = (int)ConsoleHelper.InputNumber(" Please choose which post You want to dislike : ", 1, News.PostList.Count);

            News.PostList[number - 1].Unlike();

            Console.WriteLine("You have unliked the below post:");
            News.PostList[number - 1].Display();
        }

        private void LikePost()
        {
            DisplayAll();
            int number = (int)ConsoleHelper.InputNumber(" Please choose which post You want to like : ", 1, News.PostList.Count);

            News.PostList[number - 1].Like();

            Console.WriteLine("You have liked the below post: ");
            News.PostList[number - 1].Display();
        }

        private void AddComments()
        {
            DisplayAll();
            int number = (int)ConsoleHelper.InputNumber("Please enter which number of post You would like to comment: : ", 1, News.PostList.Count);

            Console.WriteLine("You will comment on the below post: ");
            News.PostList[number - 1].Display();

            Console.WriteLine("Write your comment here: ");
            string text = Console.ReadLine();
            News.PostList[number - 1].AddComment(text);
        }

        public void Run()
        {
            ConsoleHelper.OutputHeading("Social Network");

            string[] choices =
            {
              "Add a Message Post",
               "Add a Photo Post",
               "Remove Post",
               "Display All Posts",
               "Display Posts by Author",
               "Add Comments to Post",
               "Like Post",
               "Unlike Post",
               "Quit"

            };

            ConsoleHelper.OutputTitle("Please selecet the option you wish to use:");
            int choice = ConsoleHelper.SelectChoice(choices);
            SelectOptions(choice);
        }
    
        private void DisplayByAuthor()
        {
            Console.WriteLine(" Please enter the author's name/nickname : ");
            string author = Console.ReadLine();
            foreach (Post post in News.PostList)
            {
                if (post.Author == author)
                {
                    post.Display();
                }
            }
        }

        public void RemovePost()
        {
            ConsoleHelper.OutputTitle($"    Removing a Post");
            DisplayAll();
            ConsoleHelper.OutputTitle($"    Which one you would like to remove? ");
            int id = (int)ConsoleHelper.InputNumber("Please enter the post id > ",
                                                    1, News.PostList.Count);
            Console.WriteLine("You removing this post; ");
            News.PostList [id - 1].Display();
            News.PostList.RemoveAt(id - 1);

            Console.Write("Other Posts: ");
           DisplayAll();
        }
        internal void DisplayAll()
        {
            News.Display();
        }
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string name = InputName();

            Console.Write("Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            News.AddPost(post);

            ConsoleHelper.OutputTitle("You have just posted this message: ");
            post.Display();
        }

        

        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

      
            string name = InputName();

            Console.Write("Please enter your image filename > ");
            string filename = Console.ReadLine();


            Console.Write("Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(name, filename, caption);
            News.AddPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image: ");
            post.Display();


        }
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string name = Console.ReadLine();

            return name;
        }
    }
}
