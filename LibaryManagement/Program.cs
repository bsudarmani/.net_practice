using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibaryManagement
{
    interface LLibary
    {
        void addbook(int id,String name,String author,int qty);
        void showbook();
        void takebook(int id,String u_name,String address,String contact);
        void returnbook(int id);

    }
    class Libary: LLibary
    {
        int[] bookid = new int[10];
        String[] bookname = new string[10];
        String[] authorname = new string[10];
        int[] stock = new int[10];
        int count = 0;
        public void addbook(int id, string name, string author, int qty)
        {
            bookid[count] = id;
            bookname[count] = name;
            authorname[count] = author;
            stock[count] = qty;
            count++;
        }

        public void showbook()
        {
            Console.WriteLine("\n id \t Name \t AuthorName \t Stock_qty");
            for(int i=0;i<count;i++)
            {
                Console.WriteLine("\n" + bookid[i] + "\t" + bookname[i] + "\t" + authorname[i] + "\t" + stock[i]);
            }
        }

        public void takebook(int id, string u_name, string address, string contact)
        {
            for(int i=0;i<count;i++)
            {
                if (bookid[i]==id)
                {
                    if (stock[i]>0)
                    {
                        stock[i]--;
                        Console.WriteLine("book issued to:" + u_name);
                        Console.WriteLine("user_address:"+address);
                        Console.WriteLine("user_contact:"+contact);
                    }
                    else
                    {
                        Console.WriteLine("Out of Stock");
                    }
                    return;
                }
            }
            Console.WriteLine("Book is not avilable");
           
        }

        public void returnbook(int id)
        {
            for(int i=0;i<count;i++)
            {
                if (bookid[i]==id)
                {

                    stock[i]++;
                    Console.WriteLine("Book retuned");
                    return;
                }
            }
            Console.WriteLine("Book is Not found");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Libary lib = new Libary();
            while(true)
            {
                Console.WriteLine("Enter the number to perform operation \n 1.Add book \n 2.Show Book \n 3.Take Book \n 4.Return Book");
                int ch = int.Parse(Console.ReadLine());
                if(ch==1)
                {
                    Console.WriteLine("Enter book id:");
                    int bookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter book name");
                    String bookname = Console.ReadLine();
                    Console.WriteLine("Enter author");
                    String author = Console.ReadLine();
                    Console.WriteLine("enter quality");
                    int quality = int.Parse(Console.ReadLine());
                    lib.addbook(bookid, bookname, author, quality);
                }
                else if(ch==2)
                {
                    lib.showbook();
                }
                else if(ch==3)
                {
                    Console.WriteLine("Enter book id:");
                    int bookid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter user name");
                    String u_name= Console.ReadLine();
                    Console.WriteLine("Enter address");
                    String address = Console.ReadLine();
                    Console.WriteLine("enter contact");
                    String contact = Console.ReadLine();
                    lib.takebook(bookid, u_name, address, contact);
                }
                else
                {
                    Console.WriteLine("Enter book id:");
                    int bookid = int.Parse(Console.ReadLine());
                    lib.returnbook(bookid);
                }
            }
        }
    }
}
