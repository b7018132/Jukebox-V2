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

        



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "") //if the textbox is empty..
            {
                textBox2.Text = PlayList1.Items[0].ToString(); //move it to the first item of the playlist listbox
            }
        }

        

        private void button2_Click_1(object sender, EventArgs e)
        {
            string applicationPath = Directory.GetCurrentDirectory() + "//" + "genreSongs.txt"; //when the button is clicked, it will create the application path to the genre songs file


            listBox_Genre_List.DataSource = File.ReadAllLines(applicationPath); //it will then read all the lines in the file and put it into the listbox


            string applicationPath2 = Directory.GetCurrentDirectory() + "//" + "genreTitles.txt"; //when the button is clicked, it will create the application path to the genre title file


            textBox1.Text = File.ReadAllText(applicationPath2); //what ever is in this file, will be put into the textbox as the genre title

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer(); //enabling the windows media player
            string applicationPathMusic = Directory.GetCurrentDirectory() + "\\"; //the path to the music is here


            Player.URL = (applicationPathMusic + "//Tracks/" + textBox2.Text); //the URL is dependent on what track is currently in the now playing text box


            Player.controls.play();

        }

        private void listBox_Genre_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayList1.Items.Add(listBox_Genre_List.SelectedItem); //what ever is selected in the genre listbox, will be copied to the playlist listbox
        }

        private void PlayList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) //setting up a timer
        {
            
            if (textBox2.Text == "" && PlayList1.Items.Count > 0) //if the textbox is empty and there are more than one items in the playlist listbox..
            {
                timer1.Start(); //starting of the timer
                textBox2.Text = PlayList1.Items[0].ToString(); //the text of the currently playing textbox is the first item of the playlist 
                timer1.Stop();
            }

            WMPLib.WindowsMediaPlayer Player = new WMPLib.WindowsMediaPlayer();
            string applicationPathMusic = Directory.GetCurrentDirectory() + "\\";


            Player.URL = (applicationPathMusic + "//Tracks/" + textBox2.Text); //new pathway to the music is dependent on what is currently playing 


            Player.controls.play();

            
        }
    }
                
}
