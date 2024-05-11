using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNV
{
    public partial class Form2 : Form
    {
        string ConString = @"Data Source=LAPTOP-L9GD540B\MSSQLSERVER01;Initial Catalog=Quan_li_hoc_sinh;Integrated Security=True;";
        SqlCommand cmd;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet4.Phong_Ban);
            //// TODO: This line of code loads data into the 'quan_li_hoc_sinhDataSet3.Phong_Ban' table. You can move, or remove it, as needed.
            //this.phong_BanTableAdapter.Fill(this.quan_li_hoc_sinhDataSet3.Phong_Ban);
            //// TODO: This line of code loads data into the 'quan_li_hoc_sinhDataSet1.NhanVien' table. You can move, or remove it, as needed.
            //this.nhanVienTableAdapter.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Phong_Ban (MaPhongBan,TenPhongBan) values (@mpb,tpb) ", conn);
            cmd.Parameters.AddWithValue("@mpb", txtMapb);
            cmd.Parameters.AddWithValue("@tpb", txtTpb);
            cmd.ExecuteNonQuery();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete From  Phong_Ban where MaphongBan =@mpb ", conn);
            int index = this.quan_li_hoc_sinhDataSet3.SelectedRows[0].Index();
            cmd.Parameters.AddWithValue("@mpb", index);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConString);
           
            SqlCommand cmd = new SqlCommand("update  Phong_Ban (MaPhongBan,TenPhongBan) values (@mpb,tpb), conn);
            int i = this.dataGridView10.CurrentRow.Index;
            string idtoupdate;
          
            idtoupdate = this.dataGridView10.Rows[i].Cells[0].Value.ToString();
          
            cmd.Parameters.AddWithValue("@mpb", txtMapb);
            cmd.Parameters.AddWithValue("@tpb", txtTpb);
            cmd.ExecuteNonQuery();
        }
    }
}
