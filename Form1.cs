
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
                panel_pageHolder.Controls.Remove(cur);
            }
            cur = form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            if (form is PAGE1 page1)
            {
                page1.ParentForm = this; 
            }

            panel_pageHolder.Controls.Add(form);
            panel_pageHolder.Tag = form;
            //form.BringToFront();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadPage(new PAGE1());
            label_tittlePage.Text = "NHÀ CUNG CẤP";
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
            label_tittlePage.Text = "SẢN PHẨM CUNG CẤP";
        }

        private void spBtn_MouseEnter(object sender, EventArgs e)
        {
            Gpanel_slideBar.Width = 130;
            transition.ShowSync(Gpanel_slideBar);
        }

        private void spBtn_MouseLeave(object sender, EventArgs e)
        {
            Gpanel_slideBar.Width = 20;
            transition.ShowSync(Gpanel_slideBar);
        }

        private void nccBtn_Click(object sender, EventArgs e)
        {
            loadPage(new PAGE1());
            label_tittlePage.Text = "NHÀ CUNG CẤP";
        }
    }
}
