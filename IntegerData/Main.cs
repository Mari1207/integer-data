using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerData
{
    public class frmMain : Form
    {
        internal Label label1;
        private Label label2;
        private TextBox txtOperand2;
        private TextBox txtResult;
        private Button btncalc;
        private Button btnExit;
        private TextBox txtOperand1;
        #region WindowCode
        private void  InitializeComponent()
        {            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(102, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first integer value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(105, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "enter second integer value";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(208, 70);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 2;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(208, 96);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(105, 150);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(255, 20);
            this.txtResult.TabIndex = 4;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(105, 291);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 5;
            this.btncalc.Text = "&Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.Btncalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(226, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.UseWaitCursor = true;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.ClientSize = new System.Drawing.Size(546, 512);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Integer Division";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

}
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }
        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void Btncalc_Click(object sender, EventArgs e)
        {
            bool flag;
            decimal operand1;
            decimal operand2;
            decimal answer;
            //input set
            //Check first iput..
            flag = decimal.TryParse(txtOperand1.Text, out operand1);
            if (flag==false)
            {
                MessageBox.Show("enter a whole number", "Input Error");
                txtOperand1.Focus();
                //stop ececuting command of code
                return;
            }
            //Check second input 
            flag = decimal.TryParse(txtOperand2.Text, out operand2);
            if (flag == false)
            {
                MessageBox.Show("Enter a whole number", "Input Error");
                txtOperand2.Focus();
                return;

            }
            //Process step
            answer = operand1 / operand2;
            //Display Step
            txtResult.Text = operand1.ToString() + "divided by" +
                operand2.ToString() +
                "equals " + answer.ToString();
            txtResult.Visible = true;
               
        }
        private void btnExit_Click(object sender,EventArgs e)
        { Close(); }
    }
}
 