using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Final_Quiz
{
    public partial class Form1 : Form
    {
        public Form1 Instance { get; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           SoundPlayer ss = new SoundPlayer(@"D:\Desktop\Final Quiz\Final Quiz\bin\Debug\final sound.wav");
            ss.Play();
            
        }
        public static void Playmusic (string filepath) 
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            details fOrm = new details(this);
            fOrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult exit = MessageBox.Show("ARE YOU SURE YOU WISH TO QUIT?", "EXIT APPLICATION", MessageBoxButtons.YesNo);
            if (exit == System.Windows.Forms.DialogResult.Yes) 
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 fOrm = new Form3();
            fOrm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
