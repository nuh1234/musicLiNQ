using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();
            String key = "Mount Vernon";
            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> found = Artists.Where(artist => artist.Hometown == key);
            foreach (Artist i in found) {
                Console.WriteLine("{0} is from {1}", i.ArtistName, i.Hometown.ToString());
            }

            //Who is the youngest artist in our collection of artists?
            Artist youngest = (from match in Artists orderby match.Age ascending select match).First();
            Console.WriteLine("Youngest at {0} is {1}", youngest.Age, youngest.ArtistName);
            //Display all artists with 'William' somewhere in their real name

            //Display the 3 oldest artist from Atlanta

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
