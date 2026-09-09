using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Session03_AssignmentC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine($"title: {title}");
            //Console.WriteLine($"upperTitle: {upperTitle}");
            #endregion

            #region Q2
            //string string1 = "Clean Code";
            //string string2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(string1, string2));
            #endregion

            #region Q3
            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.Append("Book List");
            //stringBuilder.Append(" - Updated");
            //Console.WriteLine(stringBuilder);
            #endregion

            #region Q4
            //stringBuilder.Replace("Book List", "Library");
            //Console.WriteLine(stringBuilder);
            #endregion

            #region Q5
            //string title = "Clean Code";
            //int pages = 464;
            //String sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            #endregion

            #region Q6
            //string sentence2 = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(sentence2);
            #endregion

            #region Q7
            //string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);
            //Console.WriteLine(sentence3);
            #endregion

            #region Q8
            //int pages = 464;
            //if (pages > 300)
            //    Console.WriteLine("Long Book");
            //else
            //    Console.WriteLine("Short Book");
            #endregion

            #region Q9
            //int pages = 464;
            //bool isAvailable = true;
            //if (pages > 300 && isAvailable)
            //    Console.WriteLine("You can borrow this book");
            #endregion

            #region Q10
            //string title = "Refactoring";
            //switch(title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great Choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("Nice Pick!");
            //        break;
            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Q11
            int pages = 464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);
            #endregion
        }
    }
}