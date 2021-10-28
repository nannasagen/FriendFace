using System;
using System.Collections.Generic;

namespace FriendFace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Friends> UserList = new List<Friends>();

            UserList.Add(new Friends("Nanna", "Tomater ruler!", "Passord"));
            UserList.Add(new Friends("Tomato", "Ketchup is genocide", "CatchUp"));
            UserList.Add(new Friends("Orange", "You peel me?", "OrangeYouGlad"));
            UserList.Add(new Friends("Cake", "Eat me!", "Cheese"));

            Friends myuser = UserList[0];

            Console.WriteLine("Enter FriendName:");
            string inputs = Console.ReadLine();
            foreach (Friends userfriend in UserList)
            {
                if(userfriend.UserName == inputs)
                    myuser.AddFriend(userfriend);
            }

            Console.WriteLine("What friends do you want to YEEEEET? ");
            inputs = Console.ReadLine();
            foreach (Friends myfriends in UserList)
            {
                if(myfriends.UserName == inputs)
                {
                    myuser.RemoveFriend(myfriends);

                }
            }
        }
    }
}
