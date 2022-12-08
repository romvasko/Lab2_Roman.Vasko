// See https://aka.ms/new-console-template for more information
using Lab2_Roman.Vasko.Classes;
using System.Text;



namespace Lab2_Roman.Vasko // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine(Lab2.Task0(args[0]));
            Console.WriteLine(Lab2.Task1(args[0]));
            Console.WriteLine(Lab2.Task2(args[0]));
            Console.WriteLine(Lab2.Task3(args[0]));
            Console.WriteLine(Lab2.Task4(args[0]));
            Console.WriteLine(Lab2.Task5(args[0]));
            Console.WriteLine(Lab2.Task6(args[0]));

            //First();
            //Second();
            //Third();
            //Fourth();
            //Fifth();
            //Sixth();
            //Seventh();
            //Eighth();
            //Nineth();
        }

        static void First() {

            Console.WriteLine("При помощи цикла for вывести на экран нечетные числа от  1 до 99:");
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i < 100; i++) {
                if (i % 2 != 0) {
                    stringBuilder.Append(i + " ");
                }
            }
            Console.WriteLine(stringBuilder);

        }

        static void Second() {
            Console.WriteLine("Необходимо вывести на экран числа от 5 до 1.");
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 5; i >= 1; i--) {
                stringBuilder.Append(i + " ");
            }
            Console.WriteLine(stringBuilder.ToString());

        }

        static void Third() {
            Console.WriteLine("Напишите программу, где пользователь вводит любое целое положительное число." +
                " А программа суммирует все числа от 1 до введенного пользователем числа.");
            int a = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for (int i = 1; i < a; i++) {
                temp += i;
            }
            Console.WriteLine(temp);
        }

        static void Fourth() {
            Console.WriteLine("Создайте массив целых чисел. Напишете программу, которая" +
                " выводит сообщение о том, входит ли заданное число в массив или нет." +
                " Пусть число для поиска задается с консоли");
            int[] mass = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            int a = Convert.ToInt32(Console.ReadLine());
            bool temp = false;
            foreach (int i in mass) {
                if (a == i) {
                    Console.WriteLine($"число {a} входит в массив");
                    temp = true;
                    break;
                }
            }
            if (!temp) { Console.WriteLine("не входит"); }
        }

        static void Fifth() {
            Console.WriteLine("Создайте и заполните массив случайным числами и выведете максимальное, минимальное и среднее значение." +
        "Для генерации случайного числа используйте метод Math.random()." +
        "Пусть будет возможность создавать массив произвольного размера.Пусть размер массива вводится с консоли. ");
            try {

                int a = Convert.ToInt32(Console.ReadLine());

                int[] mass = new int[a];

                StringBuilder stringBuilder = new StringBuilder();
                Random random = new Random();
                int min = 0;
                int max = 0;
                double summ = 0;
                for (int i = 0; i < mass.Length; i++) {

                    mass[i] = random.Next(20);

                    if (i == 0) {
                        min = mass[0];
                        max = mass[0];
                    }

                    summ += mass[i];
                    stringBuilder.Append(mass[i] + " ");

                    if (mass[i] > max) {
                        max = mass[i];
                    }

                    if (mass[i] < min) {
                        min = mass[i];
                    }
                }
                Console.WriteLine($"mass: {stringBuilder} max: {max} min: {min} avg: {summ / mass.Length}");
            }
            catch {
                Console.WriteLine("что-то пошло не так");
            }

        }

        static void Sixth() {
            Console.WriteLine("Создайте 2 массива из 5 чисел." +
        "Выведите массивы на консоль в двух отдельных строках. ");
            int[] mass1 = new int[5];
            int[] mass2 = new int[5];
            StringBuilder stringBuilder1 = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < mass1.Length; i++) {

                mass1[i] = random.Next(20);
                mass2[i] = random.Next(40);
                stringBuilder1.Append(mass1[i] + " ");
                stringBuilder2.Append(mass2[i] + " ");
            }
            Console.WriteLine($"mass1: {stringBuilder1}");
            Console.WriteLine($"mass2: {stringBuilder2}");
        }

        static void Seventh() {
            Console.WriteLine("Выведите на экран первые 11 членов последовательности  Фибоначчи. ");
            int[] mass1 = new int[11];
            StringBuilder stringBuilder1 = new StringBuilder();
            mass1[0] = 0;
            mass1[1] = 1;
            stringBuilder1.Append(mass1[0] + " ");
            stringBuilder1.Append(mass1[1] + " ");
            for (int i = 2; i < mass1.Length; i++) {
                mass1[i] = mass1[i - 1] + mass1[i - 2];
                stringBuilder1.Append(mass1[i] + " ");
            }
            Console.WriteLine(stringBuilder1);
        }

        static void Eighth() {
            Console.WriteLine("Создайте массив и заполните массив." +
                "Выведите массив на экран в строку." +
                " Замените каждый элемент с нечётным индексом на ноль. " +
                "Снова выведете массив на экран на отдельной строке. ");
            int[] mass = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            StringBuilder stringBuilder = new StringBuilder();
            foreach (int item in mass) {
                stringBuilder.Append(item + " ");
            }
            Console.WriteLine(stringBuilder);
            stringBuilder.Clear();
            for (int i = 0; i < mass.Length; i++) {
                if (i % 2 == 0) {
                    mass[i] = 0;
                }
                stringBuilder.Append(mass[i] + " ");
            }
            Console.WriteLine(stringBuilder);
        }

        static void Nineth() {
            Console.WriteLine("Создайте массив строк. Заполните его произвольными именами людей." +
                " Отсортируйте массив. " +
                "Результат выведите на консоль.");
            string[] mass = new string[5] {
        "Jonh",
        "Sera",
        "Blyke",
        "Isen",
        "Arlo",
    };
            StringBuilder stringBuilder = new StringBuilder();

            //Array.Sort(mass);
            for (int i = 1; i < mass.Length; i++) {
                for (int j = 0; j < mass.Length - i; j++) {
                    if (String.Compare(mass[j], mass[j + 1]) == 1) {
                        string temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            }

            foreach (string item in mass) {
                stringBuilder.Append(item + " ");
            }
            Console.WriteLine(stringBuilder);
        }
    }
}





