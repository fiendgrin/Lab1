using System;

namespace LabTask1
{
    public class Program
    {
        static int subtr(int[] array)
        {
            int ThreeDigitSum = 0;
            int TwoDigitUnEvenSum = 0;
            int ResultOf;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 99 && array[i] < 1000)
                {
                    ThreeDigitSum += array[i];
                }
                else if (array[i] % 2 != 0 && array[i] > 9 && array[i] < 100)
                {
                    TwoDigitUnEvenSum += array[i];
                }
            }
            ResultOf = ThreeDigitSum - TwoDigitUnEvenSum;
            return ResultOf;
        }
        public static void Main(string[] args)
        {
            //int[] array = { 32, 87, 34, 655, 321, 22, 12, 1, 866, 731, 31, 11, 10, 6, 544, 81 };

            //Console.WriteLine(subtr(array));

            //int[] array = { 3, 74, 85, 6, 21, 3, 66, 65, 66, 71, 33, 32, 999, 1, 10, 21,15 };

            //DupFind(array);

            //int[] array = { 18, 15, 1987, 549, 112 };
            //evenFind(array);
            string strArray = "farid yunis tahir hamid";
            nameFinder(strArray);
        }
        static void nameFinder(string str)
        {
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                str1 += str[i];
                if (str[i] == ' ')
                {
                    
                    for (int j = 0; j < str1.Length; j++)
                    {
                        if (str1[j] == 's')
                        {
                            Console.WriteLine(str1);
                        }
                    }
                    str1 = "";
                }
            }

            //static void evenFind(int[] array) 
            //{

            //    int save;
            //    int modul;
            //    for (int i = 0; i < array.Length; i++)
            //    {

            //        int evenCheck = 0;
            //        save = array[i];
            //        while (array[i] != 0)
            //        {
            //            modul = array[i] % 10;
            //            array[i] = array[i] - modul;
            //            array[i] /= 10;
            //            evenCheck += modul;
            //        }
            //        if (evenCheck%2==0 ) 
            //        {
            //            Console.WriteLine(save);
            //        }
            //    }
            //}
            //static void DupFind(int[] array) 
            //{
            //    int j=0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        for ( j = 0; j < array.Length - 1; j++)
            //        {
            //            if (array[i] == array[j] && i!=j) 
            //            {
            //                Console.WriteLine("Duplicate Value" + array[i]);
            //            }
            //        }
            //    }
            //}
        }
    }
}