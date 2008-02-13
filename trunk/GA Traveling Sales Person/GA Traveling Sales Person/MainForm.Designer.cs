namespace GA_Traveling_Sales_Person
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
            this.components = new System.ComponentModel.Container();
            this.textBoxPopSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxTownCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRandSeed = new System.Windows.Forms.TextBox();
            this.doRun = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bestTourLabel = new System.Windows.Forms.Label();
            this.bestFitnessLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxProbCO = new System.Windows.Forms.TextBox();
            this.textBoxProbMut = new System.Windows.Forms.TextBox();
            this.textBoxProbRep = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPopSize
            // 
            this.textBoxPopSize.Location = new System.Drawing.Point(111, 26);
            this.textBoxPopSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPopSize.Name = "textBoxPopSize";
            this.textBoxPopSize.Size = new System.Drawing.Size(76, 20);
            this.textBoxPopSize.TabIndex = 1;
            this.textBoxPopSize.Text = "200";
            this.textBoxPopSize.Validated += new System.EventHandler(this.textBox1_Validated);
            this.textBoxPopSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "population size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "max generation";
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(111, 57);
            this.textBoxMaxGen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(76, 20);
            this.textBoxMaxGen.TabIndex = 4;
            this.textBoxMaxGen.Text = "50";
            // 
            // textBoxTownCount
            // 
            this.textBoxTownCount.Location = new System.Drawing.Point(111, 80);
            this.textBoxTownCount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTownCount.Name = "textBoxTownCount";
            this.textBoxTownCount.Size = new System.Drawing.Size(76, 20);
            this.textBoxTownCount.TabIndex = 5;
            this.textBoxTownCount.Text = "5";
            this.textBoxTownCount.Validated += new System.EventHandler(this.textBox3_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "city count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "random seed";
            // 
            // textBoxRandSeed
            // 
            this.textBoxRandSeed.Location = new System.Drawing.Point(111, 112);
            this.textBoxRandSeed.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxRandSeed.Name = "textBoxRandSeed";
            this.textBoxRandSeed.Size = new System.Drawing.Size(76, 20);
            this.textBoxRandSeed.TabIndex = 8;
            this.textBoxRandSeed.Text = "1337";
            this.textBoxRandSeed.Validated += new System.EventHandler(this.textBox4_Validated);
            // 
            // doRun
            // 
            this.doRun.Location = new System.Drawing.Point(131, 288);
            this.doRun.Margin = new System.Windows.Forms.Padding(2);
            this.doRun.Name = "doRun";
            this.doRun.Size = new System.Drawing.Size(56, 19);
            this.doRun.TabIndex = 10;
            this.doRun.Text = "GO!";
            this.doRun.UseVisualStyleBackColor = true;
            this.doRun.Click += new System.EventHandler(this.button1_Click);
            this.doRun.Validated += new System.EventHandler(this.button1_Validated);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cross Over Tests";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fitness:";
            // 
            // bestTourLabel
            // 
            this.bestTourLabel.AutoSize = true;
            this.bestTourLabel.Location = new System.Drawing.Point(56, 28);
            this.bestTourLabel.Name = "bestTourLabel";
            this.bestTourLabel.Size = new System.Drawing.Size(27, 13);
            this.bestTourLabel.TabIndex = 15;
            this.bestTourLabel.Text = "blah";
            // 
            // bestFitnessLabel
            // 
            this.bestFitnessLabel.AutoSize = true;
            this.bestFitnessLabel.Location = new System.Drawing.Point(56, 41);
            this.bestFitnessLabel.Name = "bestFitnessLabel";
            this.bestFitnessLabel.Size = new System.Drawing.Size(27, 13);
            this.bestFitnessLabel.TabIndex = 16;
            this.bestFitnessLabel.Text = "blah";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.bestFitnessLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.bestTourLabel);
            this.groupBox1.Location = new System.Drawing.Point(222, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 110);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Best of Run";
            // 
            // textBoxProbCO
            // 
            this.textBoxProbCO.Location = new System.Drawing.Point(111, 142);
            this.textBoxProbCO.Name = "textBoxProbCO";
            this.textBoxProbCO.Size = new System.Drawing.Size(76, 20);
            this.textBoxProbCO.TabIndex = 18;
            this.textBoxProbCO.Text = ".9";
            // 
            // textBoxProbMut
            // 
            this.textBoxProbMut.Location = new System.Drawing.Point(111, 169);
            this.textBoxProbMut.Name = "textBoxProbMut";
            this.textBoxProbMut.Size = new System.Drawing.Size(76, 20);
            this.textBoxProbMut.TabIndex = 19;
            this.textBoxProbMut.Text = ".03";
            // 
            // textBoxProbRep
            // 
            this.textBoxProbRep.Location = new System.Drawing.Point(111, 196);
            this.textBoxProbRep.Name = "textBoxProbRep";
            this.textBoxProbRep.Size = new System.Drawing.Size(76, 20);
            this.textBoxProbRep.TabIndex = 20;
            this.textBoxProbRep.Text = ".1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Pc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Pm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Pr";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 385);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxProbRep);
            this.Controls.Add(this.textBoxProbMut);
            this.Controls.Add(this.textBoxProbCO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.doRun);
            this.Controls.Add(this.textBoxRandSeed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTownCount);
            this.Controls.Add(this.textBoxMaxGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPopSize);
            this.Name = "MainForm";
            this.Text = "s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPopSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.TextBox textBoxTownCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxRandSeed;
        private System.Windows.Forms.Button doRun;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label bestFitnessLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bestTourLabel;
        private System.Windows.Forms.TextBox textBoxProbRep;
        private System.Windows.Forms.TextBox textBoxProbMut;
        private System.Windows.Forms.TextBox textBoxProbCO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;

    }
}

