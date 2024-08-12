using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Math_Game_Project.frmMain;

namespace Math_Game_Project
{
    public partial class frmMain : Form
    {
       
        public frmMain()
        {
            InitializeComponent();
            CBQuizzLevel.SelectedIndex = 3;
            CbOPType.SelectedIndex = 4;
            button2.Enabled = false;
      
            
        }

     
        
           
        
      
        private void button2_Click(object sender, EventArgs e)
        {
            decimal NumberOfQs = numericUpDown3.Value;
            int QuizzLevel = CBQuizzLevel.SelectedIndex+1;
            int OpType = CbOPType.SelectedIndex;
            decimal Mins = nuTime.Value;
  
            Form form = new frmClassRoom(NumberOfQs, QuizzLevel, OpType,Mins);
            form.ShowDialog();

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
               if(numericUpDown3.Value>0&&nuTime.Value>0)
                   button2.Enabled=true;
               else
                   button2.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuTime_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value > 0 && nuTime.Value > 0)
                button2.Enabled = true;
            else
                button2.Enabled=false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Orange; button2.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black; button2.BackColor = numericUpDown3.BackColor;
        }

    }
   
  
}
