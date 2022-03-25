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

                SqlCommand cmm = new SqlCommand("Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('A001', 'Ana', 'Jl. Rajawali', 088236782910)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('A003','Ardian','Jl. Mawar, Bulukumba',088283928484)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('A002','Anandi','Jl. Sabar',0828383847910)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('A004','Asani','Jl. Melati',089302374848)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('A005','Aina','Jl. Sultan Agung',085256782292)", con);

                cmm.ExecuteNonQuery();

                SqlCommand cm3 = new SqlCommand("Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000011', 'Diana', 'Jl. Baruga', 089728372837)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000012','Ardan','Jl. Anggrek, Bulukumba',082563894102)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000013','Esty','Jl. Kenanga, Makassar',085479210882)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000014','Jihan','Jl. Adiatsa',088990912448)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000015','Asasi','Jl. Sultan Hasanuddin',082930281927)", con);

                cm3.ExecuteNonQuery();



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
