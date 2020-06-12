using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abtraction.abtractionClass;
using Abtraction.Interface;

namespace Abtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Abstract Class. ");
            Console.WriteLine();
            bentuk Bentuk;

            Bentuk = new Kubus();
            Bentuk.bangunruang();

            Bentuk = new Balok();
            Bentuk.bangunruang();

            Bentuk = new Tabung();
            Bentuk.bangunruang();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Konsep Abstraksi Menggunakan Interface. ");
            Console.WriteLine();
            IBangundatar bangundatarBentuk;

            bangundatarBentuk = new Persegi();
            bangundatarBentuk.bangunDatar();

            bangundatarBentuk = new Segitiga();
            bangundatarBentuk.bangunDatar();

            bangundatarBentuk = new Lingkaran();
            bangundatarBentuk.bangunDatar();

            Console.ReadKey();
        }
    }
}