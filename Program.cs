using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _20200140045_Tugas2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }

        public void InsertData() //method untuk operasi menambhakan data baru ke dalam tabel
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-6IF85PV\\FITRIALFIANA;database=FitriAlfiana;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Tabel_Barang (Kode_Kue, Nama_Kue, Harga_Kue, Tgl_Exp) values (1130, 'Putri Salju', 2000, '2022-04-28')" +
                    "insert into Tabel_Barang (Kode_Kue, Nama_Kue, Harga_Kue, Tgl_Exp) values (1123, 'Lemper', 5000, '2022-03-28')" +
                    "insert into Tabel_Barang (Kode_Kue, Nama_Kue, Harga_Kue, Tgl_Exp) values (1124, 'Donat', 15000, '2022-03-29')" +
                    "insert into Tabel_Barang (Kode_Kue, Nama_Kue, Harga_Kue, Tgl_Exp) values (1126, 'Bolu kukus', 20000, '2022-03-27')" +
                    "insert into Tabel_Barang (Kode_Kue, Nama_Kue, Harga_Kue, Tgl_Exp) values (1127, 'Kue semut', 10000, '2022-03-28')", con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();


            }
        }
    }
}
