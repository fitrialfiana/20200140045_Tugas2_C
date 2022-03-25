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

                SqlCommand cmm = new SqlCommand("Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('0001', 'Ana', 'Jl. Rajawali', 088236782910)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('0002','Ardian','Jl. Mawar Bulukumba',088283928484)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('0003','Anandi','Jl. Sabar',0828383847910)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('0004','Asani','Jl. Melati',089302374848)" +
                    "Insert into Tabel_Customer (Id_Customer, Nama_Customer, Alamat_Customer, No_Tlp) values ('0005','Aina','Jl. Sultan Agung',085256782292)", con);

                cmm.ExecuteNonQuery();

                SqlCommand cm3 = new SqlCommand("Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000011', 'Diana', 'Jl. Baruga', 089728372837)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000012','Ardan','Jl. Anggrek', 082563894102)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000013','Esty','Jl. Kenanga', 085479210882)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000014','Jihan','Jl. Adiatsa',088990912448)" +
                    "Insert into Tabel_Kasir (Kode_Kasir, Nama_Kasir, Alamat_Kasir, No_Tlp) values ('000015','Asasi','Jl. Sultan Hasanuddin',082930281927)", con);

                cm3.ExecuteNonQuery();


                SqlCommand cm4 = new SqlCommand("Insert into Tabel_Transaksi (Kode_Transaksi, Tgl_Transaksi, Qty, Harga_Barang, Total_Harga, Jenis_Pembayaran, Total_Bayar, Kembalian, Kode_Kasir) values ('002909', '2022-02-27', '4', 2000, 8000, 'tunai', 10000, 2000, '000011')" +
                "Insert into Tabel_Transaksi (Kode_Transaksi, Tgl_Transaksi, Qty, Harga_Barang, Total_Harga, Jenis_Pembayaran, Total_Bayar, Kembalian, Kode_Kasir) values ('002910', '2022-02-27', '2', 20000, 40000, 'tunai', 50000, 10000, '000012')" +
                "Insert into Tabel_Transaksi (Kode_Transaksi, Tgl_Transaksi, Qty, Harga_Barang, Total_Harga, Jenis_Pembayaran, Total_Bayar, Kembalian, Kode_Kasir) values ('002911', '2022-02-27', '8', 20000, 16000, 'tunai', 20000, 4000, '000013')" +
                "Insert into Tabel_Transaksi (Kode_Transaksi, Tgl_Transaksi, Qty, Harga_Barang, Total_Harga, Jenis_Pembayaran, Total_Bayar, Kembalian, Kode_Kasir) values ('002912', '2022-02-28', '6', 20000, 12000, 'tunai', 150000, 30000, '000014')" +
                "Insert into Tabel_Transaksi (Kode_Transaksi, Tgl_Transaksi, Qty, Harga_Barang, Total_Harga, Jenis_Pembayaran, Total_Bayar, Kembalian, Kode_Kasir) values ('002913', '2022-02-28', '15', 10000, 150000, 'tunai', 150000, 0, '000015')", con);

                cm4.ExecuteNonQuery();

                SqlCommand cm5 = new SqlCommand("Insert into Tabel_detailtransaksi (Id_Customer, Kode_Transaksi, Jenis_Transaksi) values ('0001', '002909', 'tunai')" +
                  "Insert into Tabel_detailtransaksi (Id_Customer, Kode_Transaksi, Jenis_Transaksi) values ('0002', '002910', 'tunai')" +
                  "Insert into Tabel_detailtransaksi (Id_Customer, Kode_Transaksi, Jenis_Transaksi) values ('0003', '002911', 'kredit')" +
                  "Insert into Tabel_detailtransaksi (Id_Customer, Kode_Transaksi, Jenis_Transaksi) values ('0004', '002912', 'tunai')" +
                  "Insert into Tabel_detailtransaksi (Id_Customer, Kode_Transaksi, Jenis_Transaksi) values ('0005', '002913', 'kredit')", con);

                cm5.ExecuteNonQuery();


                SqlCommand cm6 = new SqlCommand("Insert into Tabel_Pembelian (Id_Customer, Kode_Kue, Ket_Pembelian) values ('0001', '1123', 'lunas')" +
                  "Insert into Tabel_Pembelian (Id_Customer, Kode_Kue, Ket_Pembelian) values ('0002', '1123', 'COD')" +
                  "Insert into Tabel_Pembelian (Id_Customer, Kode_Kue, Ket_Pembelian) values ('0003', '1124', 'lunas')" +
                  "Insert into Tabel_Pembelian (Id_Customer, Kode_Kue, Ket_Pembelian) values ('0004', '1126', 'lunas')" +
                  "Insert into Tabel_Pembelian (Id_Customer, Kode_Kue, Ket_Pembelian) values ('0005', '1127', 'lunas')", con);

                cm6.ExecuteNonQuery();


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
