using System;
using System.Collections.Generic;
using System.Linq;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void PrintItems(IEnumerable<dynamic> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = MusicStore.GetData().AllArtists;
            List<Group> Groups = MusicStore.GetData().AllGroups;

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            // (the same as the next line) List<Artist> FromMtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon").ToList();
            // IEnumerable<Artist> FromMtVernon = Artists.Where(artist => artist.Hometown == "Mount Vernon");

            // Console.WriteLine(FromMtVernon);
            // PrintItems(FromMtVernon);

            // Artist FromMt = Artists.FirstOrDefault(art => art.Hometown =="Mount Vernon");
            // Console.WriteLine(FromMt);
            // FromMtVernon.Add

            //Who is the youngest artist in our collection of artists?
            // int youngestValue = Artists.Min(a => a.Age);
            // Artist youngest = Artists.FirstOrDefault(artist => artist.Age == Artists.Min(a => a.Age));
            // Console.WriteLine(youngest.Age);
            //.Where(artist => artist.Age == Artists.Min(artist => artist.Age));
            
            //Display all artists with 'William' somewhere in their real name
            // IEnumerable<Artist> NamedWill = Artists.Where(artist => artist.RealName.Contains("William"));
            // Console.WriteLine("Hello");
            // PrintItems(NamedWill);


            //Display the 3 oldest artist from Atlanta
            // IEnumerable<Artist>  Oldest = Artists.Where(artist => artist.Hometown == "Atlanta").OrderByDescending(a => a.Age).Take(3);
            // foreach (var item in Oldest)
            // {
            //     Console.WriteLine(item.ArtistName);
                
            // }


            //(Optional) Display the Group Name of all groups that have members that are not from New York City
            // IEnumerable<Artist> notNewY = Artists.Where(artist => artist.Hometown != "New York City");
            // foreach (var item in notNewY)
            // {
            //     Console.WriteLine(item.ArtistName);
            // }
            

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
            // Console.WriteLine(Groups.Count);
            // int GroupId = Artist.Where(args => a.) 
            IEnumerable<Group> Wu = Groups.Where(artist => artist.GroupName == "Wu-Tang-Clan");
            foreach (var item in Wu)
            {
                Console.WriteLine(item.Members);
            }

                        // int youngestValue = Artists.Min(a => a.Age);
            // Artist youngest = Artists.FirstOrDefault(artist => artist.Age == Artists.Min(a => a.Age));
        }
    }
}
