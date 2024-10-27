using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{

    // classes, interfaces etc.

    public interface IRentable
    {
        void CheckOut();
        void CheckIn();
    }

    public class Book : IRentable
    {
        //define properties of IRentable that can be called through inheritance
       
        public string Title { get; set; }
        public string Author { get; set; }
        private bool isCheckedOut = false;
        public bool IsCheckedOut { get { return isCheckedOut; } }

        
        


        //define all constructor attributes in order to properly structure the program for calling upon each item
        public Book(string Title, string Author)
        {
            this.Title = Title;
            this.Author = Author;
            

        }
        //define the ShowInfo Interface needed to format and display the information stored within the list
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            


        }

        //define the two status options (available or unavailable) that can be altered based upon user interaction with menu
        public virtual void CheckOut()
        {
            isCheckedOut = true;
        }

        public virtual void CheckIn()
        {
            isCheckedOut = false;
        }
    }
   
    
  
}
