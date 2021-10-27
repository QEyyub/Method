using System;

namespace Metods
{
    class Program
    {
        static void Main(string[] args)
        {


            int result = digitSum(5256);
            Console.WriteLine(result);

            //int[] digits = { 12, 45, 78, 20, 63, 98, 52 };

            //int num = 78;
            //int cvb = kokalti(num);

            //Console.WriteLine(cvb);


            ////4. Verilmis integer arrayinin icindeki en boyuk deyeri tapan metodu
            //int[] reqemler = { 12, 45, 23, 78, 96, 63, 85 };
            //int num1 = bigDigit(reqemler);
            //Console.WriteLine(num1);







        }

        static int digitSum(int N) //3. Verilmis ededin reqemleri cemini tapib qaytaran metod
        {
            var sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N = (N - N % 10) / 10;

            }
            return sum;


            static int kokalti(int reqem)         //KOKALTI
            {
                int i = 1;

                while (i * i <= reqem)
                {
                    i++;
                }
                i--;
                return i;
            }



            static int bigDigit(int[] bigArr) //4. Verilmis integer arrayinin icindeki en boyuk deyeri tapan metodu
            {
                var max = bigArr[0];
                for (int i = 0; i < bigArr.Length; i++)
                {
                    if (bigArr[i] > max)
                    {
                        max = bigArr[i];
                    }
                    else
                    {
                        i++;
                    }
                }
                return max;



            }



            static int Pstv(int[] digit1)
            {

                int num = -1;
                int result = 0;

                for (int i = 0; i < digit1.Length; i++)
                {
                    if (digit1[i] < 0)
                    {
                        result = digit1[i];

                        result = digit1[i] * num;
                    }
                    else
                    {
                        i++;
                    }



                }
                return result;

            }






        }
    }
}
