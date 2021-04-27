
namespace Calculator_Project
{
    partial class Form1
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bSub = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.bEq = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.btnnextconvert = new System.Windows.Forms.Button();
            this.btnnextcalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amount_txt = new System.Windows.Forms.TextBox();
            this.txtfrom = new System.Windows.Forms.ComboBox();
            this.txtTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.display_txt = new System.Windows.Forms.Label();
            this.btnConv = new System.Windows.Forms.Button();
            this.pnlConverter = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCalculator = new System.Windows.Forms.Panel();
            this.lbResult = new System.Windows.Forms.Label();
            this.bCE = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlConverter.SuspendLayout();
            this.pnlCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtResult.Location = new System.Drawing.Point(59, 57);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(294, 22);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.Click += new System.EventHandler(this.Operand);
            this.txtResult.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(62, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NumEvent);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(173, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 74);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.NumEvent);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(278, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 73);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.NumEvent);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(59, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 65);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.NumEvent);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(173, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 65);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.NumEvent);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(278, 171);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 65);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.NumEvent);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(59, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 71);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.NumEvent);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(173, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 71);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.NumEvent);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(278, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 71);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.NumEvent);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(59, 320);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 81);
            this.button10.TabIndex = 10;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.NumEvent);
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bAdd.Location = new System.Drawing.Point(173, 349);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 11;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Click += new System.EventHandler(this.Operand);
            // 
            // bSub
            // 
            this.bSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bSub.Location = new System.Drawing.Point(278, 320);
            this.bSub.Name = "bSub";
            this.bSub.Size = new System.Drawing.Size(75, 23);
            this.bSub.TabIndex = 12;
            this.bSub.Text = "-";
            this.bSub.UseVisualStyleBackColor = false;
            this.bSub.Click += new System.EventHandler(this.Operand);
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bMul.Location = new System.Drawing.Point(278, 349);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(75, 23);
            this.bMul.TabIndex = 13;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            this.bMul.Click += new System.EventHandler(this.Operand);
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bDiv.Location = new System.Drawing.Point(173, 378);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(75, 23);
            this.bDiv.TabIndex = 14;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            this.bDiv.Click += new System.EventHandler(this.Operand);
            // 
            // bEq
            // 
            this.bEq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bEq.Location = new System.Drawing.Point(278, 378);
            this.bEq.Name = "bEq";
            this.bEq.Size = new System.Drawing.Size(75, 23);
            this.bEq.TabIndex = 15;
            this.bEq.Text = "=";
            this.bEq.UseVisualStyleBackColor = false;
            this.bEq.Click += new System.EventHandler(this.bEq_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bC.Location = new System.Drawing.Point(59, 415);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(75, 23);
            this.bC.TabIndex = 16;
            this.bC.Text = "Clear";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // btnnextconvert
            // 
            this.btnnextconvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnextconvert.Location = new System.Drawing.Point(216, 12);
            this.btnnextconvert.Name = "btnnextconvert";
            this.btnnextconvert.Size = new System.Drawing.Size(89, 44);
            this.btnnextconvert.TabIndex = 17;
            this.btnnextconvert.Text = "Converter";
            this.btnnextconvert.UseVisualStyleBackColor = false;
            this.btnnextconvert.Click += new System.EventHandler(this.btnnextconvert_Click);
            // 
            // btnnextcalc
            // 
            this.btnnextcalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnextcalc.Location = new System.Drawing.Point(87, 12);
            this.btnnextcalc.Name = "btnnextcalc";
            this.btnnextcalc.Size = new System.Drawing.Size(94, 44);
            this.btnnextcalc.TabIndex = 19;
            this.btnnextcalc.Text = "Calculator";
            this.btnnextcalc.UseVisualStyleBackColor = false;
            this.btnnextcalc.Click += new System.EventHandler(this.btnnextcalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = " Enter Value:";
            // 
            // amount_txt
            // 
            this.amount_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.amount_txt.Location = new System.Drawing.Point(128, 49);
            this.amount_txt.Name = "amount_txt";
            this.amount_txt.Size = new System.Drawing.Size(100, 22);
            this.amount_txt.TabIndex = 21;
            // 
            // txtfrom
            // 
            this.txtfrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtfrom.FormattingEnabled = true;
            this.txtfrom.Items.AddRange(new object[] {
            "Miles",
            "Pounds",
            "Kilometers",
            "Kilograms"});
            this.txtfrom.Location = new System.Drawing.Point(128, 94);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(121, 24);
            this.txtfrom.TabIndex = 22;
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtTo.FormattingEnabled = true;
            this.txtTo.Items.AddRange(new object[] {
            "Miles",
            "Pounds",
            "Kilometers",
            "Kilograms"});
            this.txtTo.Location = new System.Drawing.Point(128, 145);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(121, 24);
            this.txtTo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Convert From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Convert To:";
            // 
            // display_txt
            // 
            this.display_txt.AutoSize = true;
            this.display_txt.Location = new System.Drawing.Point(17, 205);
            this.display_txt.Name = "display_txt";
            this.display_txt.Size = new System.Drawing.Size(105, 17);
            this.display_txt.TabIndex = 26;
            this.display_txt.Text = "Convert Result:";
            // 
            // btnConv
            // 
            this.btnConv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnConv.Location = new System.Drawing.Point(235, 49);
            this.btnConv.Name = "btnConv";
            this.btnConv.Size = new System.Drawing.Size(75, 23);
            this.btnConv.TabIndex = 27;
            this.btnConv.Text = "Convert";
            this.btnConv.UseVisualStyleBackColor = false;
            this.btnConv.Click += new System.EventHandler(this.btnConv_Click);
            // 
            // pnlConverter
            // 
            this.pnlConverter.Controls.Add(this.label5);
            this.pnlConverter.Controls.Add(this.txtfrom);
            this.pnlConverter.Controls.Add(this.btnConv);
            this.pnlConverter.Controls.Add(this.label1);
            this.pnlConverter.Controls.Add(this.display_txt);
            this.pnlConverter.Controls.Add(this.amount_txt);
            this.pnlConverter.Controls.Add(this.label3);
            this.pnlConverter.Controls.Add(this.txtTo);
            this.pnlConverter.Controls.Add(this.label2);
            this.pnlConverter.Location = new System.Drawing.Point(21, 62);
            this.pnlConverter.Name = "pnlConverter";
            this.pnlConverter.Size = new System.Drawing.Size(425, 465);
            this.pnlConverter.TabIndex = 28;
            this.pnlConverter.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Converter";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pnlCalculator
            // 
            this.pnlCalculator.Controls.Add(this.lbResult);
            this.pnlCalculator.Controls.Add(this.bCE);
            this.pnlCalculator.Controls.Add(this.button11);
            this.pnlCalculator.Controls.Add(this.label6);
            this.pnlCalculator.Controls.Add(this.label4);
            this.pnlCalculator.Controls.Add(this.bAdd);
            this.pnlCalculator.Controls.Add(this.txtResult);
            this.pnlCalculator.Controls.Add(this.button1);
            this.pnlCalculator.Controls.Add(this.button2);
            this.pnlCalculator.Controls.Add(this.button3);
            this.pnlCalculator.Controls.Add(this.bC);
            this.pnlCalculator.Controls.Add(this.button4);
            this.pnlCalculator.Controls.Add(this.bEq);
            this.pnlCalculator.Controls.Add(this.button5);
            this.pnlCalculator.Controls.Add(this.bDiv);
            this.pnlCalculator.Controls.Add(this.button6);
            this.pnlCalculator.Controls.Add(this.bMul);
            this.pnlCalculator.Controls.Add(this.button7);
            this.pnlCalculator.Controls.Add(this.bSub);
            this.pnlCalculator.Controls.Add(this.button8);
            this.pnlCalculator.Controls.Add(this.button9);
            this.pnlCalculator.Controls.Add(this.button10);
            this.pnlCalculator.Location = new System.Drawing.Point(21, 62);
            this.pnlCalculator.Name = "pnlCalculator";
            this.pnlCalculator.Size = new System.Drawing.Size(419, 465);
            this.pnlCalculator.TabIndex = 29;
            this.pnlCalculator.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(56, 38);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 17);
            this.lbResult.TabIndex = 24;
            // 
            // bCE
            // 
            this.bCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bCE.Location = new System.Drawing.Point(173, 414);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(75, 23);
            this.bCE.TabIndex = 23;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = false;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button11.Location = new System.Drawing.Point(173, 320);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 22;
            this.button11.Text = ".";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(146, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter your values below ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Permanent Marker", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(459, 540);
            this.Controls.Add(this.pnlCalculator);
            this.Controls.Add(this.pnlConverter);
            this.Controls.Add(this.btnnextcalc);
            this.Controls.Add(this.btnnextconvert);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlConverter.ResumeLayout(false);
            this.pnlConverter.PerformLayout();
            this.pnlCalculator.ResumeLayout(false);
            this.pnlCalculator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bSub;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.Button bEq;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button btnnextconvert;
        private System.Windows.Forms.Button btnnextcalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amount_txt;
        private System.Windows.Forms.ComboBox txtfrom;
        private System.Windows.Forms.ComboBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label display_txt;
        private System.Windows.Forms.Button btnConv;
        private System.Windows.Forms.Panel pnlConverter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCalculator;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.Label lbResult;
    }
}

