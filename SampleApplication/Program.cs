using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. odd or even series
            //Console.WriteLine("enter the numebr");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("even:");
            //for(int i=0;i<=n;i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("odd:");
            //for(int i=1;i<=n;i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //2.strong number
            //Console.WriteLine("enter the numebr");
            //int n = int.Parse(Console.ReadLine());
            //int temp = n;
            //int res = 0;
            //while(temp>0)
            //{
            //    int t = temp % 10;
            //    res += fact(t);
            //    temp /= 10;
            //}
            //if (res == n)
            //    Console.WriteLine("strong number");
            //else
            //    Console.WriteLine("Not Strong number");


            //3.check the digit in number
            //Console.WriteLine("enter the numebr");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("enter the digit");
            //int d = int.Parse(Console.ReadLine());
            //bool flag = false;
            //while(n>0)
            //{
            //    int digit = n % 10;
            //    if(digit==d)
            //    {
            //        flag = true;
            //        break;
            //    }
            //    n /= 10;
            //}
            //if (flag)
            //    Console.WriteLine("found");
            //else
            //    Console.WriteLine("Not found");

            //4.pattern printing
            //Console.WriteLine("enter the numebr");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the type \n 1.star  \n 2.Number  \n 3.Alphabet \n 4.Symbol");
            //int type = int.Parse(Console.ReadLine());
            //char special='$';
            //if (type == 4)
            //{
            //    Console.WriteLine("Enter special charater");
            //    special = Convert.ToChar(Console.ReadLine());
            //}
            //patternPrint(n, type, special);

            //5.StringEncryption
            //int num = 1, ch = 97, count = 0;
            //String str1 = "";
            //while(true)
            //{
            //    Console.WriteLine("Enter the string");
            //    String str = Console.ReadLine();
            //    while(count<str.Length)
            //    {
            //        str1 += str[count];
            //        if(count%2==0)
            //        {
            //            str1 += (char)ch;
            //            ch++;
            //        }
            //        else
            //        {
            //            str1 += num;
            //            num++;
            //        }
            //        count++;
            //    }
            //    Console.Write(str1);
            //    break;
            //}

            //6.count char frequency
            //Console.WriteLine("enter the string");
            //String str = Console.ReadLine();
            //for(int i=0;i<128;i++)
            //{
            //    int count = 0;
            //    foreach(char c in str)
            //    {
            //        if(c==(char)i)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine("char{0},freq{1}",(char)i,count);
            //}

            //7.min max
            //Console.WriteLine("Enter the size of array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //Console.WriteLine("Enter the element one by one");
            //for(int i=0;i<n;i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max = arr[0], min = arr[0];
            //for(int i=0;i<n;i++)
            //{
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //    if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine("min:" + min + "max:" + max);


            //8.additional diagonal value
            //Console.WriteLine("Enter the size of array");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n,n];
            //Console.WriteLine("Enter the element one by one");
            //for (int i = 0; i < n; i++)
            //{
            //    for(int j=0;j<n;j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int sum = 0, sum1 = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if(i==j ||(i+j)==n-1)
            //        {
            //            sum += arr[i, j];
            //        }
            //        else
            //        {
            //            sum1 += arr[i, j];
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Diagoanl sum1:" + sum);
            //Console.WriteLine("Diagoanl sum2:" + sum1 +"\nTotal:"+(sum+sum1));


            //9.row and column sum
            //Console.WriteLine("Enter the size of array");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, n];
            //Console.WriteLine("Enter the element one by one");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //int r_sum = 0, c_sum = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    r_sum = c_sum = 0;
            //    for (int j = 0; j < n; j++)
            //    {
            //        r_sum += arr[i, j];
            //        c_sum += arr[j, i];
            //    }
            //    Console.WriteLine("row:"+(i+1)+""+r_sum+"col:"+(i+1)+""+c_sum);
            //}

            //10.generic
            //Console.WriteLine("Generic Swap");
            //Console.WriteLine("Enter the first value:");
            //String first = Console.ReadLine();

            //Console.WriteLine("Enter the second value:");
            //String second = Console.ReadLine();
            //Console.WriteLine("Before values:" + first + second);

            //swap(ref first,ref second);
            //Console.WriteLine("After values:"+first + second);
            //Console.ReadLine();


            //11.Sort Names
            //List<String> list = new List<String>();
            //list.Add("hello");
            //list.Add("java");
            //list.Add("c");
            //list.Add("c++");
            //list.Add("c#");
            //list.Add("zoho");
            //list.Add("tcs");
            //Console.WriteLine("Enter the number to sort the list \n1.asc \n2.desc");
            //int order = int.Parse(Console.ReadLine());
            //if(order==1)
            //{
            //    var sort = list.OrderBy(x => x);
            //    foreach(String s in sort)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //else
            //{
            //    var sort = list.OrderByDescending(x => x);
            //    foreach(String s in sort)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //11.duplicate elements
            //Console.WriteLine("Enter the size of array");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr = new int[n, n];
            //Console.WriteLine("Enter the element one by one");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            ////convert two-dimension to one-dimension
            //int[] one_arr = new int[n * n];
            //int count = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        one_arr[count++] = arr[i, j];   
            //    }
            //}

            //Console.WriteLine("Find Duplicate elements");
            //for(int i=0;i<one_arr.Length;i++)
            //{
            //    int countval = 0;
            //    for(int j=0;j<one_arr.Length;j++)
            //    {
            //        if (one_arr[i] == one_arr[j])
            //        {
            //            countval++;
            //        }
            //    }
            //    if(countval>1)
            //    {
            //        bool duplicate = false;
            //        for(int k=0;k<i;k++)
            //        {
            //            if (one_arr[i] == one_arr[k])
            //            {
            //                duplicate = true;
            //                break;
            //            }
            //        }
            //        if(!duplicate)
            //        {
            //            Console.WriteLine(one_arr[i] +" "+countval);
            //        }
            //    }

            //}

            //12.EMI calculator
            //Console.WriteLine("Enter the principle amount");
            //double principle = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the rate amount");
            //double rate = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the no of months");
            //int month = int.Parse(Console.ReadLine());
            //EMI emi = new EMI();
            //Console.WriteLine(emi.cal_emi(rate,principle,month));


            



        }
        //public static void swap<T>(ref T  a,ref T b)
        //{
        //    Console.Write("working");
        //    T temp;
        //    temp = a;
        //    a = b;
        //    b = temp;
        //}

        //public static void patternPrint(int n,int type,char special)
        //{
        //    for(int i=1;i<=n;i++)
        //    {
        //        for(int j=i;j<=n;j++)
        //        {
        //            Console.Write(" ");
        //        }
        //        for(int k=1;k<=i;k++)
        //        {
        //            if(type==1)
        //            {
        //                Console.Write(" * ");
        //            }
        //            else if(type==2)
        //            {
        //                Console.Write(" "+k);
        //            }
        //            else if(type==3)
        //            {
        //                Console.Write(" "+(char)(64+k));
        //            }
        //            else if(type==4)
        //            {
        //                Console.Write(" "+special);
        //            }
        //        }
        //        Console.WriteLine();
        //    }
        //}
        //public static int fact(int t)
        //{
        //    if(t==0 ||t==1)
        //    {
        //        return 1;
        //    }
        //    return t * fact(t - 1);
        //}
    }
    public class Loan
    {
        public double principle;
    }
    public class Interest:Loan
    {
        public double rate;
    }
    public class EMI:Interest
    {
        public int time;
        public double cal_emi(double r,double p,int t)
        {

            rate = r / (12 * 100);
            double emi = (p * rate * Math.Pow(1 + rate, t)) / (Math.Pow(1 + rate, t) - 1);
            return emi;
           
        }
    }
}
