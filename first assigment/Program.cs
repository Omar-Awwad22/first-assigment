using first_assigment;
using System;
using System.Reflection;
using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question 1
            // object book = "title";
            //Console.WriteLine(book);
            //book = 10;
            //Console.WriteLine(book);
            #endregion
            #region question 2
            //book b1 = new book() { title = "my_title", pages = 10 };
            //Console.WriteLine(b1);


            //book b2 = new book() { title = "another_title", pages = 20};
            //Console.WriteLine(b2);

            //Console.WriteLine(b1.Equals(b2));
            //Console.WriteLine(b1.GetHashCode());
            //int x = 5;
            //Console.WriteLine(x.GetType());
            #endregion
            #region question 3
            // it is already answered it is a syntax error cause integars have no " " 
            #endregion
            #region question 4
            //int voltage = 10;
            //int current = 0;
            //try
            //{
            //  int resistance = voltage / current;
            //Console.WriteLine(resistance);
            //}
            //catch (Exception ex)
            //{
            //  Console.WriteLine("you can't divide by zero !");
            //}
            //finally {
            //  Console.WriteLine("done !");
            //}
            #endregion
            #region question 5
            //int pages = 300;
            //double slides = pages;
            //Console.WriteLine(slides);
            #endregion
            #region question 6
            //double z = 49.99;
            //int y = (int)z;
            // Console.WriteLine(y);
            #endregion
            #region question 7
            //string pagetext = "464";
            //int page = Convert.ToInt32(pagetext);
            //Console.WriteLine(page);
            //Console.WriteLine(page.GetType());
            #endregion
            #region question 8-1
            //string YEARTEXT = "2023";
            //int year = int.Parse(YEARTEXT);
            //Console.WriteLine(year);
            #endregion
            #region question 8-2
             //string badtext = "abc";
             //int.TryParse(badtext, out int text);
            //if (text == 0) {
              //  Console.WriteLine("Invalid number");
            //}
          
            #endregion
            #region question 9 
            // int pages = 464;
            //string textpages = pages.ToString();
            // Console.WriteLine(textpages);
            #endregion
            #region question10
            //int copies = 100;
            //object p = copies; //boxing
            //int z = (int)p; //unboxing
            //Console.WriteLine(z);
            //Console.WriteLine(p);
            #endregion

        }

    }
}