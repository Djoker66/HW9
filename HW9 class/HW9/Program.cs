using System;

namespace HW9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // class task 1 Verilmiş ədədin verilmiş qüvvətini tapan metod

            //Console.WriteLine("Ededi daxil edin:");
            //var n1 = Console.ReadLine();
            //Console.WriteLine("Quvettini daxil edin:");
            //var n2 = Console.ReadLine();
            //int num1 = Convert.ToInt32(n1);
            //int num2 = Convert.ToInt32(n2);
            // var result = Degree(num1, num2);
            // Console.WriteLine(result);

            // class task 2 Verilmiş 3 ədəddən ən böyüyünü tapan metod

            //Console.WriteLine("1ci ededi daxil edin:");
            //var n1 = Console.ReadLine();
            //Console.WriteLine("2ci ededi daxil edin:");
            //var n2 = Console.ReadLine();
            //Console.WriteLine("3ci ededi daxil edin:");
            //var n3 = Console.ReadLine();
            //int num1 = Convert.ToInt32(n1);
            //int num2 = Convert.ToInt32(n2);
            //int num3 = Convert.ToInt32(n3);

            //var result = Max(num1, num2, num3);
            //Console.WriteLine(result);


            // class task 3 Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod

            //Console.WriteLine("Nece eded olacaq?");
            //var countStr = Console.ReadLine();
            //var count = Convert.ToInt32(countStr);

            //int[] nums = new int[count];

            //for(int i = 0; i < count; i++)

            //    {
            //        Console.WriteLine($"{i}-ci ededi daxil edin:");
            //        var nStr = Console.ReadLine();
            //        var n = Convert.ToInt32(nStr);
            //        nums[i] = n;
            //    }

            //var result = SumNum(nums);
            //Console.WriteLine("Result" + " " + result);


            // class task 4 Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod

            Console.WriteLine("Nece eded olacaq?");
            var countStr = Console.ReadLine();
            var count = Convert.ToInt32(countStr);

            int[] nums = new int[count];

            for (int i = 0; i < count; i++)

            {
                Console.WriteLine($"{i}-ci ededi daxil edin:");
                var nStr = Console.ReadLine();
                var n = Convert.ToInt32(nStr);
                nums[i] = n;
            }

            var result = BigNum(nums);
            Console.WriteLine("Result" + " " + result);

        }

        // class task 1 method 

        //static int Degree(int num1, int num2)
        //{
        //    int result = 1;
        //    for(int i=0; i<num2; i++) 
        //    {
        //        result *= num1;
        //    }
        //    return result;
        //}

        // class task 2 method 

        //static int Max(int num1, int num2, int num3) 
        //{
        //    if (num1 > num2 && num1>num3)
        //    {
        //        return num1;
        //    }
        //    else if (num2> num3 && num2>num1) 
        //    {
        //        return num2;
        //    }
        //    else
        //    {
        //        return num3;
        //    }
        //}

        // class task 3 method 

        //static int SumNum(int[] nums)
        //{
        //    int sum = 0;

        //  for(int i = 0; i < nums.Length;i++) 
        //    { 
        //      sum+= nums[i];
        //    }

        //  return sum;
        //}

        // class task 4 method 

        static int BigNum(int[] nums)
        {
            int max = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }

            return max;
        }
    }
}
