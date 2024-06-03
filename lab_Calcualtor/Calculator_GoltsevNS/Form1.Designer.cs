namespace Calculator_GoltsevNS
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bntBS = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnMlt = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDt = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTg = new System.Windows.Forms.Button();
            this.btnCtg = new System.Windows.Forms.Button();
            this.btnRadDeg = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.btnPiNum = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSQRT = new System.Windows.Forms.Button();
            this.btnMltT = new System.Windows.Forms.Button();
            this.btnSQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntBS
            // 
            this.bntBS.Location = new System.Drawing.Point(10, 149);
            this.bntBS.Name = "bntBS";
            this.bntBS.Size = new System.Drawing.Size(79, 63);
            this.bntBS.TabIndex = 0;
            this.bntBS.Text = "‹";
            this.bntBS.UseVisualStyleBackColor = true;
            this.bntBS.Click += new System.EventHandler(this.btnBS);
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(399, 11);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(167, 43);
            this.lblDisplay.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(222, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(344, 50);
            this.lblResult.TabIndex = 2;
            this.lblResult.Click += new System.EventHandler(this.specialNumClick);
            // 
            // btnCE
            // 
            this.btnCE.Location = new System.Drawing.Point(95, 149);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(79, 63);
            this.btnCE.TabIndex = 3;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(180, 149);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(79, 63);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnPM
            // 
            this.btnPM.Location = new System.Drawing.Point(265, 149);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(79, 63);
            this.btnPM.TabIndex = 5;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = true;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(265, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 63);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.opClick);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(180, 218);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(79, 63);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(95, 218);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(79, 63);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(10, 218);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 63);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(265, 287);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(79, 63);
            this.btnSub.TabIndex = 13;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.opClick);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(180, 287);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(79, 63);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(95, 287);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(79, 63);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(10, 287);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(79, 63);
            this.btn4.TabIndex = 10;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnMlt
            // 
            this.btnMlt.Location = new System.Drawing.Point(265, 356);
            this.btnMlt.Name = "btnMlt";
            this.btnMlt.Size = new System.Drawing.Size(79, 63);
            this.btnMlt.TabIndex = 17;
            this.btnMlt.Text = "*";
            this.btnMlt.UseVisualStyleBackColor = true;
            this.btnMlt.Click += new System.EventHandler(this.opClick);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(180, 356);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(79, 63);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(95, 356);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(79, 63);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(10, 356);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 63);
            this.btn1.TabIndex = 14;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnDev
            // 
            this.btnDev.Location = new System.Drawing.Point(265, 425);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(79, 63);
            this.btnDev.TabIndex = 21;
            this.btnDev.Text = "/";
            this.btnDev.UseVisualStyleBackColor = true;
            this.btnDev.Click += new System.EventHandler(this.opClick);
            // 
            // btnEquals
            // 
            this.btnEquals.Location = new System.Drawing.Point(180, 425);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(79, 63);
            this.btnEquals.TabIndex = 20;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDt
            // 
            this.btnDt.Location = new System.Drawing.Point(95, 425);
            this.btnDt.Name = "btnDt";
            this.btnDt.Size = new System.Drawing.Size(79, 63);
            this.btnDt.TabIndex = 19;
            this.btnDt.Text = ",";
            this.btnDt.UseVisualStyleBackColor = true;
            this.btnDt.Click += new System.EventHandler(this.NumberClick);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(10, 425);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(79, 63);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NumberClick);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(371, 238);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(79, 63);
            this.btnSin.TabIndex = 23;
            this.btnSin.Text = "sin(x)";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btn_TrigClick);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(371, 332);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(79, 63);
            this.btnCos.TabIndex = 24;
            this.btnCos.Text = "cos(x)";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btn_TrigClick);
            // 
            // btnTg
            // 
            this.btnTg.Location = new System.Drawing.Point(371, 419);
            this.btnTg.Name = "btnTg";
            this.btnTg.Size = new System.Drawing.Size(79, 63);
            this.btnTg.TabIndex = 25;
            this.btnTg.Text = "tg(x)";
            this.btnTg.UseVisualStyleBackColor = true;
            this.btnTg.Click += new System.EventHandler(this.btn_TrigClick);
            // 
            // btnCtg
            // 
            this.btnCtg.Location = new System.Drawing.Point(371, 506);
            this.btnCtg.Name = "btnCtg";
            this.btnCtg.Size = new System.Drawing.Size(79, 63);
            this.btnCtg.TabIndex = 26;
            this.btnCtg.Text = "ctg(x)";
            this.btnCtg.UseVisualStyleBackColor = true;
            this.btnCtg.Click += new System.EventHandler(this.btn_TrigClick);
            // 
            // btnRadDeg
            // 
            this.btnRadDeg.Location = new System.Drawing.Point(265, 15);
            this.btnRadDeg.Name = "btnRadDeg";
            this.btnRadDeg.Size = new System.Drawing.Size(88, 39);
            this.btnRadDeg.TabIndex = 27;
            this.btnRadDeg.Text = "Deg";
            this.btnRadDeg.UseVisualStyleBackColor = true;
            this.btnRadDeg.Click += new System.EventHandler(this.btnRadDeg_Click);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(371, 149);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(79, 63);
            this.btnPow.TabIndex = 28;
            this.btnPow.Text = "^";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btnPow_Click);
            // 
            // btnPiNum
            // 
            this.btnPiNum.Location = new System.Drawing.Point(10, 494);
            this.btnPiNum.Name = "btnPiNum";
            this.btnPiNum.Size = new System.Drawing.Size(79, 63);
            this.btnPiNum.TabIndex = 29;
            this.btnPiNum.Text = "Pi";
            this.btnPiNum.UseVisualStyleBackColor = true;
            this.btnPiNum.Click += new System.EventHandler(this.specialNumClick);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(265, 494);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(79, 63);
            this.btnMod.TabIndex = 30;
            this.btnMod.Text = "mod(x)";
            this.btnMod.UseVisualStyleBackColor = true;
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(180, 494);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(79, 63);
            this.btnLog.TabIndex = 31;
            this.btnLog.Text = "log(x)";
            this.btnLog.UseVisualStyleBackColor = true;
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(95, 494);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(79, 63);
            this.btnExp.TabIndex = 32;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.specialNumClick);
            // 
            // btnFact
            // 
            this.btnFact.Location = new System.Drawing.Point(487, 149);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(79, 63);
            this.btnFact.TabIndex = 37;
            this.btnFact.Text = "n!";
            this.btnFact.UseVisualStyleBackColor = true;
            this.btnFact.Click += new System.EventHandler(this.specialOpRGT);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(487, 506);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 63);
            this.button5.TabIndex = 36;
            this.button5.Text = "ln(x)";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.specialOpRGT);
            // 
            // btnSQRT
            // 
            this.btnSQRT.Location = new System.Drawing.Point(487, 419);
            this.btnSQRT.Name = "btnSQRT";
            this.btnSQRT.Size = new System.Drawing.Size(79, 63);
            this.btnSQRT.TabIndex = 35;
            this.btnSQRT.Text = "sqrt(x)";
            this.btnSQRT.UseVisualStyleBackColor = true;
            this.btnSQRT.Click += new System.EventHandler(this.specialOpRGT);
            // 
            // btnMltT
            // 
            this.btnMltT.Location = new System.Drawing.Point(487, 332);
            this.btnMltT.Name = "btnMltT";
            this.btnMltT.Size = new System.Drawing.Size(79, 63);
            this.btnMltT.TabIndex = 34;
            this.btnMltT.Text = "10x";
            this.btnMltT.UseVisualStyleBackColor = true;
            this.btnMltT.Click += new System.EventHandler(this.specialOpRGT);
            // 
            // btnSQ
            // 
            this.btnSQ.Location = new System.Drawing.Point(487, 238);
            this.btnSQ.Name = "btnSQ";
            this.btnSQ.Size = new System.Drawing.Size(79, 63);
            this.btnSQ.TabIndex = 33;
            this.btnSQ.Text = "x^2";
            this.btnSQ.UseVisualStyleBackColor = true;
            this.btnSQ.Click += new System.EventHandler(this.specialOpRGT);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(579, 588);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSQRT);
            this.Controls.Add(this.btnMltT);
            this.Controls.Add(this.btnSQ);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnPiNum);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnRadDeg);
            this.Controls.Add(this.btnCtg);
            this.Controls.Add(this.btnTg);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnDt);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnMlt);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.bntBS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.btn_TrigClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntBS;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnPM;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnMlt;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnDt;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTg;
        private System.Windows.Forms.Button btnCtg;
        private System.Windows.Forms.Button btnRadDeg;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnPiNum;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSQRT;
        private System.Windows.Forms.Button btnMltT;
        private System.Windows.Forms.Button btnSQ;
    }
}

