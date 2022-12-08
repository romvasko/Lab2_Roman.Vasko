// See https://aka.ms/new-console-template for more information
using Lab2_Roman.Vasko.Classes;
using System.Text;



namespace Lab2_Roman.Vasko // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            //Console.WriteLine(Lab2String.Task0(args[0]));
            //Console.WriteLine(Lab2String.Task1(args[0]));
            //Console.WriteLine(Lab2String.Task2(args[0]));
            //Console.WriteLine(Lab2String.Task3(args[0]));
            //Console.WriteLine(Lab2String.Task4(args[0]));
            //Console.WriteLine(Lab2String.Task5(args[0]));
            //Console.WriteLine(Lab2String.Task6(args[0]));

            //Lab2Array.First();
            //Lab2Array.Second();
            //Lab2Array.Third();
            //Lab2Array.Fourth();
            //Lab2Array.Fifth();
            //Lab2Array.Sixth();
            //Lab2Array.Seventh();
            //Lab2Array.Eighth();
            //Lab2Array.Nineth();

            string funk = Console.ReadLine().Replace(" ","");
            Console.WriteLine(funk);
            char[] splitChar = {'&','|','^' };
            if(funk.IndexOf("&") != -1) {
            string[] args1 = funk.Split("&");
                string token = "&";
                Lab2Hard.Table(args1, token, funk);
            }
            if (funk.IndexOf("|") != -1) {
                string[] args1 = funk.Split("|");
                string token = "|";
                Lab2Hard.Table(args1, token, funk);
            }
            if (funk.IndexOf("^") != -1) {
                string[] args1 = funk.Split("^");
                string token = "^";
                Lab2Hard.Table(args1, token, funk);
            }
        }

        
    }
}





