namespace Quantum_BookStore_Fawry_Challenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService.Add(new EBook("1", "Ebook1",2000, 100,"txt"));
            BookService.Add(new PaperBook("2", "Ebook2",2000, 150,3));
            BookService.Add(new Demo("3", "Ebook3",2000, 100));

            BookService.Buy("2", 3, "MoTamerFarh@gmail.com", "Dumyat st 23");
            BookService.Buy("1", 1, "MoTamerFarh@gmail.com", "Dumyat st 23");

           // BookService.Buy("3", 1, "MoTamerFarh@gmail.com", "Dumyat st 23");
            BookService.RemoveBooksOlderThan(10);
            BookService.Buy("2", 3, "MoTamerFarh@gmail.com", "Dumyat st 23");
            




        }
    }
}
