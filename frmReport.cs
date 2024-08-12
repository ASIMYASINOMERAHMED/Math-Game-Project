using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Game_Project
{
    public partial class frmReport : Form
    {
        private short NumberOfQuestions = 0;
        private List<string> QuestionList;
        private int NumberOfWrongAnswer;
        private Random rnd = new Random();
        public frmReport(short NumberOfQuestions,short NumberOfrightAnswer,short NumberOfWrongAnswer,string GameLevel, string OpType,string PersantageResult, string FinalResultText, List<string> QuestionList)
        {
            InitializeComponent();
            this.NumberOfQuestions = NumberOfQuestions;
            lblNumOfright.Text = NumberOfrightAnswer.ToString();
            lblNumOfWrong.Text = NumberOfWrongAnswer.ToString();
            lblQuizzLevel.Text = GameLevel;
            lblOpType.Text = OpType.ToString();
            lblPercentage.Text = PersantageResult.ToString();
            lblFinalResult.Text = FinalResultText;
            this.QuestionList = QuestionList;
            this.NumberOfWrongAnswer = NumberOfWrongAnswer;
       
            if (FinalResultText == "Pass")
            {
                lblFinalResult.BackColor = Color.Green;
            }
            else
            {
                lblFinalResult.BackColor = Color.Red;
                pictureBox2.Image = Resources.Resources.boy_x_removebg_preview__1___1_;
            }
   
        }

      
        private int RandomNum(int From, int To)
        {
            return rnd.Next(From, To);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

            int StartPosition = 13;
            int EndPosition = 14;
            int FixGape = 150;
    
            for (int i = 0;i < NumberOfQuestions;i++) 
            {

                Label label = AddLabel(i, StartPosition, EndPosition);
                label.Text = QuestionList[i] + "\n";
                panel1.Controls.Add(label);
                EndPosition += FixGape;
              
       
            }  

        }

        Label AddLabel(int i,int start,int end)
        {


            Label label = new Label();
           


            label.AutoSize = true;
            label.Name = "lbQuestion" + i.ToString();
            label.Text = Text;
            label.BackColor = Color.Transparent;
            label.ForeColor = lbFinalResults.ForeColor;
            label.Location = new Point(start, end);
            label.Font = new Font("Impact",16,FontStyle.Regular);
            label.Width = 422;
            label.Height = 53;
            label.TextAlign = ContentAlignment.TopLeft;
            label.Margin = new Padding(2);
            label.Visible = true;

            return label;
        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


















