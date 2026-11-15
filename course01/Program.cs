//ASS SESSION2
using System;

namespace course01
{
    class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Book(string title = "", int pages = 0)
        {
            Title = title;
            Pages = pages;
        }

        public override string ToString()
        {
            return $"Book: {Title}, Pages: {Pages}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1: Create a Book object and store it in a variable of type object. Print it.
            Book book1 = new Book("C# Basics", 300);
            object obj = book1;
            Console.WriteLine(obj);
            #endregion

            #region Task 2: Print ToString(), Equals(), GetHashCode(), and GetType()
            Book book2 = new Book("OOP", 464);
            Console.WriteLine(book2.ToString());
            Console.WriteLine(book2.Equals(book2));
            Console.WriteLine(book2.GetHashCode());
            Console.WriteLine(book2.GetType());
            #endregion

            #region Task 3: Error Fix (Compile-time error)
            // Error: int pages = "464"; -> Compile-time error: can't put string into int
            int pages = 464;
            Console.WriteLine(pages);
            #endregion

            #region Task 4: Try-Catch-Finally (Divide by zero)
            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion

            #region Task 5: int to double without cast
            int pagesInt = 300;
            double pagesDouble = pagesInt;
            Console.WriteLine(pagesDouble);
            #endregion

            #region Task 6: double to int using cast
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion

            #region Task 7: String to int using Convert
            string pagesText = "464";
            int convertedPages = Convert.ToInt32(pagesText);
            Console.WriteLine(convertedPages);
            #endregion

            #region Task 8: int.Parse and int.TryParse
            string yearText = "2023";
            int yearParsed = int.Parse(yearText);
            Console.WriteLine(yearParsed);

            string badText = "abc";
            if (!int.TryParse(badText, out int resultBad))
            {
                Console.WriteLine("Invalid number");
            }
            #endregion

            #region Task 9: ToString() and GetType()
            int p9 = 464;
            string strPages = p9.ToString();
            Console.WriteLine(strPages.GetType());
            #endregion

            #region Task 10: Boxing and Unboxing
            int copies = 100;
            object boxed = copies;
            int unboxed = (int)boxed;
            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);
            #endregion

            #region Task 11: Nullable int (int?)
            int? year = null;
            Console.WriteLine(year.HasValue);
            year = 2023;
            Console.WriteLine(year.Value);
            #endregion

            #region Task 12: Nullable string (string?)
            string? reviewer = null;
            Console.WriteLine(reviewer == null);
            #endregion

            #region Task 13: Null-conditional operator (?.)
            Book? nullableBook = null;
            Console.WriteLine(nullableBook?.Title);
            #endregion

            #region Task 14: Null-coalescing (?? and ??=)
            string? title = null;
            Console.WriteLine(title ?? "Untitled");
            title ??= "Untitled";
            Console.WriteLine(title);
            #endregion

            #region Task 15: Null-forgiving operator (!)
            string? name = "Ahmed";
            string confirmedName = name!;
            Console.WriteLine(confirmedName);
            #endregion
        }
    }
}