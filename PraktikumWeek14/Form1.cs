using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReverse_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                labelOutput.Text = "";
                string NAMA = textBoxNama.Text;
                char[] URUTAN = NAMA.ToCharArray();
                for (int i = URUTAN.Length - 1; i > -1; i--)
                {
                    labelOutput.Text += URUTAN[i].ToString();
                }
            }
        }

        private void buttonUrutkan_Click(object sender, EventArgs e)
        {
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Tolong isi textbox terlebih dahulu!");
            }
            else
            {
                labelOutput.Text = "";
                string A = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+";
                string NAMA = textBoxNama.Text;
                char[] B = A.ToCharArray();
                char[] URUTAN = NAMA.ToCharArray();
                for (int j = 0; j < B.Length; j++)
                {
                    for (int i = 0; i < URUTAN.Length; i++)
                    {
                        if (URUTAN[i] == B[j])
                        {
                            labelOutput.Text += URUTAN[i].ToString();
                        }
                    }
                }
            }
        }
    }
}
