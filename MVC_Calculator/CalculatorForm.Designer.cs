using System.Windows.Forms;

namespace MVC_Calculator
{
    partial class CalculatorForm: Form
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDivided = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnNight = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtSecondOperand = new System.Windows.Forms.RichTextBox();
            this.txtOperator = new System.Windows.Forms.RichTextBox();
            this.txtFirstOperand = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnDivided);
            this.panel1.Controls.Add(this.btnMulti);
            this.panel1.Controls.Add(this.btnSub);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEqual);
            this.panel1.Controls.Add(this.btnThree);
            this.panel1.Controls.Add(this.btnSix);
            this.panel1.Controls.Add(this.btnNight);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnTwo);
            this.panel1.Controls.Add(this.btnFive);
            this.panel1.Controls.Add(this.btnEight);
            this.panel1.Controls.Add(this.btnZero);
            this.panel1.Controls.Add(this.btnOne);
            this.panel1.Controls.Add(this.btnFour);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Location = new System.Drawing.Point(12, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 258);
            this.panel1.TabIndex = 0;
            // 
            // btnDivided
            // 
            this.btnDivided.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDivided.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnDivided.Location = new System.Drawing.Point(420, 195);
            this.btnDivided.Name = "btnDivided";
            this.btnDivided.Size = new System.Drawing.Size(133, 58);
            this.btnDivided.TabIndex = 15;
            this.btnDivided.Text = "÷";
            this.btnDivided.UseVisualStyleBackColor = false;
            // 
            // btnMulti
            // 
            this.btnMulti.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnMulti.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnMulti.Location = new System.Drawing.Point(420, 131);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(133, 58);
            this.btnMulti.TabIndex = 14;
            this.btnMulti.Text = "×";
            this.btnMulti.UseVisualStyleBackColor = false;
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSub.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSub.Location = new System.Drawing.Point(420, 67);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(133, 58);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "－";
            this.btnSub.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(420, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 58);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "＋";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Aquamarine;
            this.btnEqual.Font = new System.Drawing.Font("微軟正黑體", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEqual.Location = new System.Drawing.Point(281, 195);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(133, 58);
            this.btnEqual.TabIndex = 11;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnThree.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnThree.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Location = new System.Drawing.Point(281, 131);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(133, 58);
            this.btnThree.TabIndex = 10;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSix.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSix.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Location = new System.Drawing.Point(281, 67);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(133, 58);
            this.btnSix.TabIndex = 9;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            // 
            // btnNight
            // 
            this.btnNight.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnNight.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnNight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNight.Location = new System.Drawing.Point(281, 3);
            this.btnNight.Name = "btnNight";
            this.btnNight.Size = new System.Drawing.Size(133, 58);
            this.btnNight.TabIndex = 8;
            this.btnNight.Text = "9";
            this.btnNight.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.GrayText;
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(142, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 58);
            this.button5.TabIndex = 7;
            this.button5.Text = "．";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnTwo.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnTwo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.Location = new System.Drawing.Point(142, 131);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(133, 58);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFive.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnFive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Location = new System.Drawing.Point(142, 67);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(133, 58);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEight.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnEight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.Location = new System.Drawing.Point(142, 3);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(133, 58);
            this.btnEight.TabIndex = 4;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnZero.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnZero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.Location = new System.Drawing.Point(3, 195);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(133, 58);
            this.btnZero.TabIndex = 3;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnOne.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnOne.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Location = new System.Drawing.Point(3, 131);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(133, 58);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnFour.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnFour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Location = new System.Drawing.Point(3, 67);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(133, 58);
            this.btnFour.TabIndex = 1;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSeven.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnSeven.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.Location = new System.Drawing.Point(3, 3);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(133, 58);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.txtSecondOperand);
            this.panel2.Controls.Add(this.txtOperator);
            this.panel2.Controls.Add(this.txtFirstOperand);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 100);
            this.panel2.TabIndex = 1;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Font = new System.Drawing.Font("微軟正黑體", 32F, System.Drawing.FontStyle.Bold);
            this.txtResult.Location = new System.Drawing.Point(420, 3);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(133, 94);
            this.txtResult.TabIndex = 3;
            this.txtResult.Text = "";
            // 
            // txtSecondOperand
            // 
            this.txtSecondOperand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSecondOperand.Font = new System.Drawing.Font("微軟正黑體", 32F, System.Drawing.FontStyle.Bold);
            this.txtSecondOperand.Location = new System.Drawing.Point(281, 3);
            this.txtSecondOperand.Name = "txtSecondOperand";
            this.txtSecondOperand.Size = new System.Drawing.Size(133, 94);
            this.txtSecondOperand.TabIndex = 2;
            this.txtSecondOperand.Text = "";
            // 
            // txtOperator
            // 
            this.txtOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOperator.Font = new System.Drawing.Font("微軟正黑體", 32F, System.Drawing.FontStyle.Bold);
            this.txtOperator.Location = new System.Drawing.Point(142, 3);
            this.txtOperator.Name = "txtOperator";
            this.txtOperator.Size = new System.Drawing.Size(133, 94);
            this.txtOperator.TabIndex = 1;
            this.txtOperator.Text = "";
            // 
            // txtFirstOperand
            // 
            this.txtFirstOperand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstOperand.Font = new System.Drawing.Font("微軟正黑體", 32F, System.Drawing.FontStyle.Bold);
            this.txtFirstOperand.Location = new System.Drawing.Point(3, 3);
            this.txtFirstOperand.Name = "txtFirstOperand";
            this.txtFirstOperand.Size = new System.Drawing.Size(133, 94);
            this.txtFirstOperand.TabIndex = 0;
            this.txtFirstOperand.Text = "";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 388);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CalculatorForm";
            this.Text = "MVC Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txtFirstOperand;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivided;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnNight;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnFour;
        private RichTextBox txtOperator;
        private RichTextBox txtResult;
        private RichTextBox txtSecondOperand;
    }
}

