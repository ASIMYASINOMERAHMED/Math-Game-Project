using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Math_Game_Project
{
    public partial class frmClassRoom : Form
    {
   
        private static Random rnd = new Random();
        private stQuestion Question = new stQuestion();
        private static stQuizz Quizz = new stQuizz();
        private decimal Result = 0;
        private int Sec = 1, Min = 0, Hour = 0, QuestionNum = 0;
        private Button ButtonOfCorrectAnswer = new Button();
        private List<string> time = new List<string>();
        private List<string> Answer = new List<string>((int)Quizz.NumberOfQeustions);
        public frmClassRoom(decimal NumberOfQs, int QuizzLevel, int OpType,decimal Mins)
        {
            InitializeComponent();
   
            Min = (int)Mins;
            Quizz.NumberOfQeustions = NumberOfQs;
            Quizz.GameLevel = (enGameLevel)QuizzLevel;
            Quizz.OpType = (enOpType)OpType;
            Quizz.QuestionList = new stQuestion[(int)NumberOfQs];
            Quizz.QuestionList[QuestionNum].QuestionNumber = 1;
            lbQuestionNumber.Text = Quizz.QuestionList[QuestionNum].QuestionNumber.ToString();
            pictureBox1.Image = null;
          
            timer1.Start();
        }
        private int RandomNum(int From, int To)
        {  
            return rnd.Next(From, To);
        }
        private enOpType GetRandomOpType()
        {
            int Op = RandomNum(0, 4);
            return (enOpType)Op;
        }
        enum enGameLevel { Easy = 1, Mid = 2, Hard = 3, Mix = 4 };
        enum enOpType { Add = 0, Sub = 1, Mul = 2, Div = 3, Mix2 = 4 };


        struct stQuestion
        {
            public float Number1;
            public float Number2;
            public enOpType OpartionType;
            public enGameLevel GameLevel;
            public float CorrectAnswer;
            public string PlayerAnswer;
            public int QuestionNumber;
             public bool IsCorrect;
        };
        struct stQuizz
        {
            public stQuestion[] QuestionList;
            public decimal NumberOfQeustions;
            public enOpType OpType;
            public enGameLevel GameLevel;
            public short NumberOfRightAnswer;
            public short NumberOfWrongAnswer;
            public bool IsPass;
        };
        private float SimpleCalculator(float Number1, float Number2, enOpType OpType)
        {
            switch (OpType)
            {
                case enOpType.Add:
                    return Number1 + Number2;
               
                case enOpType.Sub:
                    return Number1 - Number2;
            
                case enOpType.Mul:
                    return Number1 * Number2;
       
                case enOpType.Div:
                    return Number1 / Number2;
          
                default:
                    return 0;
            }
        }
        
        string GetRandomSymbol()
        {
           short Num = (short)RandomNum(1, 4);
            if (Num == 1)
                return " +";
            else if (Num == 2)
                return " -";
            else if (Num == 3)
                return " *";
            else
                return " /";
        }
        private void GetOpTypeSymbol(enOpType OpType)
        {
            switch (OpType)
            {
                case enOpType.Add:
                    lbOpType.Text= " +";
                    break;
                case enOpType.Sub:
                    lbOpType.Text = " -";
                    break;
                case enOpType.Mul:
                    lbOpType.Text = " *";
                    break;
                case enOpType.Div:
                    lbOpType.Text = " /";
                    break;
                default:
                    lbOpType.Text = GetRandomSymbol();
                    break;
            }
        }
 
        private void ButtonOfRightAnswer(stQuestion Question)
        {
            int RigthAnswerPosition = RandomNum(1, 5);      
            if (RigthAnswerPosition == 1)
            {
                button1.Text = Question.CorrectAnswer.ToString();
                ButtonOfCorrectAnswer = button1;
            }
            else if (RigthAnswerPosition == 2)
            {
                button2.Text = Question.CorrectAnswer.ToString();
                ButtonOfCorrectAnswer = button2;
            }
            else if (RigthAnswerPosition == 3)
            {
                button3.Text = Question.CorrectAnswer.ToString();
                ButtonOfCorrectAnswer = button3;
            }
            else
            {
                button4.Text = Question.CorrectAnswer.ToString();
                ButtonOfCorrectAnswer = button4;
            }
        }
        private void ButtonChoice(enGameLevel gameLevel, float CorrectAnswer)
        {
         
            switch(gameLevel) 
            {
                case enGameLevel.Easy:
                    button1.Text = (CorrectAnswer + RandomNum(1, 4)).ToString();
                    button2.Text = (CorrectAnswer - RandomNum(1, 4)).ToString();
                    button3.Text = (CorrectAnswer + RandomNum(1, 4)).ToString();
                    button4.Text = (CorrectAnswer - RandomNum(1, 4)).ToString();
                    break;
                case enGameLevel.Mid:
                    button1.Text = (CorrectAnswer + RandomNum(1, 5)).ToString();
                    button2.Text = (CorrectAnswer - RandomNum(1, 5)).ToString();
                    button3.Text = (CorrectAnswer + RandomNum(1, 5)).ToString();
                    button4.Text = (CorrectAnswer - RandomNum(1, 5)).ToString();
                    break;
                case enGameLevel.Hard:
                    button1.Text =(CorrectAnswer + RandomNum(1, 6)).ToString();
                    button2.Text =(CorrectAnswer - RandomNum(1, 6)).ToString();
                    button3.Text =(CorrectAnswer + RandomNum(1, 6)).ToString();
                    button4.Text = (CorrectAnswer - RandomNum(1,6)).ToString();
                    break;

            }
            
        }
        private stQuestion GenrateQuestion(enGameLevel GameLevel, enOpType OpTyp)
        {

           
            if (GameLevel == enGameLevel.Mix)
            {
                GameLevel = (enGameLevel)RandomNum(1, 4);
            }
            if (OpTyp == enOpType.Mix2)
            {
                OpTyp = GetRandomOpType();
            }
            Question.OpartionType = OpTyp;
            GetOpTypeSymbol(OpTyp);
            switch (GameLevel)
            {
                case enGameLevel.Easy:
                    Question.Number1 = RandomNum(1, 11);
                    lbNum1.Text = Question.Number1.ToString();
                     Question.Number2 = RandomNum(1, 11);
                    lbNum2.Text = Question.Number2.ToString(); ;     
                    Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OpartionType);
                    ButtonChoice(enGameLevel.Easy, Question.CorrectAnswer);
                    ButtonOfRightAnswer(Question);
                    Question.GameLevel = GameLevel;     
                    Question.QuestionNumber++;
                    lbAnswer.Text = "?";
                    lbQuestionNumber.Text = Question.QuestionNumber.ToString();
             
                    return Question;
                case enGameLevel.Mid:
                    Question.Number1 = RandomNum(10, 51);
                    lbNum1.Text = Question.Number1.ToString();
                    Question.Number2 = RandomNum(10, 51);
                    lbNum2.Text = Question.Number2.ToString();
                   
                    Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OpartionType);
                    ButtonChoice(enGameLevel.Mid, Question.CorrectAnswer);
                    ButtonOfRightAnswer(Question);
                    Question.GameLevel = GameLevel;
                    Question.QuestionNumber++;
                    lbAnswer.Text = "?";
                    lbQuestionNumber.Text = Question.QuestionNumber.ToString();
            
                    return Question;
                case enGameLevel.Hard:
                    Question.Number1 = RandomNum(50, 101);
                    lbNum1.Text = Question.Number1.ToString();
                    Question.Number2 = RandomNum(50, 101);
                    lbNum2.Text = Question.Number2.ToString();
                  
                    Question.CorrectAnswer = SimpleCalculator(Question.Number1, Question.Number2, Question.OpartionType);
                    ButtonChoice(enGameLevel.Hard, Question.CorrectAnswer);
                    ButtonOfRightAnswer(Question);
                    Question.GameLevel = GameLevel;
                    Question.QuestionNumber++;
                    lbAnswer.Text = "?";
                    lbQuestionNumber.Text = Question.QuestionNumber.ToString();
                  
                    return Question;
            }
         
            return Question;
        }
     
        private  void GenrateQuizzQeustions()
        {
           
            lbTotalQuestions.Text = Quizz.NumberOfQeustions.ToString();
        
       
            if (QuestionNum < Quizz.NumberOfQeustions)
            {
               
                Quizz.QuestionList[QuestionNum] = GenrateQuestion(Quizz.GameLevel,Quizz.OpType);

            }
            else
            {
                timer1.Stop();            
                pictureBox1.Image = null;
               
        
                Form frm = new frmReport((short)Quizz.NumberOfQeustions,Quizz.NumberOfRightAnswer,Quizz.NumberOfWrongAnswer,GetGameLevelText(),GetOpTypeText(),GetPersentageResult(),GetFinalResultsText(Quizz.IsPass), GetFullQuestionAsTextWithAnswer());
                frm.ShowDialog();
                Reset();
                this.Close();
            }
     
       
        }
        void Reset()
        {
            Quizz.NumberOfRightAnswer = 0;
            Quizz.NumberOfWrongAnswer = 0;

        }
        string OpTypeSymbol(enOpType type)
        {
            switch (type) 
            {
                case enOpType.Add:
                    return "+";
             
                case enOpType.Sub:
                    return "-";
              
                case enOpType.Mul:
                    return "*";
    
                case enOpType.Div:
                    return "/";
  
                default:
                    return "";
            }
        }
        List<string> GetFullQuestionAsTextWithAnswer()
        {
            string Question = "";
        
            List<string> QuestionList = new List<string>();
            for (short i = 0; i < Quizz.NumberOfQeustions; i++)
            {
              
                if (Quizz.QuestionList[i].PlayerAnswer == null)
                {
                    Question = $"Question [{i + 1}/{Quizz.NumberOfQeustions}]:\n:-(";
                  

                }
                else if (Quizz.QuestionList[i].IsCorrect)
                {
                    Question = $"Question [{i + 1}/{Quizz.NumberOfQeustions}]: Time: {time[i]}:\n{Quizz.QuestionList[i].Number1}  {OpTypeSymbol(Quizz.QuestionList[i].OpartionType)}  {Quizz.QuestionList[i].Number2} =  {Quizz.QuestionList[i].PlayerAnswer}\t :-) RIGHT";
                }
                else
                    Question = $"Question [{i + 1}/{Quizz.NumberOfQeustions}]: Time: {time[i]}:\n{Quizz.QuestionList[i].Number1}  {OpTypeSymbol(Quizz.QuestionList[i].OpartionType)}  {Quizz.QuestionList[i].Number2} =  {Quizz.QuestionList[i].PlayerAnswer}\t :-( WRONG = {Quizz.QuestionList[i].CorrectAnswer}";
           
                QuestionList.Add(Question);
            }
            return QuestionList;
        }
        string GetPersentageResult()
        {
            Result = Math.Round((Quizz.NumberOfRightAnswer/Quizz.NumberOfQeustions)*100);
     
            if (Result >= 50)
            {
                Quizz.IsPass = true;
            }
            else
                Quizz.IsPass = false;
            return Result.ToString()+"%";

        }
        string GetGameLevelText()
        {
            switch(Quizz.GameLevel)
            {
                case enGameLevel.Easy:
                    return "Easy";
            
                case enGameLevel.Mid:
                    return "Medium";
           
                case enGameLevel.Hard:
                    return "Hard";
        
                case enGameLevel.Mix:
                    return "Random";
           
                default:
                    return "";
        
            }
        }
        string GetOpTypeText()
        {
            switch( Quizz.OpType) 
            {
                case enOpType.Add:
                    return "Addition";
                  
                case enOpType.Sub:
                    return "Subtraction";
              
                case enOpType.Mul:
                    return "Multiplication";
            
                case enOpType.Div:
                    return "Divition";
               
                case enOpType.Mix2:
                    return "Random";
        
                default:
                    return "";
              
            }
        }
  
        void Reset(Button btn)
        {
          
            lbAnswer.Text = "?";
            btn.BackColor = Color.DarkOrange;  
            pictureBox1.Image = null;
          
        }

    
        void CorrectTheQeustionAnswer(ref stQuizz Quizz,Button btn)
        {
          
            lbAnswer.Text = btn.Text;
            Quizz.QuestionList[QuestionNum-1].PlayerAnswer = lbAnswer.Text;
            if (lbAnswer.Text == Question.CorrectAnswer.ToString())
            {
                System.Media.SoundPlayer player1 = new System.Media.SoundPlayer(@"C:\Users\lap2p\source\repos\Math Game Project\Math Game Project\Resources\Correct.wav");
                player1.Play();
                pictureBox1.Image = Resources.Resources.r_png;
                pictureBox2.Image = Resources.Resources.boyr__1_;
                btn.BackColor = Color.Green;
                Quizz.NumberOfRightAnswer++;
                Quizz.QuestionList[QuestionNum-1].IsCorrect = true;
                time.Add(lbTimer.Text);
                if (lbAnswer.Text != " ? ")
                    Answer.Add(lbAnswer.Text);
                else
                    Answer.Add("");
             
             
               
            }
            else
            {
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(@"C:\Users\lap2p\source\repos\Math Game Project\Math Game Project\Resources\Wrong.wav");
                player2.Play();
                pictureBox1.Image = Resources.Resources.x_png;
                pictureBox2.Image = Resources.Resources.boyx__1_;
                btn.BackColor = Color.Red;
                ButtonOfCorrectAnswer.BackColor = Color.Green;
                Quizz.NumberOfWrongAnswer++;
                Quizz.QuestionList[QuestionNum - 1].IsCorrect = false;
                time.Add(lbTimer.Text);
                if (lbAnswer.Text != "?")
                    Answer.Add(lbAnswer.Text);
                else
                    Answer.Add("");
              
            
              
            }
    

        }

        string GetFinalResultsText(bool Pass)
        {
            return Pass ? "Pass" : "Fail";
        }
        private void EnabaleDisableButtons(bool Enable)
        {

            button1.Enabled = Enable;
            button2.Enabled = Enable;
            button3.Enabled = Enable;
            button4.Enabled = Enable;

        }
        private async void button_Click(object sender, EventArgs e)
        {
          
            QuestionNum++;
          
            CorrectTheQeustionAnswer(ref Quizz,(Button)sender);
            EnabaleDisableButtons(false);
            await Task.Delay(1500);
            Reset((Button)sender);
            ButtonOfCorrectAnswer.BackColor = Color.DarkOrange;
            GenrateQuizzQeustions();
            EnabaleDisableButtons(true);
           
        }




        private void btnLeave_MouseEnter(object sender, EventArgs e)
        {
            btnLeave.BackColor = btnLeave.ForeColor; btnLeave.ForeColor = Color.White;
        }

        private void btnLeave_MouseLeave(object sender, EventArgs e)
        {
            btnLeave.ForeColor = btnLeave.BackColor; btnLeave.BackColor = Color.Transparent;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            Form frm = new frmReport((short)Quizz.NumberOfQeustions, Quizz.NumberOfRightAnswer, Quizz.NumberOfWrongAnswer, GetGameLevelText(), GetOpTypeText(), GetPersentageResult(), GetFinalResultsText(Quizz.IsPass), GetFullQuestionAsTextWithAnswer());
            this.Close();
            Reset();
            frm.ShowDialog();
           
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;btn.BackColor = Color.Orange;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkOrange;btn.ForeColor = Color.Black;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GenrateQuizzQeustions();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Sec--;
            if (Sec == 0 && Min > 0)
            {
                Sec = 59;
                Min--;
            }
            if (Min == 0 && Hour > 0)
            {
                Min = 60;
                Hour--;
            }

            lbTimer.Text = string.Format("{0}:{1}:{2}", Hour.ToString().PadLeft(2, '0'),
                Min.ToString().PadLeft(2, '0'), Sec.ToString().PadLeft(2, '0'));
       
            if (Sec <= 5&&Sec>1&&Min==0&&Hour==0)
            {
                lbTimer.BackColor = Color.DarkRed;
                System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(@"C:\Users\lap2p\source\repos\Math Game Project\Math Game Project\Resources\clock-ticking-3.wav");
                player3.Play();
            }
            if (Hour == 0 && Min == 0 && Sec == 0)
            {
                
                timer1.Stop();
              
                Form frm = new frmReport((short)Quizz.NumberOfQeustions,Quizz.NumberOfRightAnswer, Quizz.NumberOfWrongAnswer, GetGameLevelText(), GetOpTypeText(), GetPersentageResult(), GetFinalResultsText(Quizz.IsPass), GetFullQuestionAsTextWithAnswer());
                this.Close();
                Reset();
                frm.ShowDialog();
                
            }

            

        }
    }
} 
