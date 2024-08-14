using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class PAGE1 : Form
    {
        public Form1 ParentForm { get; set; }
        private int selectedRowIndex = -1;

        public PAGE1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kết nối tới cơ sở dữ liệu SQL
            string connectionString = "Data Source=localhost;Initial Catalog=QlNCC; trusted_connection = true";
            SqlConnection connection = new SqlConnection(connectionString);

            // Chuẩn bị câu truy vấn SQL
            string query = "INSERT INTO NhaCungCaps VALUES (@value1, @value2, @value3, @value4, @value5, @value6)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", textBox2.Text);
            command.Parameters.AddWithValue("@value2", textBox1.Text);
            command.Parameters.AddWithValue("@value3", textBox5.Text);
            command.Parameters.AddWithValue("@value4", textBox4.Text);
            command.Parameters.AddWithValue("@value5", textBox6.Text);
            command.Parameters.AddWithValue("@value6", textBox3.Text);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Dữ liệu đã được thêm vào cơ sở dữ liệu.");
                string selectQuery = "SELECT * FROM NhaCungCaps";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    DataTable dataTable = new DataTable();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        public void LoadData()
        {
            using (btlcontext btlcontext = new btlcontext())
            {
                var nhaCungCaps = btlcontext.NhaCungCap.ToList();

                dataGridView1.DataSource = nhaCungCaps;

                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
                dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dataGridView1.Columns["ThoiGianGiao"].HeaderText = "Thời Gian Giao";
                dataGridView1.Columns["DiemUyTin"].HeaderText = "Điểm Uy Tín";
                dataGridView1.Columns["GhiChu"].HeaderText = "Ghi Chú";

                // Ẩn cột SanPhams
                if (dataGridView1.Columns["SanPhams"] != null)
                {
                    dataGridView1.Columns["SanPhams"].Visible = false;
                }
            } 

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);

                string name = textBox2.Text;
                string phone = textBox1.Text;
                string address = textBox5.Text;
                string note = textBox6.Text;
                decimal dtime = decimal.Parse(textBox4.Text);
                decimal score = decimal.Parse(textBox3.Text);

                UpdateProduceInfo(id, name, phone, address, dtime, score, note);
                LoadData();
            }
            else MessageBox.Show("Hãy chọn 1 nhà cung cấp để sửa thông tin");
        }

        private void UpdateProduceInfo(int id, string name, string phone, string address, decimal dtime, decimal score, string note)
        {
            try
            {
                using (var context = new btlcontext())
                {
                    var nhaCungCap = context.NhaCungCap.Find(id);
                    if (nhaCungCap != null)
                    {
                        nhaCungCap.TenNhaCungCap = name;
                        nhaCungCap.SoDienThoai = phone;
                        nhaCungCap.DiaChi = address;
                        nhaCungCap.ThoiGianGiao = dtime;
                        nhaCungCap.DiemUyTin = (int)score;
                        nhaCungCap.GhiChu = note;
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp không tìm thấy.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp và các sản phẩm tương ứng không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["Id"].Value);
                    DeleteProduce(id);
                    LoadData();
                }
            }
            else MessageBox.Show("Hãy chọn 1 nhà cung cấp xóa");
        }

        private void DeleteProduce(int id)
        {
            try
            {
                using (var context = new btlcontext())
                {
                    var nhaCungCap = context.NhaCungCap.Find(id);
                    if (nhaCungCap != null)
                    {
                        var sanPhams = context.SanPham.Where(sp => sp.NhaCungCapId == id).ToList();
                        if (sanPhams.Any())
                        {
                            context.SanPham.RemoveRange(sanPhams);
                        }
                        context.NhaCungCap.Remove(nhaCungCap);
                        context.SaveChanges();
                        MessageBox.Show("Đã xóa nhà cung cấp và các sản phẩm tương ứng");
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp không tìm thấy.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}");
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void dataGridView1_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox2.Text = selectedRow.Cells["TenNhaCungCap"].Value?.ToString() ?? string.Empty;
                textBox1.Text = selectedRow.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                textBox5.Text = selectedRow.Cells["DiaChi"].Value?.ToString() ?? string.Empty;
                textBox4.Text = selectedRow.Cells["ThoiGianGiao"].Value?.ToString() ?? string.Empty;
                textBox3.Text = selectedRow.Cells["DiemUyTin"].Value?.ToString() ?? string.Empty;
                textBox6.Text = selectedRow.Cells["GhiChu"].Value?.ToString() ?? string.Empty;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                //MessageBox.Show("baaaaaaaaaa");
                ParentForm.ActivateButtonA(textBox2.Text = selectedRow.Cells["Id"].Value?.ToString() ?? string.Empty);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new btlcontext())
            {

                string tenNhaCungCap = textBox2.Text.Trim();
                string soDienThoai = textBox1.Text.Trim();
                string diaChi = textBox5.Text.Trim();
                decimal? thoiGianGiao = string.IsNullOrWhiteSpace(textBox4.Text) ? (decimal?)null : decimal.Parse(textBox4.Text);
                string ghiChu = textBox6.Text.Trim();
                decimal? diemUyTin = string.IsNullOrWhiteSpace(textBox3.Text) ? (decimal?)null : decimal.Parse(textBox3.Text);


                var query = context.NhaCungCap.AsQueryable();

                if (!string.IsNullOrWhiteSpace(tenNhaCungCap))
                {
                    query = query.Where(ncc => ncc.TenNhaCungCap.Contains(tenNhaCungCap));
                }

                if (!string.IsNullOrWhiteSpace(soDienThoai))
                {
                    query = query.Where(ncc => ncc.SoDienThoai.Contains(soDienThoai));
                }

                if (!string.IsNullOrWhiteSpace(diaChi))
                {
                    query = query.Where(ncc => ncc.DiaChi.Contains(diaChi));
                }

                if (thoiGianGiao.HasValue)
                {
                    query = query.Where(ncc => ncc.ThoiGianGiao == thoiGianGiao.Value);
                }

                if (!string.IsNullOrWhiteSpace(ghiChu))
                {
                    query = query.Where(ncc => ncc.GhiChu.Contains(ghiChu));
                }

                if (diemUyTin.HasValue)
                {
                    query = query.Where(ncc => ncc.DiemUyTin == diemUyTin.Value);
                }

                var resultList = query.ToList();
                dataGridView1.DataSource = resultList;
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}