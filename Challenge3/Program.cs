using System;
using System.Collections.Generic;

/*
When you post a message on Facebook, depending on the number of people who like your post,
Facebook displays different information.

- If no one likes your post, it doesn't display anything.
- If only one person likes your post, it displays: [Friend's Name] likes your post.
- If two people like your post, it displays: [Friend I] and [Friend 2] like your post.
- If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of
  Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses
Enter (without supplying a name). Depending on the number of names provided, display a
message based on the above pattern.
*/

namespace Challenge3
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                if (!ExecChallenge3())
                    break;
                Console.Clear();
            }
        }

        static bool ExecChallenge3()
        {
            var friends = new List<string>();
            string message;

            Console.WriteLine("Welcome to Challenge 3: Who likes my post ?");
            Console.WriteLine(new string('-', 50));

            
            while (true)
            {
                Console.Write("Enter a username: ");
                var friend = Console.ReadLine();
                if (string.IsNullOrEmpty(friend))
                    break;
                friends.Add(friend);
            }
            
            switch (friends.Count)
            {
                case 0:
                    message = ""; break;
                case 1:
                    message = $"{friends[0]} likes your post."; break;
                case 2:
                    message = $"{friends[0]} and {friends[1]} like your post."; break;
                default: 
                    message = $"{friends[0]}, {friends[1]} and {friends.Count - 2} others like your post."; break;
            }

            Console.WriteLine("\n"+message);
            Console.Write("Do you want to run the program again ? [y]: ");
            return Console.ReadLine() == "y";
        }

    }

}
