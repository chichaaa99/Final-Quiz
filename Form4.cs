using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Quiz
{
    public partial class Form4 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form4()
        {
            InitializeComponent();
            askQuestion(1);

            totalQuestions = 10;

           


        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void clickAnswerEvent(object sender, EventArgs e)
        {
            
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            
            if (buttonTag == correctAnswer)
            {
                score++;
            }
            if (questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                DialogResult playAgain = MessageBox.Show( "You Have Answered " + score + " Questions correctly. " + Environment.NewLine +
                     "Your total percentage is " + percentage + "%" + Environment.NewLine +
                     "Click Retry to play again and Click Cancel to Back to Menu ", "QUIZ ENDED", MessageBoxButtons.RetryCancel);
                {
                    if (playAgain == System.Windows.Forms.DialogResult.Cancel)
                    {
                        this.Hide();
                        Form1 back = new Form1();
                        back.Show();
                    }
                }
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

       

        private void askQuestion(int qnum) 
        {
            switch (qnum) 
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.solid;
                    easylabel1.Text = "It is anything that has mass and occupies space. ";

                    button1.Text = "Matter";
                    button2.Text = "Solid";
                    button3.Text = "Liquid";
                    button4.Text = "Gas";

                    correctAnswer = 1;


                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.elas;
                    easylabel1.Text = "It refers to the property of a material to return to its original shape and size after being stretch, compressed, or deformed. ";

                    button1.Text = "Flexibility";
                    button2.Text = "Elasticity";
                    button3.Text = "Luster";
                    button4.Text = "Streching";

                    correctAnswer = 2;


                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.atom;
                    easylabel1.Text = "It is subatomic particle that is found in the nucleus of an atom. ";

                    button1.Text = "Atom";
                    button2.Text = "Ultron";
                    button3.Text = "Electron";
                    button4.Text = "Neutron";

                    correctAnswer = 4;


                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.hy;
                    easylabel1.Text = "It is the lightest and most abundant chemical element in the universe. ";

                    button1.Text = "Carbon Dioxide";
                    button2.Text = "Hydrogen";
                    button3.Text = "Nitrogen";
                    button4.Text = "Sulfur";

                    correctAnswer = 2;


                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.small;
                    easylabel1.Text = "Which is the Smallest Ocean in the World? ";

                    button1.Text = "Artic Ocean";
                    button2.Text = "Pacific Ocean";
                    button3.Text = "Indian Ocean";
                    button4.Text = "West Philippine Sea";

                    correctAnswer = 1;


                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.statue;
                    easylabel1.Text = "Which country gifted the Statue of Liberty to USA in 1886? ";

                    button1.Text = "Philippines";
                    button2.Text = "Canada";
                    button3.Text = "England";
                    button4.Text = "France";

                    correctAnswer = 4;


                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.dead;
                    easylabel1.Text = "Dead Sea is located betweek which two countries? ";

                    button1.Text = "Turkey and UAE";
                    button2.Text = "Jordan and Israel";
                    button3.Text = "Jordan and Sudan";
                    button4.Text = "Taiwan and Philippines";

                    correctAnswer = 2;


                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.play;
                    easylabel1.Text = "Which country is known as Playground or Europe? ";

                    button1.Text = "Holland";
                    button2.Text = "Israel";
                    button3.Text = "Autria";
                    button4.Text = "Switzerland";

                    correctAnswer = 4;


                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.humna;
                    easylabel1.Text = "What is the only part of the human body that has no blood supply? ";

                    button1.Text = "Cornea";
                    button2.Text = "Fingers";
                    button3.Text = "Brain";
                    button4.Text = "Skin";

                    correctAnswer = 1;


                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.gall;
                    easylabel1.Text = "Where exactly in the human body is bile stored? ";

                    button1.Text = "Pancreas";
                    button2.Text = "Liver";
                    button3.Text = "Gallbladder";
                    button4.Text = "Kidney";

                    correctAnswer = 3;


                    break;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 back = new Form3();
            back.Show();
        }

        private void easylabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
