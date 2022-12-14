using System;
using System.Reflection;

namespace HW9_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

            //Console.WriteLine("Nece eded olacaq:");
            //string countStr = Console.ReadLine();
            //var count = Convert.ToInt32(countStr);

            //int[] numbers = new int[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{i}-ci ededi daxil edin:");
            //    var numStr = Console.ReadLine();
            //    var num = Convert.ToInt32(numStr);
            //    numbers[i] = num;
            //}

            //var result = Bigger(numbers);
            //int index = Array.IndexOf(numbers, result);

            //Console.WriteLine("Result" + " " + result);
            //Console.WriteLine("Indeks" + " " + index);

            // task 2 Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi
            // indexi qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın


            //string [] text =  {"name", "surname", "age", "color" };


            //var checkStr = HasString(text);
            //int index = Array.IndexOf(text, checkStr);

            //Console.WriteLine("Indeks" + " " + index);

            // task 3 Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni bir array
            // qaytaran metod.Yəni metodu işə salın {4,-5,3,-2,6} ədədlərindən ibarət array göndərsəm
            // metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır



            //int[] arr = new int[5];

            //Console.WriteLine("Ededleri daxil edin : ");

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"{i}-ci ededi daxil edin:");
            //    var numStr = Console.ReadLine();
            //    var num = Convert.ToInt32(numStr);
            //    arr[i] = num;
            //}

            //var result = Positiv(arr);


            // task 4 Verilmiş yazıda rəqəm olub olmadığını qaytaran metod

            //var result = hasDigit();
            //Console.WriteLine(result);

            // task 5 Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

           

            var result = hasDigit();
            Console.WriteLine(result);





        }



        // task 1 method
        //static int Bigger(int[] numbers)
        //{
        //    int max = 0;
        //    int index;

        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        if (numbers[i] > max)
        //        {
        //            max = numbers[i];
        //            index = i;

        //        }
        //    }
        //    return max;
        //    return index;
        //}

        // task 2 method


        //static string HasString(string[] text)
        //{
        //    Console.WriteLine("Yazin:");

        //    var word = Console.ReadLine();

        //    var index = 0;

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == word )
        //        {
        //            Console.WriteLine("Bu soz var:"+ " " + word);

        //        }
        //    }
        //    Console.WriteLine("Bu soz yoxdur");
        //    return word; 
        //}


        // task 3 method

        //static int Positiv (int[] arr)
        //{

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        if (arr[i] >= 0)
        //        {
        //            Console.Write(arr[i] + " ");
        //            Console.WriteLine("New array : " + arr[i]);

        //        }
        //    }
        //    return arr.Length;
        //}

        // task 4 method

        //static bool hasDigit()

        //{
        //    char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        //    bool dig = false;

        //        Console.WriteLine("Yazini daxil et:");
        //        string text = Console.ReadLine();

        //        dig = false;


        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
        //        {
        //            dig = true;
        //            break;
        //        }
        //    }
        //    return dig;

        // task 5 method

        static bool hasDigit()

        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            bool dig = false;

            int count = 0;

            string[] text = new string[6];
            Console.WriteLine("Sozleri daxil edin : ");

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{i}-ci sozu daxil edin:");
                var word = Console.ReadLine();
                text[i] = word; 
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' || text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
                {
                    dig = true;
                    count++;
                    break;
                }

                return dig;
            


        }
}
}
    

