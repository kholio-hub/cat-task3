// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
Console.WriteLine("enter number of subjects");
int sub =Convert.ToInt32(Console.ReadLine());
int[] arr= new int[sub];
Console.WriteLine("enter your grades:");
for(int i=0;i<sub;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}

double avg =calculateavg (arr);
Console.WriteLine("Average = " + avg);
if (avg >= 85)
    
            Console.WriteLine("Grade: Excellent");
        else if (avg >= 75)
            Console.WriteLine("Grade: Very Good");
        else if (avg >= 65)
            Console.WriteLine("Grade: Good");
        else if (avg >= 50)
            Console.WriteLine("Grade: Pass");
        else
            Console.WriteLine("Grade: Fail");
    
    }





 static double calculateavg(int[] arr)
{
    int sum=0;
    foreach(int grade in arr)
    sum+=grade;
    return (double)sum / arr.Length;
}
}
