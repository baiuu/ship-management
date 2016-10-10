using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Marina.GUI;

namespace Marina
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI.AddCustomer ac = new AddCustomer();
            this.Hide();
            ac.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI.FindCustomer fc = new FindCustomer();
            this.Hide();
            fc.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GUI.SlipwayManage sm = new SlipwayManage();
            this.Hide();
            sm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(this, "是否确认退出系统", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.Environment.Exit(05);
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
