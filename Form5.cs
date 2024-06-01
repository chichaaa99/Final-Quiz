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
    public partial class Form5 : Form
    {

        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;

        public Form5()
        {
            InitializeComponent();
            askQuestion(1);

            totalQuestions = 10;
        }

        private void Form5_Load(object sender, EventArgs e)
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
                        this.Close();
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
                    pictureBox1.Image = Properties.Resources.kazakh;
                    difflabel1.Text = "What ois the capital city of kazakhstan? ";

                    button1.Text = "Helsinki";
                    button2.Text = "Reykjavik";
                    button3.Text = "Astana";
                    button4.Text = "Warsaw";

                    correctAnswer = 3;


                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.tungsten;
                    difflabel1.Text = "Which chemical element has the highest melting point? ";

                    button1.Text = "Tungsten";
                    button2.Text = "Titanium";
                    button3.Text = "Carbon";
                    button4.Text = "Platinum";

                    correctAnswer = 1;


                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Coffee;
                    difflabel1.Text = "What country is the largest producer of coffee in the world? ";

                    button1.Text = "Colombia";
                    button2.Text = "Ethiopia";
                    button3.Text = "Brazil";
                    button4.Text = "Vietnam";

                    correctAnswer = 3;


                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.nobel;
                    difflabel1.Text = "Who was the first woman to win a Nobel Prize? ";

                    button1.Text = "Rosa Parks";
                    button2.Text = "Mother Teresa";
                    button3.Text = "Amelia Earhart";
                    button4.Text = "Marie Curie";

                    correctAnswer = 4;


                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.lang;
                    difflabel1.Text = "Which language has the most native speakers in the world? ";

                    button1.Text = "Hindi";
                    button2.Text = "Mandarin";
                    button3.Text = "English";
                    button4.Text = "Spanish";

                    correctAnswer = 2;


                    break;


                case 6:
                    pictureBox1.Image = Properties.Resources.solar;
                    difflabel1.Text = "Which planet in our solar system has the most moons? ";

                    button1.Text = "Jupiter";
                    button2.Text = "Saturn";
                    button3.Text = "Uranus";
                    button4.Text = "Neptune";

                    correctAnswer = 1;


                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.sistine_chapel;
                    difflabel1.Text = "Who painted the Sistine Chapel Ceiling? ";

                    button1.Text = "VIncent van Gogh";
                    button2.Text = "Leonardo da Vinci";
                    button3.Text = "Pablo Picasso";
                    button4.Text = "Machelangelo";

                    correctAnswer = 4;


                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.persistence;
                    difflabel1.Text = "Who painted the famous artwork 'The Persistence of Memory'? ";

                    button1.Text = "Salvador Dali";
                    button2.Text = "Clause Monet";
                    button3.Text = "Pablo Picasso";
                    button4.Text = "CVincent van Gogh";

                    correctAnswer = 1;


                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.moon;
                    difflabel1.Text = "What is the largest moon in our solar system? ";

                    button1.Text = "Moon(Earth's Moon)";
                    button2.Text = "Titan";
                    button3.Text = "Ganymede";
                    button4.Text = "Europa";

                    correctAnswer = 3;


                    break;


                case 10:
                    pictureBox1.Image = Properties.Resources.relativility;
                    difflabel1.Text = "Which famous scientist developed the theory of general relativity? ";

                    button1.Text = "Galileo Galilei";
                    button2.Text = "Albert Einstein";
                    button3.Text = "Isaac Newton";
                    button4.Text = "Marie Curie";

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
    }
}
