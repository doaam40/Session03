using System.Security.Cryptography.X509Certificates;

namespace Session03_AssignmentC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"title: {title}");
            Console.WriteLine($"upperTitle: {upperTitle}");
            #endregion
        }
    }
}