using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_C
{
    class Program
    {
        // deklarasi array int dengan ukuran 1155
        private int[] reza = new int[1155]; 

        // deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        // fungsi/method untuk menerima masukan
        public void read()
        {
            //menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while(true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 1155)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 1155 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------");
            Console.WriteLine(" Masukkan Elemen Array ");
            Console.WriteLine("-----------------------");

            // pengguna memasukkan elemen pada Array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                reza[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // menampilkan array yang telah tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(" Elemen Pada Array Yang Telah Tersusun ");
            Console.WriteLine("---------------------------------------");
            for (int RR = 0; RR < n; RR++)
            {
                Console.WriteLine(reza[RR]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 0; i < n; i++) // For n - 1 passes
            {
                // Pada pass i, bandingan n - i elemen pertama dengan elemen selanjutnya
                for (int RR = 0; RR < n - i; RR++)
                {
                    if (reza[RR] > reza[RR + 1]) // jika elemenn tidak dalam urutan yang benar
                    {
                        // tukar elemen
                        int temp;
                        temp = reza[RR];
                        reza[RR] = reza[RR + 1];
                        reza[RR + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // creating the object of the Bubblesort class
            Program myList = new Program();

            // pemanggilan fungsi untuk menerima elemen pada array
            myList.read();
            // pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortArray();
            // pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar. ");
            Console.Read();
        }
    }
}
