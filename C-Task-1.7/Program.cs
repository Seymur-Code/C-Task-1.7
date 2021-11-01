using System;

namespace C_Task_1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task-1 
            /*int[] Arry = new int[5] { 5, 7, 3, 4, 6 };

            int arrycem = arry(Arry);
            Console.WriteLine(arrycem);*/
            #endregion

            #region Task-2
            /* int[] Arry = new int[5] { 5, 7, 3, 4, 6 };

             Console.WriteLine("ededi girin:");
             int a = Convert.ToInt32(Console.ReadLine());

             arry(Arry, a);
             Console.WriteLine(arry(Arry, a));*/

            #endregion

            #region Task-3

            /*string str = "Salam Aleykum necesen ay insan!";
            sozlerincemi(str);*/

            #endregion
        }





        #region Task-1(metod)

        /*static int arry(int [] Arry)
        {
            int arrycem = 0;

            for (int i = 0; i < Arry.Length; i++)
            {
                arrycem = arrycem + Arry[i];
            }
            return arrycem;*/
        #endregion

        #region Task-2(method)
        /* static bool arry(int[] Arry, int a)
         {


             for (int i = 0; i < Arry.Length; i++)
             {
                 if (a == Arry[i])
                 {
                     return true;

                 }

             }
             return false;
         }*/
        #endregion

        #region Task-3(method)
        /*static int sozlerincemi(string str)
        {
            int a = 0, count = 1;

            while (a <= str.Length - 1)
            {
                if (str[a] == ' ' && str[a+1] != ' ' && str[a - 1] != ' ')
                {
                    count++;
                }
                a++;
            }
            Console.Write("Number of words in the string = {0}\n", count);
            return count;*/
        }


        #endregion




    }
}
