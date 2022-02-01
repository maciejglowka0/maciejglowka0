using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Library
{
    #region class Book


    public class Book
    {
        //klasa która przechowuje informacje o książkach
        public string Tittle;
        public string Author;
        public int Pages;
        public int ReleaseDate;

    }
    #endregion


    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            #region Loop do...while && switch - Task selection

            do
            {
                Console.Write("Wybierz zadanie, które chcesz wykonać: \n (1) Utwórz nowy katalog \n " +
                    "(2) Zapisz katalog do pliku \n (3) Odczytaj katalog z pliku \n (4) Wyszukaj książkę w katalogu \n (5) Koniec \n" +
                    "Wybierz zadanie z menu i zatwierdź przyciskiem ENTER: ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        books = CreateNewCatalog();
                        break;
                    case 2:
                        SaveCatalogToFile(books);
                        break;
                    case 3:
                        ReadCatalogFromFile();
                        break;
                    case 4:
                        SearchForBooks();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
                Console.Clear();
            }
            while (true);
        }

      
        #endregion
        private static List<Book> CreateNewCatalog()

        #region Loop for - Catalog data input


        {
            var books = new List<Book>();
            Console.Write("Podaj ile książek chcesz dodać do katalogu: ");
            int HowMuch = int.Parse(Console.ReadLine());

            for (int i = 0; i < HowMuch; i++)
            {
                Console.Write("Podaj tytuł: ");
                string Tittle = Console.ReadLine();
                Console.Write("Podaj autora: ");
                string Author = Console.ReadLine();
                Console.Write("Podaj ilość stron: ");
                int Pages = int.Parse(Console.ReadLine());
                Console.Write("Podaj datę wydania: ");
                int ReleaseDate = int.Parse(Console.ReadLine());


                Book book = new Book()
                {
                    Tittle = Tittle,
                    Author = Author,
                    Pages = Pages,
                    ReleaseDate = ReleaseDate,

                };
                books.Add(book);
            }
            return books;
        }
        #endregion

        private static void SaveCatalogToFile(List<Book> books)

        #region if condition && foreach Loop


        {
            Console.Write("Podaj nazwę pliku katalogu: ");
            string Tittle = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(Tittle);
            if (di.Exists == false)
            {
                using (StreamWriter
                       file = new StreamWriter(Tittle +
                                               ".txt"))
                {
                    foreach (var book in books)
                    {
                        file.WriteLine(
                            $"{book.Tittle}, {book.Author}, {book.Pages}, {book.ReleaseDate}");
                    }
                }

                return;
            }
            #endregion

            Console.WriteLine("Brak książek do zapisania");
            Console.ReadLine();
        }

        private static void ReadCatalogFromFile()

        #region if condition - Catalog data search


        {
            Console.Write("Podaj nazwę pliku katalogu: ");
            string Tittle = Console.ReadLine();
            if (File.Exists(Tittle + ".txt"))
            {
                using (StreamReader file = new StreamReader(Tittle + ".txt"))
                {
                    Console.WriteLine(
                        "Tytuł, Autor, Ilość stron, Data wydania");
                    Console.WriteLine(file.ReadToEnd());
                    Console.ReadLine();
                }
            }
        }
        #endregion

        #region Books search function
        private static void SearchForBooks()
        {
            string line;
            int counter = 0;
            List<string> expectedNames = new List<string>();
            Console.Write("Podaj nazwę katalogu: ");
            string bookTittle = Console.ReadLine();

            if (File.Exists(bookTittle + ".txt"))
            {
                using (StreamReader file = new StreamReader(bookTittle + ".txt"))
                {
                    Console.Write("Podaj tytuł: ");
                    string tytul = Console.ReadLine();

                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.ToLower().Contains(tytul.ToLower()))
                        {
                            expectedNames.Add(line);
                        }
                    }

                    Console.WriteLine("Wyniki wyszukiwania");
                    foreach (string expected in expectedNames)
                    {
                        string[] l = expected.Split(',');
                        Console.WriteLine(++counter + " wynik");
                        Console.WriteLine(
                            $"Tytuł: {l[0]} \n Autor:{l[1]} \n Ilość stron:{l[2]} \n Data wydania:{l[3]}");
                    }
                }

                Console.ReadLine();
            }
        }
        #endregion
    }
}