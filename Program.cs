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
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();
            const String KEY = "William";
            //========================================================
            //Solved all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            IEnumerable<Artist> found = Artists.Where(artist => artist.Hometown == KEY);
            foreach (Artist i in found) {
                Console.WriteLine("Match found for hometown {0} - {1}", KEY, i.Hometown.ToString());
            }

            //Who is the youngest artist in our collection of artists?
            Artist youngest = (from match in Artists orderby match.Age ascending select match).First();
            Console.WriteLine("Youngest at {0} is {1}", youngest.Age, youngest.ArtistName);
            //Display all artists with 'William' somewhere in their real name
            IEnumerable<Artist> matches = Artists.Where(match => match.RealName.Contains(KEY));
            foreach (Artist i in matches) {
                Console.WriteLine("Match found for real name {0} - {1}", KEY, i.RealName);
            }
            //Display the 3 oldest artist from Atlanta
            IEnumerable<Artist> 
            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
