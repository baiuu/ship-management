using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marina.GUI
{
    public partial class AddSlipway : Form
    {
        public AddSlipway()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c = textBox1.Text;
            BLL.BLL As=new BLL.BLL();
            int count = Convert.ToInt32(As.AddSlipWay_SS(c));
            if (count == 0)
            {
                Entity.Slipway es = new Entity.Slipway();
                string a = textBox2.Text;
                int result;
                if (int.TryParse(a, out result))
                {
                    try
                    {
                        es.Name = textBox1.Text;
                        es.Volume = Convert.ToInt32(textBox2.Text);
                        BLL.BLL bb = new BLL.BLL();
                        bb.AddSlipway(es);
                        MessageBox.Show("添加船台成功");
                    }

                    catch (FormatException)
                    {
                        MessageBox.Show("容纳船数必须为数字");
                    }
                    catch
                    {
                        MessageBox.Show("添加船台失败");
                    }
                }
                else MessageBox.Show("请检查容纳船数是否为数字", "提醒");
            }
            else MessageBox.Show("船台名已存在");
        }

        private void AddSlipway_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
