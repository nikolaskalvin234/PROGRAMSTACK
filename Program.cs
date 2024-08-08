using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Stack<int> stack = new Stack<int>();

            // Menambahkan elemen ke stack
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine("Stack Awal Push: ");
            foreach (int item in stack)
            {
              Console.Write(item + " ");  
            }
            Console.WriteLine(" ");
            // Mengambil elemen teratas tanpa menghapusnya
            Console.WriteLine("Elemen teratas :" + stack.Peek());
            // Menghapus elemen teratas
            Console.WriteLine("Elemen yang dihapus: " + stack.Pop());
            // Mengambil dan hapus elemen teratas
            Console.WriteLine("Elemen teratas yang dihapus: " + stack.Pop());
            //Menghitung jumlah elemen dalam stack
            Console.WriteLine("Jumlah elemen dalam stack: " + stack.Count);
            //Memeriksa apakah stack kosong
            bool isEmpty = stack.Count == 0;
            Console.WriteLine("Apakah stack kosong?" + isEmpty);

            Console.Write("Stack Akhir Pop: ");
            foreach (int item in stack)
            {
                Console.Write(item + " ");
            }


	}
}
