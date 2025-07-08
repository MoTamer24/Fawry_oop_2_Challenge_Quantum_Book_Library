namespace Quantum_BookStore_Fawry_Challenge2
{
    internal static  class BookService
    {
         static List<Book> books=new List<Book>();
       
        public static bool Add(Book book)
        {
            books.Add(book);
            return true;
        }

        public static void Buy(string ISBN,int OrderedQuantity ,string Email,string Address)
        {
            var book = books.Find(b => b.ISBN == ISBN);
            if (book is null) throw new Exception($"No book with {ISBN} ISBN");

            book.Buy(OrderedQuantity, Email, Address);
        }

        public static int RemoveBooksOlderThan(int years)
        {
            var booksToRemove = books.Where(b => b.Year < (DateTime.Now.Year - years)).ToList();

            foreach (var book in booksToRemove)
            {
                books.Remove(book);
                Console.WriteLine($"Removed outdated book - {book.Title}");
            }
            return booksToRemove.Count;
        }

        public static List<Book> ReturnBooksOlderThan(int years)
        {
            int counter = 0;
            List<Book>result = new List<Book>();
            foreach (var book in books)
            {
                if (book.Year < DateTime.Now.Year - years)
                {
                    result.Add(book);
                    counter++;
                }
            }
            return result;
        }





    }
}
