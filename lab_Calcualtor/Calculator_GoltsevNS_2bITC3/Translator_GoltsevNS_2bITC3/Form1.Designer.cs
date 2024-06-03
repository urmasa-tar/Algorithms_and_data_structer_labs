namespace Translator_GoltsevNS_2bITC3
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
            this.cmbBoxFrom = new System.Windows.Forms.ComboBox();
            this.btnNewDict = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbBoxTo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrnslt = new System.Windows.Forms.Button();
            this.txtWordInp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbBoxFrom
            // 
            this.cmbBoxFrom.FormattingEnabled = true;
            this.cmbBoxFrom.Location = new System.Drawing.Point(12, 52);
            this.cmbBoxFrom.Name = "cmbBoxFrom";
            this.cmbBoxFrom.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxFrom.TabIndex = 0;
            this.cmbBoxFrom.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnNewDict
            // 
            this.btnNewDict.Location = new System.Drawing.Point(562, 52);
            this.btnNewDict.Name = "btnNewDict";
            this.btnNewDict.Size = new System.Drawing.Size(115, 37);
            this.btnNewDict.TabIndex = 1;
            this.btnNewDict.Text = "OpenNew";
            this.btnNewDict.UseVisualStyleBackColor = true;
            this.btnNewDict.Click += new System.EventHandler(this.btnNewDict_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "addLng";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 3;
            this.button2.Text = "addWord";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbBoxTo
            // 
            this.cmbBoxTo.FormattingEnabled = true;
            this.cmbBoxTo.Location = new System.Drawing.Point(203, 52);
            this.cmbBoxTo.Name = "cmbBoxTo";
            this.cmbBoxTo.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxTo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose pair of langueges";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input word";
            // 
            // btnTrnslt
            // 
            this.btnTrnslt.Location = new System.Drawing.Point(120, 201);
            this.btnTrnslt.Name = "btnTrnslt";
            this.btnTrnslt.Size = new System.Drawing.Size(115, 37);
            this.btnTrnslt.TabIndex = 8;
            this.btnTrnslt.Text = "Translation";
            this.btnTrnslt.UseVisualStyleBackColor = true;
            // 
            // txtWordInp
            // 
            this.txtWordInp.Location = new System.Drawing.Point(15, 159);
            this.txtWordInp.Name = "txtWordInp";
            this.txtWordInp.Size = new System.Drawing.Size(220, 22);
            this.txtWordInp.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 305);
            this.Controls.Add(this.txtWordInp);
            this.Controls.Add(this.btnTrnslt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxTo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNewDict);
            this.Controls.Add(this.cmbBoxFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBoxFrom;
        private System.Windows.Forms.Button btnNewDict;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbBoxTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrnslt;
        private System.Windows.Forms.TextBox txtWordInp;
    }
}

