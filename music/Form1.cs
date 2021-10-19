using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class Form1 : Form
    {
        string[] file, path;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            bunifuImageButton6.Hide();
            bunifuImageButton9.Show();
            listBox1.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Hide();
            bunifuImageButton8.Show();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            bunifuImageButton1.Show();
            bunifuImageButton8.Hide();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                axWindowsMediaPlayer1.URL = path[listBox1.SelectedIndex];

            }
            catch (IndexOutOfRangeException x)
            {

               
            }

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection list = listBox1.Items;
            Random random = new Random();
            int x = list.Count;
            listBox1.BeginUpdate();

            while (x > 1)
            {
                x--;
                int y = random.Next(x * 1);
                object value = list[y];
                list[y] = list[x];
                list[x] = value;
            }
            listBox1.EndUpdate();
            listBox1.Invalidate();

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.previous();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.next();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            bunifuImageButton6.Show();
            bunifuImageButton9.Hide();
            listBox1.Hide();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true;
            open.Filter = "Mp3 Files|*.mp3| Avi Files|*.avi|Wav Files|*.wav ";

            if (open.ShowDialog() == DialogResult.OK)
            {
                file = open.SafeFileNames;
                path = open.FileNames;

                for (int i = 0; i < file.Length; i++)
                {
                    listBox1.Items.Add(file[i]);

                }
            }
        }
    }
}
