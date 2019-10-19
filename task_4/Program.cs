using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Libraries
    {
    public string LibraryName;
    public string Location;
    public List<string> Books;
    public Libraries(string libraryname, string location)
        {
        this.LibraryName = libraryname;
        this.Location = location;
        this.Books = new List<string>();
        }
    }


    class Program
        {
    static void Main(string[] args)
        {
        List<Libraries> bookstorage = new List<Libraries>();
        string input = Console.ReadLine();
        while (input != "Done")
            {
            List<string> data = input.Split(':').ToList();
            if (data[0] == "Library")
                {
                string libraryName = data[1];
                string location = data[2];
                bool isExist = false;
                foreach (var librari in bookstorage)
                    {
                    if (librari.LibraryName == libraryName)
                        {
                        isExist = true;
                        break;
                        }
                    }
                if (!isExist)
                    {
                    Libraries current = new Libraries(libraryName, location);
                    bookstorage.Add(current);
                    }
                }
            else if (data[0]== "Book")
                {
                string bookName = data[1];
                string belongsTo = data[2];
                if (bookstorage.Any(x=>x.LibraryName==belongsTo))
                    {
                    bookstorage.First(x => x.LibraryName == belongsTo).Books.Add(bookName);
                    }
                else
                    {
                    Console.WriteLine($"Library {belongsTo} does not exist!");
                    }
                }
                input = Console.ReadLine();
                }
        foreach (Libraries library in bookstorage)
            { 
            Console.WriteLine($"Library {library.LibraryName}, based in {library.Location}:");
            Console.WriteLine(String.Join(", ", library.Books));
            }
      }
    }
