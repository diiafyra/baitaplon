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
            dgv_Supplier.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kết nối tới cơ sở dữ liệu SQL
            string connectionString = "Data Source=localhost;Initial Catalog=QlNCC; trusted_connection = true";
            SqlConnection connection = new SqlConnection(connectionString);

            // Chuẩn bị câu truy vấn SQL
            string query = "INSERT INTO NhaCungCaps VALUES (@value1, @value2, @value3, @value4, @value5, @value6)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@value1", txt_nameSupplier.Text);
            command.Parameters.AddWithValue("@value2", txt_phone.Text);
            command.Parameters.AddWithValue("@value3", txt_address.Text);
            command.Parameters.AddWithValue("@value4", txt_timeDelivery.Text);
            command.Parameters.AddWithValue("@value5", txt_note.Text);
            command.Parameters.AddWithValue("@value6", txt_Score.Text);
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
                    dgv_Supplier.DataSource = dataTable;
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

                dgv_Supplier.DataSource = nhaCungCaps;

                dgv_Supplier.Columns["Id"].HeaderText = "ID";
                dgv_Supplier.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
                dgv_Supplier.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgv_Supplier.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgv_Supplier.Columns["ThoiGianGiao"].HeaderText = "Thời Gian Giao";
                dgv_Supplier.Columns["DiemUyTin"].HeaderText = "Điểm Uy Tín";
                dgv_Supplier.Columns["GhiChu"].HeaderText = "Ghi Chú";

                // Ẩn cột SanPhams
                if (dgv_Supplier.Columns["SanPhams"] != null)
                {
                    dgv_Supplier.Columns["SanPhams"].Visible = false;
                }
            } 

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                int rowIndex = dgv_Supplier.CurrentCell.RowIndex;
                int id = Convert.ToInt32(dgv_Supplier.Rows[rowIndex].Cells["Id"].Value);

                string name = txt_nameSupplier.Text;
                string phone = txt_phone.Text;
                string address = txt_address.Text;
                string note = txt_note.Text;
                decimal dtime = decimal.Parse(txt_timeDelivery.Text);
                decimal score = decimal.Parse(txt_Score.Text);

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
            txt_phone.Text = string.Empty;
            txt_nameSupplier.Text = string.Empty;
            txt_Score.Text = string.Empty;
            txt_timeDelivery.Text = string.Empty;
            txt_address.Text = string.Empty;
            txt_note.Text = string.Empty;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp và các sản phẩm tương ứng không?",
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    int rowIndex = dgv_Supplier.CurrentCell.RowIndex;
                    int id = Convert.ToInt32(dgv_Supplier.Rows[rowIndex].Cells["Id"].Value);
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
                var selectedRow = dgv_Supplier.Rows[e.RowIndex];

                txt_nameSupplier.Text = selectedRow.Cells["TenNhaCungCap"].Value?.ToString() ?? string.Empty;
                txt_phone.Text = selectedRow.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                txt_address.Text = selectedRow.Cells["DiaChi"].Value?.ToString() ?? string.Empty;
                txt_timeDelivery.Text = selectedRow.Cells["ThoiGianGiao"].Value?.ToString() ?? string.Empty;
                txt_Score.Text = selectedRow.Cells["DiemUyTin"].Value?.ToString() ?? string.Empty;
                txt_note.Text = selectedRow.Cells["GhiChu"].Value?.ToString() ?? string.Empty;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedRow = dgv_Supplier.Rows[e.RowIndex];
                //MessageBox.Show("baaaaaaaaaa");
                ParentForm.ActivateButtonA(txt_nameSupplier.Text = selectedRow.Cells["Id"].Value?.ToString() ?? string.Empty);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var context = new btlcontext())
            {

                string tenNhaCungCap = txt_nameSupplier.Text.Trim();
                string soDienThoai = txt_phone.Text.Trim();
                string diaChi = txt_address.Text.Trim();
                decimal? thoiGianGiao = string.IsNullOrWhiteSpace(txt_timeDelivery.Text) ? (decimal?)null : decimal.Parse(txt_timeDelivery.Text);
                string ghiChu = txt_note.Text.Trim();
                decimal? diemUyTin = string.IsNullOrWhiteSpace(txt_Score.Text) ? (decimal?)null : decimal.Parse(txt_Score.Text);


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
                dgv_Supplier.DataSource = resultList;
            }   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}