namespace Ass2C
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
            this.rtbOut = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbarRoundA = new System.Windows.Forms.ProgressBar();
            this.pbarPriorityA = new System.Windows.Forms.ProgressBar();
            this.pbarMultiA = new System.Windows.Forms.ProgressBar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.pbarRoundC = new System.Windows.Forms.ProgressBar();
            this.pbarRoundB = new System.Windows.Forms.ProgressBar();
            this.pbarPriorityC = new System.Windows.Forms.ProgressBar();
            this.pbarPriorityB = new System.Windows.Forms.ProgressBar();
            this.pbarMultiC = new System.Windows.Forms.ProgressBar();
            this.pbarMultiB = new System.Windows.Forms.ProgressBar();
            this.btnRound = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lbxThread = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbOut
            // 
            this.rtbOut.BackColor = System.Drawing.Color.DimGray;
            this.rtbOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rtbOut.Location = new System.Drawing.Point(12, 12);
            this.rtbOut.Name = "rtbOut";
            this.rtbOut.Size = new System.Drawing.Size(217, 249);
            this.rtbOut.TabIndex = 0;
            this.rtbOut.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Round Robin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Multiple Queue";
            // 
            // pbarRoundA
            // 
            this.pbarRoundA.Location = new System.Drawing.Point(347, 25);
            this.pbarRoundA.Name = "pbarRoundA";
            this.pbarRoundA.Size = new System.Drawing.Size(100, 23);
            this.pbarRoundA.TabIndex = 4;
            // 
            // pbarPriorityA
            // 
            this.pbarPriorityA.Location = new System.Drawing.Point(347, 120);
            this.pbarPriorityA.Name = "pbarPriorityA";
            this.pbarPriorityA.Size = new System.Drawing.Size(100, 23);
            this.pbarPriorityA.TabIndex = 5;
            // 
            // pbarMultiA
            // 
            this.pbarMultiA.Location = new System.Drawing.Point(347, 218);
            this.pbarMultiA.Name = "pbarMultiA";
            this.pbarMultiA.Size = new System.Drawing.Size(100, 23);
            this.pbarMultiA.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(40, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // nudAmount
            // 
            this.nudAmount.Location = new System.Drawing.Point(153, 342);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(120, 20);
            this.nudAmount.TabIndex = 8;
            // 
            // pbarRoundC
            // 
            this.pbarRoundC.Location = new System.Drawing.Point(347, 83);
            this.pbarRoundC.Name = "pbarRoundC";
            this.pbarRoundC.Size = new System.Drawing.Size(100, 23);
            this.pbarRoundC.TabIndex = 10;
            // 
            // pbarRoundB
            // 
            this.pbarRoundB.Location = new System.Drawing.Point(347, 54);
            this.pbarRoundB.Name = "pbarRoundB";
            this.pbarRoundB.Size = new System.Drawing.Size(100, 23);
            this.pbarRoundB.TabIndex = 11;
            this.pbarRoundB.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // pbarPriorityC
            // 
            this.pbarPriorityC.Location = new System.Drawing.Point(347, 178);
            this.pbarPriorityC.Name = "pbarPriorityC";
            this.pbarPriorityC.Size = new System.Drawing.Size(100, 23);
            this.pbarPriorityC.TabIndex = 12;
            // 
            // pbarPriorityB
            // 
            this.pbarPriorityB.Location = new System.Drawing.Point(347, 149);
            this.pbarPriorityB.Name = "pbarPriorityB";
            this.pbarPriorityB.Size = new System.Drawing.Size(100, 23);
            this.pbarPriorityB.TabIndex = 13;
            // 
            // pbarMultiC
            // 
            this.pbarMultiC.Location = new System.Drawing.Point(347, 276);
            this.pbarMultiC.Name = "pbarMultiC";
            this.pbarMultiC.Size = new System.Drawing.Size(100, 23);
            this.pbarMultiC.TabIndex = 14;
            // 
            // pbarMultiB
            // 
            this.pbarMultiB.Location = new System.Drawing.Point(347, 247);
            this.pbarMultiB.Name = "pbarMultiB";
            this.pbarMultiB.Size = new System.Drawing.Size(100, 23);
            this.pbarMultiB.TabIndex = 15;
            // 
            // btnRound
            // 
            this.btnRound.BackColor = System.Drawing.SystemColors.Control;
            this.btnRound.ForeColor = System.Drawing.Color.Black;
            this.btnRound.Location = new System.Drawing.Point(12, 295);
            this.btnRound.Name = "btnRound";
            this.btnRound.Size = new System.Drawing.Size(86, 23);
            this.btnRound.TabIndex = 16;
            this.btnRound.Text = "Round Robin";
            this.btnRound.UseVisualStyleBackColor = false;
            this.btnRound.Click += new System.EventHandler(this.BtnRound_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.ForeColor = System.Drawing.Color.Black;
            this.btnPriority.Location = new System.Drawing.Point(104, 295);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(75, 23);
            this.btnPriority.TabIndex = 17;
            this.btnPriority.Text = "Priority";
            this.btnPriority.UseVisualStyleBackColor = true;
            this.btnPriority.Click += new System.EventHandler(this.BtnPriority_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.ForeColor = System.Drawing.Color.Black;
            this.btnMulti.Location = new System.Drawing.Point(185, 295);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 18;
            this.btnMulti.Text = "Multi Queue";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // lbxThread
            // 
            this.lbxThread.FormattingEnabled = true;
            this.lbxThread.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lbxThread.Location = new System.Drawing.Point(310, 332);
            this.lbxThread.Name = "lbxThread";
            this.lbxThread.Size = new System.Drawing.Size(120, 30);
            this.lbxThread.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "B";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "C";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(327, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(327, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "C";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(459, 370);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxThread);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnPriority);
            this.Controls.Add(this.btnRound);
            this.Controls.Add(this.pbarMultiB);
            this.Controls.Add(this.pbarMultiC);
            this.Controls.Add(this.pbarPriorityB);
            this.Controls.Add(this.pbarPriorityC);
            this.Controls.Add(this.pbarRoundB);
            this.Controls.Add(this.pbarRoundC);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pbarMultiA);
            this.Controls.Add(this.pbarPriorityA);
            this.Controls.Add(this.pbarRoundA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbOut);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pbarRoundA;
        private System.Windows.Forms.ProgressBar pbarPriorityA;
        private System.Windows.Forms.ProgressBar pbarMultiA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.ProgressBar pbarRoundC;
        private System.Windows.Forms.ProgressBar pbarRoundB;
        private System.Windows.Forms.ProgressBar pbarPriorityC;
        private System.Windows.Forms.ProgressBar pbarPriorityB;
        private System.Windows.Forms.ProgressBar pbarMultiC;
        private System.Windows.Forms.ProgressBar pbarMultiB;
        private System.Windows.Forms.Button btnRound;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.ListBox lbxThread;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

