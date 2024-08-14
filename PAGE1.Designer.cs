using Guna.UI2.WinForms;

namespace baitaplon
{
    partial class PAGE1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        #region Windows Form Design;
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Supplier = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_nameSupplier = new System.Windows.Forms.TextBox();
            this.txt_Score = new System.Windows.Forms.TextBox();
            this.txt_timeDelivery = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label_nameSupplier = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_timeDelivery = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Supplier
            // 
            this.dgv_Supplier.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Supplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Supplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Supplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Supplier.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Supplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier.Location = new System.Drawing.Point(26, 274);
            this.dgv_Supplier.Name = "dgv_Supplier";
            this.dgv_Supplier.RowHeadersVisible = false;
            this.dgv_Supplier.RowHeadersWidth = 51;
            this.dgv_Supplier.RowTemplate.Height = 24;
            this.dgv_Supplier.Size = new System.Drawing.Size(744, 150);
            this.dgv_Supplier.TabIndex = 0;
            this.dgv_Supplier.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Supplier.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Supplier.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Supplier.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Supplier.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_Supplier.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Supplier.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Supplier.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Supplier.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Supplier.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_Supplier.ThemeStyle.ReadOnly = false;
            this.dgv_Supplier.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Supplier.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Supplier.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Supplier.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Supplier.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_Supplier.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Supplier.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Supplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dgv_Supplier.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter_1);
            this.dgv_Supplier.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // txt_phone
            // 
            this.txt_phone.AllowDrop = true;
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_phone.Location = new System.Drawing.Point(185, 73);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(319, 22);
            this.txt_phone.TabIndex = 1;
            // 
            // txt_nameSupplier
            // 
            this.txt_nameSupplier.AllowDrop = true;
            this.txt_nameSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_nameSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nameSupplier.Location = new System.Drawing.Point(185, 31);
            this.txt_nameSupplier.Name = "txt_nameSupplier";
            this.txt_nameSupplier.Size = new System.Drawing.Size(585, 22);
            this.txt_nameSupplier.TabIndex = 2;
            // 
            // txt_Score
            // 
            this.txt_Score.AllowDrop = true;
            this.txt_Score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Score.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Score.Location = new System.Drawing.Point(617, 73);
            this.txt_Score.Name = "txt_Score";
            this.txt_Score.Size = new System.Drawing.Size(153, 22);
            this.txt_Score.TabIndex = 3;
            // 
            // txt_timeDelivery
            // 
            this.txt_timeDelivery.AllowDrop = true;
            this.txt_timeDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timeDelivery.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_timeDelivery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_timeDelivery.Location = new System.Drawing.Point(185, 152);
            this.txt_timeDelivery.Name = "txt_timeDelivery";
            this.txt_timeDelivery.Size = new System.Drawing.Size(585, 22);
            this.txt_timeDelivery.TabIndex = 4;
            // 
            // txt_address
            // 
            this.txt_address.AllowDrop = true;
            this.txt_address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_address.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_address.Location = new System.Drawing.Point(185, 113);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(585, 22);
            this.txt_address.TabIndex = 5;
            // 
            // label_nameSupplier
            // 
            this.label_nameSupplier.AllowDrop = true;
            this.label_nameSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nameSupplier.AutoSize = true;
            this.label_nameSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_nameSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_nameSupplier.Location = new System.Drawing.Point(23, 34);
            this.label_nameSupplier.Name = "label_nameSupplier";
            this.label_nameSupplier.Size = new System.Drawing.Size(139, 16);
            this.label_nameSupplier.TabIndex = 6;
            this.label_nameSupplier.Text = "TÊN NHÀ CUNG CẤP";
            // 
            // label_phone
            // 
            this.label_phone.AllowDrop = true;
            this.label_phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_phone.AutoSize = true;
            this.label_phone.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_phone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_phone.Location = new System.Drawing.Point(23, 76);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(104, 16);
            this.label_phone.TabIndex = 7;
            this.label_phone.Text = "SỐ ĐIỆN THOẠI";
            // 
            // label_address
            // 
            this.label_address.AllowDrop = true;
            this.label_address.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_address.AutoSize = true;
            this.label_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_address.Location = new System.Drawing.Point(23, 113);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(53, 16);
            this.label_address.TabIndex = 8;
            this.label_address.Text = "ĐỊA CHỈ";
            // 
            // label_score
            // 
            this.label_score.AllowDrop = true;
            this.label_score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_score.AutoSize = true;
            this.label_score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_score.Location = new System.Drawing.Point(514, 77);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(86, 16);
            this.label_score.TabIndex = 9;
            this.label_score.Text = "ĐIỂM UY TÍN";
            // 
            // label_timeDelivery
            // 
            this.label_timeDelivery.AllowDrop = true;
            this.label_timeDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_timeDelivery.AutoSize = true;
            this.label_timeDelivery.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_timeDelivery.Location = new System.Drawing.Point(23, 155);
            this.label_timeDelivery.Name = "label_timeDelivery";
            this.label_timeDelivery.Size = new System.Drawing.Size(109, 16);
            this.label_timeDelivery.TabIndex = 10;
            this.label_timeDelivery.Text = "THỜI GIAN GIAO";
            // 
            // label_note
            // 
            this.label_note.AllowDrop = true;
            this.label_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_note.AutoSize = true;
            this.label_note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_note.Location = new System.Drawing.Point(23, 191);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(62, 16);
            this.label_note.TabIndex = 11;
            this.label_note.Text = "GHI CHÚ";
            // 
            // txt_note
            // 
            this.txt_note.AllowDrop = true;
            this.txt_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_note.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_note.Location = new System.Drawing.Point(185, 191);
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(585, 22);
            this.txt_note.TabIndex = 12;
            // 
            // btn_add
            // 
            this.btn_add.AllowDrop = true;
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add.Location = new System.Drawing.Point(689, 231);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(81, 23);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "THÊM";
            this.btn_add.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.AllowDrop = true;
            this.btn_edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_edit.Location = new System.Drawing.Point(608, 231);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "SỬA";
            this.btn_edit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AllowDrop = true;
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_delete.Location = new System.Drawing.Point(527, 231);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "XÓA";
            this.btn_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.AllowDrop = true;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Clear.Location = new System.Drawing.Point(133, 231);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(101, 23);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_search
            // 
            this.btn_search.AllowDrop = true;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_search.Location = new System.Drawing.Point(26, 231);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(101, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "TÌM KIẾM";
            this.btn_search.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.AllowDrop = true;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_refresh.Location = new System.Drawing.Point(240, 231);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 23);
            this.btn_refresh.TabIndex = 18;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.Click += new System.EventHandler(this.button6_Click);
            // 
            // PAGE1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label_timeDelivery);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_nameSupplier);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_timeDelivery);
            this.Controls.Add(this.txt_Score);
            this.Controls.Add(this.txt_nameSupplier);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.dgv_Supplier);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PAGE1";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna2DataGridView dgv_Supplier;
        public System.Windows.Forms.TextBox txt_phone;
        public System.Windows.Forms.TextBox txt_nameSupplier;
        public System.Windows.Forms.TextBox txt_Score;
        public System.Windows.Forms.TextBox txt_timeDelivery;
        public System.Windows.Forms.TextBox txt_address;
        public System.Windows.Forms.Label label_nameSupplier;
        public System.Windows.Forms.Label label_phone;
        public System.Windows.Forms.Label label_address;
        public System.Windows.Forms.Label label_score;
        public System.Windows.Forms.Label label_timeDelivery;
        public System.Windows.Forms.Label label_note;
        public System.Windows.Forms.TextBox txt_note;
        public Guna2Button btn_add;
        public Guna2Button btn_edit;
        public Guna2Button btn_delete;
        public Guna2Button btn_Clear;
        public Guna2Button btn_search;
        public Guna2Button btn_refresh;
    }
}