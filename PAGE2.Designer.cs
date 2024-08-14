using Guna.UI2.WinForms;
using System.Drawing;

namespace baitaplon
{
    partial class PAGE2
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_sp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_detailProduce = new System.Windows.Forms.Panel();
            this.btn_refresh = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_idSuppiler = new System.Windows.Forms.TextBox();
            this.label_idSupplier = new System.Windows.Forms.Label();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.label_price = new System.Windows.Forms.Label();
            this.label_nameProduce = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_nameProduce = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_detailProduce.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_sp
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_sp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_sp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sp.ColumnHeadersHeight = 4;
            this.dgv_sp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_sp.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sp.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sp.Location = new System.Drawing.Point(403, 3);
            this.dgv_sp.Name = "dgv_sp";
            this.dgv_sp.RowHeadersVisible = false;
            this.dgv_sp.RowHeadersWidth = 51;
            this.dgv_sp.RowTemplate.Height = 24;
            this.dgv_sp.Size = new System.Drawing.Size(394, 444);
            this.dgv_sp.TabIndex = 17;
            this.dgv_sp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_sp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_sp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_sp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_sp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_sp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_sp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_sp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_sp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_sp.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_sp.ThemeStyle.ReadOnly = false;
            this.dgv_sp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_sp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_sp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_sp.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_sp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel_detailProduce, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_sp, 1, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // panel_detailProduce
            // 
            this.panel_detailProduce.Controls.Add(this.btn_refresh);
            this.panel_detailProduce.Controls.Add(this.btn_search);
            this.panel_detailProduce.Controls.Add(this.txt_idSuppiler);
            this.panel_detailProduce.Controls.Add(this.label_idSupplier);
            this.panel_detailProduce.Controls.Add(this.btn_clear);
            this.panel_detailProduce.Controls.Add(this.btn_delete);
            this.panel_detailProduce.Controls.Add(this.btn_edit);
            this.panel_detailProduce.Controls.Add(this.btn_add);
            this.panel_detailProduce.Controls.Add(this.txt_Note);
            this.panel_detailProduce.Controls.Add(this.label_note);
            this.panel_detailProduce.Controls.Add(this.label_price);
            this.panel_detailProduce.Controls.Add(this.label_nameProduce);
            this.panel_detailProduce.Controls.Add(this.txt_Price);
            this.panel_detailProduce.Controls.Add(this.txt_nameProduce);
            this.panel_detailProduce.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_detailProduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_detailProduce.Location = new System.Drawing.Point(3, 3);
            this.panel_detailProduce.Name = "panel_detailProduce";
            this.panel_detailProduce.Size = new System.Drawing.Size(394, 444);
            this.panel_detailProduce.TabIndex = 0;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_refresh.ForeColor = System.Drawing.Color.White;
            this.btn_refresh.Location = new System.Drawing.Point(268, 375);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(101, 30);
            this.btn_refresh.TabIndex = 47;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_search
            // 
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_search.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(158, 375);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(101, 30);
            this.btn_search.TabIndex = 46;
            this.btn_search.Text = "TÌM KIẾM";
            this.btn_search.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_idSuppiler
            // 
            this.txt_idSuppiler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_idSuppiler.Location = new System.Drawing.Point(51, 204);
            this.txt_idSuppiler.Name = "txt_idSuppiler";
            this.txt_idSuppiler.Size = new System.Drawing.Size(318, 22);
            this.txt_idSuppiler.TabIndex = 45;
            // 
            // label_idSupplier
            // 
            this.label_idSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_idSupplier.AutoSize = true;
            this.label_idSupplier.Location = new System.Drawing.Point(48, 176);
            this.label_idSupplier.Name = "label_idSupplier";
            this.label_idSupplier.Size = new System.Drawing.Size(108, 16);
            this.label_idSupplier.TabIndex = 44;
            this.label_idSupplier.Text = "NHÀ CUNG CẤP";
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(51, 375);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 30);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(51, 329);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 28);
            this.btn_delete.TabIndex = 42;
            this.btn_delete.Text = "XÓA";
            this.btn_delete.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(158, 329);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 28);
            this.btn_edit.TabIndex = 41;
            this.btn_edit.Text = "SỬA";
            this.btn_edit.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(268, 329);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 28);
            this.btn_add.TabIndex = 40;
            this.btn_add.Text = "THÊM";
            this.btn_add.Click += new System.EventHandler(this.button8_Click);
            // 
            // txt_Note
            // 
            this.txt_Note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Note.Location = new System.Drawing.Point(51, 270);
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(318, 22);
            this.txt_Note.TabIndex = 39;
            // 
            // label_note
            // 
            this.label_note.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_note.AutoSize = true;
            this.label_note.Location = new System.Drawing.Point(48, 242);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(62, 16);
            this.label_note.TabIndex = 38;
            this.label_note.Text = "GHI CHÚ";
            // 
            // label_price
            // 
            this.label_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(48, 112);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(29, 16);
            this.label_price.TabIndex = 37;
            this.label_price.Text = "GIÁ";
            // 
            // label_nameProduce
            // 
            this.label_nameProduce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nameProduce.AutoSize = true;
            this.label_nameProduce.Location = new System.Drawing.Point(48, 51);
            this.label_nameProduce.Name = "label_nameProduce";
            this.label_nameProduce.Size = new System.Drawing.Size(108, 16);
            this.label_nameProduce.TabIndex = 36;
            this.label_nameProduce.Text = "TÊN SẢN PHẨM";
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Price.Location = new System.Drawing.Point(51, 141);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(318, 22);
            this.txt_Price.TabIndex = 35;
            // 
            // txt_nameProduce
            // 
            this.txt_nameProduce.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nameProduce.Location = new System.Drawing.Point(51, 74);
            this.txt_nameProduce.Name = "txt_nameProduce";
            this.txt_nameProduce.Size = new System.Drawing.Size(318, 22);
            this.txt_nameProduce.TabIndex = 34;
            // 
            // PAGE2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PAGE2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sp)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_detailProduce.ResumeLayout(false);
            this.panel_detailProduce.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna2DataGridView dgv_sp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_detailProduce;
        private Guna2Button btn_clear;
        private Guna2Button btn_delete;
        private Guna2Button btn_edit;
        private Guna2Button btn_add;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.Label label_nameProduce;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_nameProduce;
        private System.Windows.Forms.TextBox txt_idSuppiler;
        private System.Windows.Forms.Label label_idSupplier;
        private Guna2Button btn_search;
        private Guna2Button btn_refresh;
    }
}