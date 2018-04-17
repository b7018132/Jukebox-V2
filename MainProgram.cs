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

        bool JukeBoxOn;
        


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

            Player.URL = "C:/Users/Ed/Downloads/Assignment 2 My Juke Box (1)/Assignment 2 My Juke Box/Tracks/Sleep Away.mp3";
            Player.controls.play();

        }

        private void listBox_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayList1.Items.Add(listBox_Genre_List.SelectedItem);
        }

        private void PlayList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
