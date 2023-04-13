
namespace App.Core.Models
{
   public class Book
    {
        public string name { get; set; }
        public string price { get; set; }

        public void GetFullInfo()
        {
            Console.WriteLine(name+" "+price);
        }
    }
}
