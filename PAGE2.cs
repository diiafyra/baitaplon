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
            dataGridView1.CellClick += DataGridView1_CellClick;
            dataGridView1.CellClick += DataGridView1_CellClick1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Hàm load dữ liệu từ SQL cho vào datagridview 
        static string myLap3 = "Data Source=localhost;Initial Catalog=QLNCC;Persist Security Info=True;User ID=he;Password = 1234";
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
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                // Lấy thông tin về các cột
                var columnNames = new List<string>();
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    columnNames.Add(sdr.GetName(i));
                    dataGridView1.Columns.Add(sdr.GetName(i), sdr.GetName(i)); // Thêm cột vào DataGridView
                }

                // Đọc và thêm từng dòng dữ liệu vào DataGridView
                while (sdr.Read())
                {
                    var rowValues = new List<object>();
                    foreach (var columnName in columnNames)
                    {
                        rowValues.Add(sdr[columnName]);
                    }
                    dataGridView1.Rows.Add(rowValues.ToArray()); // Thêm hàng vào DataGridView
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
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Lấy giá trị của cột trong hàng được nhấn
                var row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị giá trị của từng cột trong các TextBox
                if (row.Cells.Count >= 1) textBox4.Text = row.Cells[1].Value != null ? row.Cells[1].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 2) textBox2.Text = row.Cells[2].Value != null ? row.Cells[2].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 3) textBox3.Text = row.Cells[3].Value != null ? row.Cells[3].Value.ToString() : string.Empty;
                if (row.Cells.Count >= 4) textBox1.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
                //if (row.Cells.Count >= 5) textBox5.Text = row.Cells[4].Value != null ? row.Cells[4].Value.ToString() : string.Empty;
            }
            else
            {
                // Xóa giá trị trong TextBox nếu không phải là một ô hợp lệ
                textBox1.Text = string.Empty;
                Console.WriteLine(" o khong hop le");
            }
        }
        // Hàm xử lý sự kiện khi nhấn chuột vào ô sẽ hiện lên 4 textbox 
        private int ID_Pro(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Lấy giá trị của cột trong hàng được nhấn
                var row = dataGridView1.Rows[e.RowIndex];

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
            button5.PerformClick();
            textBox2.Text = id;
            search();
        }
        // Tìm kiếm
        public void search()
        {
            // Lấy giá trị từ các TextBox
            string txttextbox4 = textBox4.Text.Trim();
            string txttextbox3 = textBox3.Text.Trim();
            string txttextbox2 = textBox2.Text.Trim();
            string txttextbox1 = textBox1.Text.Trim();

            int hangDataGridView = dataGridView1.Rows.Count; // Lấy số lượng hàng trong DataGridView (bao gồm cả hàng tiêu đề)
            bool found = false; // Biến cờ để xác nhận nếu tìm thấy hàng hợp lệ

            // Ẩn tất cả các hàng trong DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Chỉ ẩn các hàng đã cam kết
                {
                    row.Visible = false;
                }
            }

            // Lặp qua tất cả các hàng để tìm hàng có giá trị tương ứng
            foreach (DataGridViewRow row in dataGridView1.Rows)
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
            string ten = textBox4.Text;
            int IDnhacungcap = -1;
            try
            {
                IDnhacungcap = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NHÀ CUNG CẤP LỖI LÒI.");
            }
            float gia = -1;
            try
            {
                gia = float.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TIỀN BẠC QUAN TRỌNG ĐẾN VẬY SAO.");
                // MessageBox.Show("Ừ.");
            }
            string ghichu = textBox1.Text;
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
            string ten = textBox4.Text;
            int IDnhacungcap = -1;
            try
            {
                IDnhacungcap = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("NHÀ CUNG CẤP LỖI LÒI.");
            }
            float gia = -1;
            try
            {
                gia = float.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("TIỀN BẠC QUAN TRỌNG ĐẾN VẬY SAO.");
                MessageBox.Show("Ừ.");
            }
            string ghichu = textBox1.Text;
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
            textBox1.Text = string.Empty; // Ghi chú
            textBox2.Text = string.Empty; // Nhà cung cấp
            textBox3.Text = string.Empty; // Giá
            textBox4.Text = string.Empty; // Tên sản phẩm
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
