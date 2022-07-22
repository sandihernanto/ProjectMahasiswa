using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi ");
            Console.WriteLine("1.Tambah Mahasiswa");
            Console.WriteLine("2.Tampilkan Mahasiswa");
            Console.WriteLine("3.Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Mahasiswa mhs = new Mahasiswa();

            Console.Write("Nim                : ");
            mhs.Nim = Console.ReadLine();
            Console.Write("Nama               : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin(L/P) : ");
            mhs.JenisKelamin= Console.ReadLine();
            if (mhs.JenisKelamin == "L")
            {
                mhs.JenisKelamin = "Laki-Laki";
            }
            else if (mhs.JenisKelamin == "P")
            {
                mhs.JenisKelamin = "Perempuan";
            }
            
            Console.Write("IPK                : ");
            mhs.IPK = Console.ReadLine();
            Console.WriteLine();

            daftarMahasiswa.Add(mhs);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();
            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;
            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no,mhs.Nim,mhs.Nama,mhs.JenisKelamin,mhs.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
