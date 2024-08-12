namespace Math_Game_Project
{
    partial class frmClassRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassRoom));
            this.lbNum1 = new System.Windows.Forms.Label();
            this.lbQuestionNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbNum2 = new System.Windows.Forms.Label();
            this.lbOpType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalQuestions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNum1
            // 
            this.lbNum1.AutoSize = true;
            this.lbNum1.BackColor = System.Drawing.Color.Transparent;
            this.lbNum1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum1.ForeColor = System.Drawing.Color.White;
            this.lbNum1.Location = new System.Drawing.Point(325, 216);
            this.lbNum1.Name = "lbNum1";
            this.lbNum1.Size = new System.Drawing.Size(45, 52);
            this.lbNum1.TabIndex = 0;
            this.lbNum1.Text = "0";
            // 
            // lbQuestionNumber
            // 
            this.lbQuestionNumber.AutoSize = true;
            this.lbQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbQuestionNumber.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionNumber.ForeColor = System.Drawing.Color.Black;
            this.lbQuestionNumber.Location = new System.Drawing.Point(430, 164);
            this.lbQuestionNumber.Name = "lbQuestionNumber";
            this.lbQuestionNumber.Size = new System.Drawing.Size(45, 52);
            this.lbQuestionNumber.TabIndex = 2;
            this.lbQuestionNumber.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 75);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(613, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 75);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(423, 664);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 75);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "0";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrange;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(613, 664);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 75);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "0";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            this.button4.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button4.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // lbNum2
            // 
            this.lbNum2.AutoSize = true;
            this.lbNum2.BackColor = System.Drawing.Color.Transparent;
            this.lbNum2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNum2.ForeColor = System.Drawing.Color.White;
            this.lbNum2.Location = new System.Drawing.Point(458, 216);
            this.lbNum2.Name = "lbNum2";
            this.lbNum2.Size = new System.Drawing.Size(45, 52);
            this.lbNum2.TabIndex = 7;
            this.lbNum2.Text = "0";
            // 
            // lbOpType
            // 
            this.lbOpType.AutoSize = true;
            this.lbOpType.BackColor = System.Drawing.Color.Transparent;
            this.lbOpType.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpType.ForeColor = System.Drawing.Color.White;
            this.lbOpType.Location = new System.Drawing.Point(396, 216);
            this.lbOpType.Name = "lbOpType";
            this.lbOpType.Size = new System.Drawing.Size(40, 52);
            this.lbOpType.TabIndex = 8;
            this.lbOpType.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(527, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 52);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.BackColor = System.Drawing.Color.Transparent;
            this.lbAnswer.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.Color.White;
            this.lbAnswer.Location = new System.Drawing.Point(580, 216);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(40, 52);
            this.lbAnswer.TabIndex = 10;
            this.lbAnswer.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(481, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 52);
            this.label2.TabIndex = 11;
            this.label2.Text = "/";
            // 
            // lbTotalQuestions
            // 
            this.lbTotalQuestions.AutoSize = true;
            this.lbTotalQuestions.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalQuestions.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalQuestions.ForeColor = System.Drawing.Color.Black;
            this.lbTotalQuestions.Location = new System.Drawing.Point(508, 164);
            this.lbTotalQuestions.Name = "lbTotalQuestions";
            this.lbTotalQuestions.Size = new System.Drawing.Size(45, 52);
            this.lbTotalQuestions.TabIndex = 12;
            this.lbTotalQuestions.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
            this.pictureBox1.Location = new System.Drawing.Point(1024, 165);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lbTimer.Font = new System.Drawing.Font("Impact", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(106, 39);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(117, 34);
            this.lbTimer.TabIndex = 21;
            this.lbTimer.Text = "00:00:00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Math_Game_Project.Properties.Resources.boy_point;
            this.pictureBox2.Location = new System.Drawing.Point(777, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 400);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.Transparent;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeave.Location = new System.Drawing.Point(98, 518);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(125, 56);
            this.btnLeave.TabIndex = 5;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            this.btnLeave.MouseEnter += new System.EventHandler(this.btnLeave_MouseEnter);
            this.btnLeave.MouseLeave += new System.EventHandler(this.btnLeave_MouseLeave);
            // 
            // frmClassRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Math_Game_Project.Resources.Resources.d5709e2f8a4e373f73c2eae987ebbfc6_resized_resized_resized_resized_resized;
            this.ClientSize = new System.Drawing.Size(1201, 767);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbTotalQuestions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbOpType);
            this.Controls.Add(this.lbNum2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbQuestionNumber);
            this.Controls.Add(this.lbNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class room";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNum1;
        private System.Windows.Forms.Label lbQuestionNumber;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbNum2;
        private System.Windows.Forms.Label lbOpType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalQuestions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLeave;
    }
}