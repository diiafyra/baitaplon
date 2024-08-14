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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace baitaplon
{
    public partial class PAGE2 : Form
    {
        public PAGE2()
        {
            InitializeComponent();
            LoadData(); // load dữ liệu 
            dgv_sp.CellClick += DataGridView1_CellClick;
            dgv_sp.CellClick += DataGridView1_CellClick1;
            dgv_sp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm load dữ liệu từ SQL cho vào datagridview 
        static string myLap3 = "Data Source=localhost;Initial Catalog=QLNCC;trusted_connection=true";
        private void LoadData()
        {
            string txtSql = "SELECT * FROM SanPhams";
            SqlConnection con = new SqlConnection(myLap3);

            try
            {
                con.Open();
                SqlCommand cm = new SqlCommand(txtSql, con);
                SqlDataReader sdr = cm.ExecuteReader();

                // Xóa tất cả các cột và hàng hiện có (nếu có)
                dgv_sp.Columns.Clear();
                dgv_sp.Rows.Clear();

                // Lấy thông tin về các cột
                var columnNames = new List<string>();
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    columnNames.Add(sdr.GetName(i));
                    dgv_sp.Columns.Add(sdr.GetName(i), sdr.GetName(i)); // Thêm cột vào DataGridView
                }

                // Đọc và thêm từng dòng dữ liệu vào DataGridView
                while (sdr.Read())
                {
                    var rowValues = new List<object>();
                    foreach (var columnName in columnNames)
                    {
                        rowValues.Add(sdr[columnName]);
                    }
                    dgv_sp.Rows.Add(rowValues.ToArray()); // Thêm hàng vào DataGridView
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Ham tao bang, tao ban ghi. Input : Cau lenh SQL 
        static void thaoTac(string txtSQLcreate)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = myLap3;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(txtSQLcreate, con);//lưu trữ câu lệnh SQL cần thực thi cùng với kết nối đến cơ sở dữ liệu.(data + @dich + tim duong)
                cmd.ExecuteNonQuery(); // thực thi các lệnh SQL không trả về dữ liệu
                Console.WriteLine("Thao tac thanh cong!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        // Hàm xử lý sự kiện khi nhấn chuột vào ô sẽ hiện lên 4 textbox 
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_sp.Rows.Count - 1)
            {
                // Lấy giá trị của cột trong hàng được nhấn
                var row = dgv_sp.Rows[e.RowIndex];

                // Hiển thị giá trị của từng cột trong các TextBox
                if (row.Cells.Count >= 1) txt_nameProduce.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 2) txt_idSuppiler.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 3) txt_Price.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 4) txt_Note.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
                //if (row.Cells.Count >= 5) textBox5.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
            }
            else
            {
                // Xóa giá trị trong TextBox nếu không phải là một ô hợp lệ
                txt_Note.Text = string.Empty;
                Console.WriteLine(" o khong hop le");
            }
        }
        // Hàm xử lý sự kiện khi nhấn chuột vào ô sẽ hiện lên 4 textbox 
        private int ID_Pro(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_sp.Rows.Count - 1)
            {
                // Lấy giá trị của cột trong hàng được nhấn
                var row = dgv_sp.Rows[e.RowIndex];

                // Hiển thị giá trị của từng cột trong các TextBox
                if (int.TryParse(row.Cells[0].Value.ToString(), out int id))
                {
                    return id;
                }
            }
            return -1;
        }
        public void select(string id)
        {
            btn_clear.PerformClick();
            txt_idSuppiler.Text = id;
            search();
        }
        // Tìm kiếm
        public void search()
        {
            // Lấy giá trị từ các TextBox
            string txttextbox4 = txt_nameProduce.Text.Trim();
            string txttextbox3 = txt_Price.Text.Trim();
            string txttextbox2 = txt_idSuppiler.Text.Trim();
            string txttextbox1 = txt_Note.Text.Trim();

            int hangDataGridView = dgv_sp.Rows.Count; // Lấy số lượng hàng trong DataGridView (bao gồm cả hàng tiêu đề)
            bool found = false; // Biến cờ để xác nhận nếu tìm thấy hàng hợp lệ

            // Ẩn tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dgv_sp.Rows)
            {
                if (!row.IsNewRow) // Chỉ ẩn các hàng đã cam kết
                {
                    row.Visible = false;
                }
            }

            // Lặp qua tất cả các hàng để tìm hàng có giá trị tương ứng
            foreach (DataGridViewRow row in dgv_sp.Rows)
            {
                if (!row.IsNewRow) // Neu la hang cam ket 
                {
                    //MessageBox.Show("id: " + txttextbox4 +"he: "+ row.Cells[2].Value.ToString());
                    bool match = true;
                    // Kiểm tra từng điều kiện tìm kiếm
                    if (!((txttextbox4 == "" || row.Cells[1].Value.ToString() == txttextbox4)))
                        match = false;
                    if (!((txttextbox2 == "" || row.Cells[2].Value.ToString() == txttextbox2)))
                        match = false;
                    if (!((txttextbox3 == "" || row.Cells[3].Value.ToString() == txttextbox3)))
                        match = false;
                    if (!((txttextbox1 == "" || row.Cells[4].Value.ToString() == txttextbox1)))
                        match = false;
                    // Nếu tất cả các điều kiện đều đúng, hiển thị hàng đó
                    if (match)
                    {
                        row.Visible = true;
                        found = true;
                    }
                }
            }
            // Nếu không tìm thấy hàng, hiển thị thông báo lỗi
            if (!found)
            {
                MessageBox.Show("Không tìm thấy.");
                LoadData(); // Trả lại DataGridView ban đầu
            }
        }

        // Thêm sản phẩm 
        private void button8_Click(object sender, EventArgs e)
        {
            string ten = txt_nameProduce.Text;
            int IDnhacungcap = -1;
            try
            {
                IDnhacungcap = int.Parse(txt_idSuppiler.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NHÀ CUNG CẤP LỖI LÒI.");
            }
            float gia = -1;
            try
            {
                gia = float.Parse(txt_Price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TIỀN BẠC QUAN TRỌNG ĐẾN VẬY SAO.");
                // MessageBox.Show("Ừ.");
            }
            string ghichu = txt_Note.Text;
            string insert = $"INSERT INTO SanPhams (TenSanPham, NhaCungCapId, Gia, GhiChu) VALUES\r\n('{ten}', {IDnhacungcap}, {gia}, '{ghichu}')";
            thaoTac(insert);
            if (gia != -1)
            {
                MessageBox.Show("Insert thanh cong.");
            }
            LoadData();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ID: " + selectedProductId);
            int id = selectedProductId;
            string ten = txt_nameProduce.Text;
            int IDnhacungcap = -1;
            try
            {
                IDnhacungcap = int.Parse(txt_idSuppiler.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NHÀ CUNG CẤP LỖI LÒI.");
            }
            float gia = -1;
            try
            {
                gia = float.Parse(txt_Price.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TIỀN BẠC QUAN TRỌNG ĐẾN VẬY SAO.");
                MessageBox.Show("Ừ.");
            }
            string ghichu = txt_Note.Text;
            string update = $"UPDATE SanPhams\r\nSET TenSanPham = '{ten}', NhaCungCapId = {IDnhacungcap}, Gia = {gia}, GhiChu = '{ghichu}'\r\nWHERE Id = {id};";
            thaoTac(update);
            if (gia != -1)
            {
                MessageBox.Show("Update thanh cong.");
            }
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Note.Text = string.Empty; // Ghi chú
            txt_idSuppiler.Text = string.Empty; // Nhà cung cấp
            txt_Price.Text = string.Empty; // Giá
            txt_nameProduce.Text = string.Empty; // Tên sản phẩm
        }

        private int selectedProductId = -1; // Biến để lưu ID của sản phẩm được chọn
        // Cập nhật thuộc tính khi nhấn chuột vào ô trong DataGridView
        private void DataGridView1_CellClick1(object sender, DataGridViewCellEventArgs e)
        {
            selectedProductId = ID_Pro(sender, e);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ID: " + selectedProductId);
            int id = selectedProductId;
            string delete = $" delete from SanPhams where id = {id}";
            thaoTac(delete);
            LoadData();
            MessageBox.Show("Delete ban thi thanh cong.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
