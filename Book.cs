using Quantum_BookStore_Fawry_Challenge2.Interfaces;


namespace Quantum_BookStore_Fawry_Challenge2
{
   public  abstract class Book
    {
        public string ISBN { get; }
        public string Title { get; }
        public int Year { get; }
        public decimal Price { get; }
     

        protected Book(string isbn, string title, int year, decimal price)
        {
            ISBN = isbn;
            Title = title;
            Year = year;
            Price = price;
        }

        public abstract void Buy(int OrderedQuantity, string Email, string Address);
    
    }
    public class PaperBook : Book , IshipService
    {
      public int Quantity { get; set; }
   
        public PaperBook(string isbn, string title, int year, decimal price,int quantity) 
            :base(isbn,title,year,price)
        {
            Quantity = quantity;
       
        }

        public override void Buy(int OrderedQuantity, string Email, string Address)
        {
            if (!DecreaseQuantity(OrderedQuantity)) throw new Exception("no enought copies in the sotre ");
            ShipService(Address, Price*OrderedQuantity);
            return;
        }



        public int GetQuantity() => Quantity;
        public bool DecreaseQuantity(int copies)
        {
            if(Quantity<copies)return false;
            Quantity-= copies;
            
            return true;
        }
        public bool ShipService(string Address, decimal payAmound)
        {
            Console.WriteLine($"Send the paper book to address : {Address} ,Pay amount {payAmound} $");
           
            return true;
        }
    }

    public class EBook : Book, IMailService
    {
      public  string FileType { get; set; }
        public EBook(string isbn, string title, int year, decimal price, string fileType)
            : base(isbn, title, year, price)
        {
            FileType = fileType;
        }

        public override void Buy(int OrderedQuantity, string Email, string Address)
        {
            SendEmail(Email,Price);
        }
        public bool SendEmail(string Email, decimal pay)
        {
            Console.WriteLine($"Send the Ebook to email {Email} ,you have Paid {pay} $, file type : {FileType} ");
            return true;
        }
    }
    public class Demo:Book,IDemo
    {
        public Demo(string isbn, string title, int year, decimal price)
        : base(isbn, title, year, price)
        {
           
        }
        public override void Buy(int OrderedQuantity, string Email, string Address)
        {
            throw new Exception("Classes that implements IDmo is not for sale");
        }
    }
}
