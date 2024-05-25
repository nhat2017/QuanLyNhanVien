using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNV
{
    public partial class Form1 : Form
    {
        string ConString = @"Data Source=LAPTOP-L9GD540B\MSSQLSERVER01;Initial Catalog=Quan_li_hoc_sinh;Integrated Security=True;";
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int id = 0;

        public Form1()
        {
            InitializeComponent();

            pictureBox.Dock = DockStyle.Fill; // Stretch to fill the form
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            //this.BackgroundImageLayout = ImageLayout.Zoom;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet5.Phong_Ban);

            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.nhanVienTableAdapter.Fill(this.quan_li_hoc_sinhDataSet.NhanVien);
            this.groupBox2.Visible = false;


        }



        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConString);

            try
            {
                conn.Open();


                string sql = "INSERT INTO NhanVien (MaNV, TenNV, DiaChi, GT, Luong, QueQuan, MaPhongBan) VALUES (@MaNV, @TenNV, @DiaChi, @GT, @Luong, @QueQuan, @MaPhongBan)";
                SqlCommand sqlcmd = new SqlCommand(sql, conn);

                if (txtManv.Text == "")
                {
                    MessageBox.Show(" hãy điền Mã Nhân viên ");
                }
                else
                {
                    sqlcmd.Parameters.AddWithValue("@MaNV", txtManv.Text);
                    if (txtTennv.Text == "")
                    {
                        MessageBox.Show(" hãy điền Tên Nhân viên ");
                    }
                    else
                    {

                        sqlcmd.Parameters.AddWithValue("@TenNV", txtTennv.Text);
                        if (txtDc.Text == "")
                        {
                            MessageBox.Show(" hãy điền địa chỉ  ");
                        }
                        else
                        {

                            sqlcmd.Parameters.AddWithValue("@DiaChi", txtDc.Text);
                            if (cbogt.Text == "")
                            {
                                MessageBox.Show(" chọn giới tính  ");
                            }
                            else
                            {

                                sqlcmd.Parameters.AddWithValue("@GT", cbogt.Text);
                                if (decimal.TryParse(txtluong.Text, out decimal luong))
                                {
                                    sqlcmd.Parameters.AddWithValue("@Luong", luong);
                                    if (txtque.Text == "")
                                    {
                                        MessageBox.Show(" chọn giới tính  ");
                                    }
                                    else
                                    {

                                        sqlcmd.Parameters.AddWithValue("@QueQuan", txtque.Text);
                                        if (cboMa.Text == "")
                                        {
                                            MessageBox.Show(" chọn  quên quán  ");
                                        }
                                        else
                                        {

                                            sqlcmd.Parameters.AddWithValue("@MaPhongBan", cboMa.Text);
                                        }
                                    }
                                }
                            }
                        }
                    }


                }
                int rowsAffected = sqlcmd.ExecuteNonQuery();
                this.nhanVienTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);

            }
            catch (SqlException ex)
            {
                MessageBox.Show(" có sự cố xảy ra  " + ex.Message);

            }
            catch (Exception ex)
            {
                MessageBox.Show(" sự cố xảy ra  " + ex.Message);
            }
            finally
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quan_li_hoc_sinhDataSet5.Phong_Ban' table. You can move, or remove it, as needed.
            this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet5.Phong_Ban);
            // TODO: This line of code loads data into the 'quan_li_hoc_sinhDataSet2.Phong_Ban' table. You can move, or remove it, as needed.
            // this.phong_BanTableAdapter.Fill(this.quan_li_hoc_sinhDataSet2.Phong_Ban);
            // TODO: This line of code loads data into the 'quan_li_hoc_sinhDataSet1.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }




        private void DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("vui lòng chọn dòng để xóa ");
                return;
            }

            int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

            try
            {
                using (SqlConnection conn = new SqlConnection(ConString))
                {
                    conn.Open();

                    string manvToDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    Console.WriteLine(manvToDelete);
                    Debug.WriteLine(manvToDelete);
                    if (manvToDelete == null)
                    {
                        MessageBox.Show("không thể lấy được MaNV");
                        return;
                    }


                    string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                    SqlCommand sqlcmd = new SqlCommand(sql, conn);
                    sqlcmd.Parameters.AddWithValue("@MaNV", manvToDelete);


                    int rowsAffected = sqlcmd.ExecuteNonQuery();


                    if (rowsAffected > 0)
                    {
                        MessageBox.Show(" Nhân Viên đã bị xóa thành công ");


                        this.nhanVienTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);

                    }
                    else
                    {
                        MessageBox.Show("Không có cột nào bị xóa.Kiểm tra  (MaNV).");
                    }
                }


            }
            catch (Exception ex)
            { MessageBox.Show("Có sự cố xảy ra " + ex.Message); }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                txtManv.Text = row.Cells[0].Value.ToString();
                txtTennv.Text = row.Cells[1].Value.ToString();
                txtDc.Text = row.Cells[2].Value.ToString();
                cbogt.Text = row.Cells[3].Value.ToString();
                txtluong.Text = row.Cells[4].Value.ToString();
                txtque.Text = row.Cells[5].Value.ToString();
                cboMa.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(ConString))
            {

                //            If( txt_Name.Text<> "" AndAlso txt_State.Text<> "" Then
                //cmd = New SqlCommand("update tbl_Record set Name=@name,State=@state where ID=@id", con);
                //con.Open();
                //cmd.Parameters.AddWithValue("@id", ID);
                //cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                //cmd.Parameters.AddWithValue("@state", txt_State.Text)
                //cmd.ExecuteNonQuery();
                //            MessageBox.Show("Record Updated Successfully");
                //con.Close();
                //DisplayData();
                //ClearData();


                string idToUpdate = txtManv.Text;
                SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET TenNv =@TenNV ,Diachi = @Dc ,gt= @gt,Luong = @luong,QueQuan =@Que,MaPhongBan=@MaPhong where MaNV=@Manv ", conn);
                int i = this.dataGridView1.CurrentRow.Index;
                string idtoupdate;
                idtoupdate = this.dataGridView1.Rows[i].Cells[0].Value.ToString();

                conn.Open();
                if (txtManv.Text == "")
                {
                    MessageBox.Show(" hãy điền Mã Nhân viên ");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Manv", idtoupdate);
                    if (txtTennv.Text == "")
                    {
                        MessageBox.Show(" hãy điền Tên Nhân viên ");
                    }
                    else
                    {

                        cmd.Parameters.AddWithValue("@TenNV", txtTennv.Text);
                        if (txtDc.Text == "")
                        {
                            MessageBox.Show(" hãy điền địa chỉ  ");
                        }
                        else
                        {

                            cmd.Parameters.AddWithValue("@Dc", txtDc.Text);
                            if (cbogt.Text == "")
                            {
                                MessageBox.Show(" chọn giới tính  ");
                            }
                            else
                            {

                                cmd.Parameters.AddWithValue("@gt", cbogt.Text);
                                if (decimal.TryParse(txtluong.Text, out decimal luong))
                                {
                                    cmd.Parameters.AddWithValue("@luong", luong);
                                    if (txtque.Text == "")
                                    {
                                        MessageBox.Show(" Điền mức lương của ! ");
                                    }
                                    else
                                    {

                                        cmd.Parameters.AddWithValue("@Que", txtque.Text);
                                        if (cboMa.Text == "")
                                        {
                                            MessageBox.Show(" Chọn mã Phòng ban!  ");
                                        }
                                        else
                                        {

                                            cmd.Parameters.AddWithValue("@MaPhong", cboMa.Text);
                                            MessageBox.Show("Sữa dữ liệu Thành công");
                                        }
                                    }
                                }
                            }
                        }
                    }
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    this.nhanVienTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);


                }

            }
        }

        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox_Click(object sender, EventArgs e)
        {

        }



        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                txtmpb.Text = row.Cells[0].Value.ToString();
                txttpb.Text = row.Cells[1].Value.ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            int i = this.dataGridView2.CurrentRow.Index;
            string mapbToDelete = this.dataGridView2.Rows[i].Cells[0].Value.ToString();

            string sqlpb = "DELETE FROM Phong_Ban WHERE MaPhongBan = @Mapb";
            string sqlnv = "delete from NhanVien where MaPhongBan = @Mapb";

            SqlCommand sqlcmd = new SqlCommand(sqlpb, con);
            SqlCommand sql = new SqlCommand(sqlnv, con);
            if (mapbToDelete == null)
            { MessageBox.Show("ĐIỀN Mã Phòng Ban "); }

            else
            {
                sqlcmd.Parameters.AddWithValue("@Mapb", mapbToDelete);

                sql.Parameters.AddWithValue("@Mapb", mapbToDelete);
                sqlcmd.ExecuteNonQuery();
                sql.ExecuteNonQuery();
                this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet5.Phong_Ban);
                this.nhanVienTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet1.NhanVien);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            string sql = "Insert into Phong_Ban(MaPhongBan,TenPhongBan) values(@mapb ,@tenpb)";
            SqlCommand sqlcmd = new SqlCommand(sql, con);
            sqlcmd.Parameters.AddWithValue("@mapb", txtmpb.Text);
            sqlcmd.Parameters.AddWithValue("@tenpb", txttpb.Text);
            sqlcmd.ExecuteNonQuery();
            this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet5.Phong_Ban);
        }
        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0) {
                this.groupBox2.Visible = true;
            }
            else
            {
                { this.groupBox2.Visible = false; }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            string idToUpdate = txtmpb.Text;
            int i = this.dataGridView2.CurrentRow.Index;
            SqlCommand cmd = new SqlCommand("UPDATE Phong_Ban SET  TenPhongBan= @tpb  where MaPhongBAN = @mpb", con);
            string idtoupdate = this.dataGridView1.Rows[i].Cells[0].Value.ToString();

            cmd.Parameters.AddWithValue("@mpb", idToUpdate);
            cmd.Parameters.AddWithValue("@tpb", txttpb.Text);

            cmd.ExecuteNonQuery();
            this.phong_BanTableAdapter1.Fill(this.quan_li_hoc_sinhDataSet5.Phong_Ban);
            con.Close();
        }
    
        
    }
}