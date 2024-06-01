using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Quiz
{
    public partial class Form2 : Form
    {
        int seconds = 0;
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form2()
        {
            InitializeComponent();
            askQuestion(1);

            totalQuestions = 10;
        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void clickAnswerEvent(object sender, EventArgs e)
        {

            //timer
           

            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                DialogResult playAgain = MessageBox.Show("You Have Answered " + score + " Questions correctly. " + Environment.NewLine +
                      "Your total percentage is " + percentage + "%" + Environment.NewLine +
                      "Click Retry to play again and Click Cancel to Back to Menu ", "QUIZ ENDED", MessageBoxButtons.RetryCancel);
                {
                    if (playAgain == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.Close();
                        Form1 back = new Form1();
                        back.Show();
                    }
                }
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

                if (questionNumber == totalQuestions)
                {

                   
                    
                    this.Hide();
                }
            }


            questionNumber++;
            askQuestion(questionNumber);

        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.cod;
                    qlabel1.Text = "What online game is in the picture above? ";

                    button1.Text = "Mobile Legends";
                    button2.Text = "Roblox";
                    button3.Text = "Genshin Impact";
                    button4.Text = "Call of Duty";

                    correctAnswer = 4;


                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.twins;
                    qlabel1.Text = "What is the name of the twin MC in Genshin Impact? ";

                    button1.Text = "Ayato and Ayaka";
                    button2.Text = "Lyney and Lynette";
                    button3.Text = "Aether and Lumine";
                    button4.Text = " Barbara and Jean";

                    correctAnswer = 3;


                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.poseidon;
                    qlabel1.Text = "In Greek Mythology , Who is in the Picture Above? ";

                    button1.Text = "Hades";
                    button2.Text = "Zeus";
                    button3.Text = "Poseidon";
                    button4.Text = "Hermes";

                    correctAnswer = 3;


                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.body;
                    qlabel1.Text = "What part of the body helps you move? ";

                    button1.Text = "Muscles";
                    button2.Text = "Lungs";
                    button3.Text = "Pancreas";
                    button4.Text = "Eyes";

                    correctAnswer = 1;


                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.bones;
                    qlabel1.Text = "How many bones do humans have in their body? ";

                    button1.Text = "216";
                    button2.Text = "206";
                    button3.Text = "201";
                    button4.Text = "210";

                    correctAnswer = 2;


                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.yuumi;
                    qlabel1.Text = "In League of Legends, who is the champion in the picture above? ";

                    button1.Text = "Xayah";
                    button2.Text = "Vex";
                    button3.Text = "Sona";
                    button4.Text = "Yuumi";

                    correctAnswer = 4;


                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.tangerine;
                    qlabel1.Text = "What is the name of this fruit? ";

                    button1.Text = "Apple";
                    button2.Text = "Orange";
                    button3.Text = "Tangerine";
                    button4.Text = "Mango";

                    correctAnswer = 3;


                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.henry;
                    qlabel1.Text = "Who is the 2nd wife of Henry VIII of England? ";

                    button1.Text = "Anne Boleyn";
                    button2.Text = "Jane Seymour";
                    button3.Text = "Catherine Howard";
                    button4.Text = "Catherine of Aragon";

                    correctAnswer = 1;


                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.ph;
                    qlabel1.Text = "What is the capital of Philippines? ";

                    button1.Text = "Laguna";
                    button2.Text = "Cebu";
                    button3.Text = "Manila";
                    button4.Text = "Pampangga";

                    correctAnswer = 3;


                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.period;
                    qlabel1.Text = "In periodic table, K stands for__??? ";

                    button1.Text = "Krypton";
                    button2.Text = "Sulfur";
                    button3.Text = "Argon";
                    button4.Text = "Potassium";

                    correctAnswer = 4;


                    break;





            }





        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 back = new Form3();
            back.Show();
        }

        private void qlabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
