
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        Form cur = null;
        public void loadPage(Form form)
        {
            if (cur != null)
            {
                //cur.Dispose();
                cur.Close();
                panel2.Controls.Remove(cur);
            }
            cur = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            if (form is PAGE1 page1)
            {
                page1.ParentForm = this; 
            }

            panel2.Controls.Add(form);
            panel2.Tag = form;
            //form.BringToFront();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPage(new PAGE1());
            label1.Text = "NHÀ CUNG CẤP";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void ActivateButtonA(string id)
        {
            PAGE2 pAGE2 = new PAGE2();
            loadPage(pAGE2);
            pAGE2.select(id);
        }

        private void panel3_MouseEnter_1(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Width = 120;
        }

        private void panel3_MouseLeave_1(object sender, EventArgs e)
        {
            //flowLayoutPanel1.Width = 30;
        }



        private void spBtn_Click_1(object sender, EventArgs e)
        {
            loadPage(new PAGE2());
            label1.Text = "SẢN PHẨM CUNG CẤP";
        }

        private void spBtn_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel1.Width = 130;
            transition.ShowSync(guna2Panel1);
        }

        private void spBtn_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.Width = 20;
            transition.ShowSync(guna2Panel1);
        }

        private void nccBtn_Click(object sender, EventArgs e)
        {
            loadPage(new PAGE1());
            label1.Text = "NHÀ CUNG CẤP";
        }
    }
}
