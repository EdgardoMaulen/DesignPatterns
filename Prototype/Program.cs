using System;

namespace Prototype
{
    internal class Program
    {
        /*
         * me main idea is to have a single object and then be able to clone it so we can edit certain parts.
         * In this example we are using the same invitation card format, but we are changing the names of the invitee
         */
        static void Main(string[] args)
        {
            //to be able to clone an object we first create one instance of that object
            InvitationCard Card = new InvitationCard();
            Card.To = "Ram";
            Card.Title = "My Birthday Invitation";
            Card.Content = "Hey Guys!! I am throwing a cheers party in my home";
            Card.SendBy = "Sourav";
            Card.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());

            //now we use a foreach statement to run through a list of name and make a new card for each name on the list
            InvitationCard[] lettersToSend = new InvitationCard[5];
            String[] nameList = { "Ram", "Shyam", "Hari", "Tapan", "Sukant" };
            int i = 0;
            foreach (String name in nameList)
            {
                lettersToSend[i] = Card.CloneMe(Card);
                lettersToSend[i].To = name;
                i++;
            }

            //print the card list to check the result
            foreach (InvitationCard obj in lettersToSend)
            {
                Console.WriteLine("To :- " + obj.To);
                Console.WriteLine("Title :- " + obj.Title);
                Console.WriteLine("Content :- " + obj.Content);
                Console.WriteLine("Send By :- " + obj.SendBy);
                Console.WriteLine("Date :- " + obj.Date);
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
