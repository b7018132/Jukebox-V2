using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool JukeBoxOn = false;



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = PlayList1.Items[0].ToString();
            }
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            new aboutForm().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "//" + "genreSongs.txt";


            listBox_Genre_List.DataSource = File.ReadAllLines(applicationPath);


            string applicationPath2 = Directory.GetCurrentDirectory() + "//" + "genreTitles.txt";


            textBox1.Text = File.ReadAllText(applicationPath2);

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            string applicationPathMusic = Directory.GetCurrentDirectory() + "\\";


            Player.URL = (applicationPathMusic + "//Tracks/" + textBox2.Text);


            Player.controls.play();

        }

        private void listBox_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayList1.Items.Add(listBox_Genre_List.SelectedItem);
        }

        private void PlayList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (textBox2.Text == "" && PlayList1.Items.Count > 0)
            {
                timer1.Start();
                textBox2.Text = PlayList1.Items[0].ToString();
                timer1.Stop();
            }

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            string applicationPathMusic = Directory.GetCurrentDirectory() + "\\";


            Player.URL = (applicationPathMusic + "//Tracks/" + textBox2.Text);


            Player.controls.play();

            
        }
    }
                
}
