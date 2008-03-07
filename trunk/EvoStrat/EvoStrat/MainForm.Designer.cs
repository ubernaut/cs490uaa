namespace EvoStrat
{
    partial class MainForm
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
            this.textBoxMu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLambda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSigInit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTermCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumRuns = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCurrRun = new System.Windows.Forms.TextBox();
            this.textBoxAllRuns = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRunOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMu
            // 
            this.textBoxMu.Location = new System.Drawing.Point(148, 26);
            this.textBoxMu.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMu.Name = "textBoxMu";
            this.textBoxMu.Size = new System.Drawing.Size(60, 22);
            this.textBoxMu.TabIndex = 0;
            this.textBoxMu.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lambda";
            // 
            // textBoxLambda
            // 
            this.textBoxLambda.Location = new System.Drawing.Point(148, 58);
            this.textBoxLambda.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLambda.Name = "textBoxLambda";
            this.textBoxLambda.Size = new System.Drawing.Size(60, 22);
            this.textBoxLambda.TabIndex = 2;
            this.textBoxLambda.Text = "21";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sigma Initial";
            // 
            // textBoxSigInit
            // 
            this.textBoxSigInit.Location = new System.Drawing.Point(148, 90);
            this.textBoxSigInit.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSigInit.Name = "textBoxSigInit";
            this.textBoxSigInit.Size = new System.Drawing.Size(60, 22);
            this.textBoxSigInit.TabIndex = 4;
            this.textBoxSigInit.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Termination Count";
            // 
            // textBoxTermCount
            // 
            this.textBoxTermCount.Location = new System.Drawing.Point(148, 122);
            this.textBoxTermCount.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTermCount.Name = "textBoxTermCount";
            this.textBoxTermCount.Size = new System.Drawing.Size(60, 22);
            this.textBoxTermCount.TabIndex = 6;
            this.textBoxTermCount.Text = "200000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Runs";
            // 
            // textBoxNumRuns
            // 
            this.textBoxNumRuns.Location = new System.Drawing.Point(148, 154);
            this.textBoxNumRuns.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumRuns.Name = "textBoxNumRuns";
            this.textBoxNumRuns.Size = new System.Drawing.Size(60, 22);
            this.textBoxNumRuns.TabIndex = 8;
            this.textBoxNumRuns.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Current Run";
            // 
            // textBoxCurrRun
            // 
            this.textBoxCurrRun.Location = new System.Drawing.Point(284, 26);
            this.textBoxCurrRun.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCurrRun.Name = "textBoxCurrRun";
            this.textBoxCurrRun.Size = new System.Drawing.Size(593, 22);
            this.textBoxCurrRun.TabIndex = 11;
            // 
            // textBoxAllRuns
            // 
            this.textBoxAllRuns.Location = new System.Drawing.Point(284, 90);
            this.textBoxAllRuns.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAllRuns.Multiline = true;
            this.textBoxAllRuns.Name = "textBoxAllRuns";
            this.textBoxAllRuns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAllRuns.Size = new System.Drawing.Size(593, 201);
            this.textBoxAllRuns.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "All Runs";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(21, 321);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(61, 28);
            this.buttonStart.TabIndex = 14;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(91, 321);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(4);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 28);
            this.buttonStop.TabIndex = 15;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(284, 321);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(595, 28);
            this.progressBar1.TabIndex = 16;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(199, 321);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(64, 28);
            this.buttonReset.TabIndex = 17;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRunOne
            // 
            this.buttonRunOne.Location = new System.Drawing.Point(21, 286);
            this.buttonRunOne.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunOne.Name = "buttonRunOne";
            this.buttonRunOne.Size = new System.Drawing.Size(133, 28);
            this.buttonRunOne.TabIndex = 18;
            this.buttonRunOne.Text = "Run One Gen";
            this.buttonRunOne.UseVisualStyleBackColor = true;
            this.buttonRunOne.Click += new System.EventHandler(this.buttonRunOne_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 367);
            this.Controls.Add(this.buttonRunOne);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxAllRuns);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCurrRun);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNumRuns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTermCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSigInit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLambda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "EvoStrat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLambda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSigInit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTermCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumRuns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCurrRun;
        private System.Windows.Forms.TextBox textBoxAllRuns;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRunOne;
    }
}

