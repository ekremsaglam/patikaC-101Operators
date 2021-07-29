using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x =3;
            int y= 3;
            Console.WriteLine(y);

            y += 3;
            Console.WriteLine(y);
            
            y /= 3;
            Console.WriteLine(y);

            //Mantıksal operatörler
            // || , && , !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted){
                Console.WriteLine("isSuccess");
            }
            if (isSuccess|| isCompleted){
                Console.WriteLine("Great");

            }
            if(isSuccess && !isCompleted){
                Console.WriteLine("Fine");
            }

            int number1 = 10;
            int number2 = 5;
            int sonuc1 =number1/number2;
            int sonuc2 = number1* number2;
            number1++;
            
        }
    }
}
