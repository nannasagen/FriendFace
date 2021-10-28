using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    class Friends
    {
        public string UserName;
        public string UserQuote;
        public string UserPassword;
        public bool IsLoggedIn;
        public int UserAge;
        public string UserInfo;

        List<Friends> friendsList = new List<Friends>();

        public Friends(string username, string userquote, string userpassword)
        {
            UserName = username;
            UserQuote = userquote;
            UserPassword = userpassword;
            UserInfo = "Name " + UserName + "Quote: "+ UserQuote +" Alder: "+ UserAge;
        }

        public void AddFriend(Friends friend)
        {
            //return UserInfo; //Push til en venne-liste.
            friendsList.Add(friend);
            Console.WriteLine("You added a new friend :-) " + friend.UserName );
        }

        public void RemoveFriend(Friends friend)
        {
            if(friendsList.Contains(friend)) friendsList.Remove(friend);
            Console.WriteLine("You removed a friend :-( " + friend.UserName );
        }
    }
}
