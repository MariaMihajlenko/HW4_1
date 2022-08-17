
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
using System;
class Program 
{
public static void Main()
 {   
    
        Console.WriteLine("Введите числo a:  ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите числo b:  ");
        int b = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        int a1=a;

        while (i < (b-1))
        {
           a=a*a1;
            i++;
        }
        
    
        Console.WriteLine(a);
    
    

}
}
