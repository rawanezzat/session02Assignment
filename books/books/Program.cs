
namespace books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q1

            Book book = new Book() { Title = "rawan", Pages = 500 };
            string bookTitle = book.Title;
            int bookPage = book.Pages;

            Console.WriteLine("-----------Q1---------");
            object obj = book;
            Console.WriteLine(obj);

            Console.WriteLine($"the book title is : {bookTitle}");
            Console.WriteLine($"the book pages is:{ bookPage}");
                       //or                                 
            Console.WriteLine($"the book title is:{ book.Title }");
            Console.WriteLine($"the book pages is:{ book.Pages }");


            //Q2
            Console.WriteLine("-----------Q2---------");

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());


            //Q3
            Console.WriteLine("-----------Q3---------");

            int pages = 600;
            Console.WriteLine(pages);
            //Q4
            Console.WriteLine("-----------Q4---------");

            int x = 10;
            int y = 0;
            try
            {
             int result =   x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero. ");
                Console.WriteLine(ex.Message);
            }
            //or
            catch (Exception ex)
            {
                Console.WriteLine("Can't divide by zero. ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Program is finished.");
            }

        }
    }
}
