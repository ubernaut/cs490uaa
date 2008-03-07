using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoStrat
{
    public partial class MainForm : Form
    {
        //input params
        private int mu;
        private int lambda;
        private double sigmaInit;
        private int termCount;
        private int maxRuns;
        private ES myEs;
        private String textForallRunBox;
        //other vars
        private bool run;
        private int currRunNum;


        //history vars
        private Individual currentGenBest;
        private List<Individual> allRunBests;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            lockUI();


            run = true;
            textForallRunBox = "";
            GetInputParams();
            
            progressBar1.Maximum = termCount;
            progressBar2.Maximum = maxRuns;
            Individual bestHolder = new Individual();
            //repeat numRuns times
            while (run == true && currRunNum < maxRuns)
            {

                myEs = new ES(mu, lambda, sigmaInit, termCount, 2);
                
                while (run == true && myEs.CurrentGen < myEs.TermCount)
                {
                    myEs.RunOneGen();

                    //display best of the last generation
                    //in textBoxCurrRun
                    currentGenBest = myEs.ChildList[0];
                    bestHolder = currentGenBest;
                    textBoxCurrRun.Text = currentGenBest.ToString();

                    progressBar1.Value = myEs.CurrentGen;
                    Application.DoEvents();
                }
                textForallRunBox += "Run: " + currRunNum.ToString() +"Best: "+ currentGenBest.ToString() + "\r\n";
                textBoxAllRuns.Clear();
                textBoxAllRuns.Text = textForallRunBox;
                currRunNum++;
                progressBar2.Value = currRunNum;
                Application.DoEvents();
            }





        }

        /// <summary>
        /// Locks the input boxes to users cant modify params mid run
        /// </summary>
        private void lockUI()
        {
            textBoxLambda.Enabled = false;
            textBoxNumRuns.Enabled = false;
            textBoxMu.Enabled = false;
            textBoxSigInit.Enabled = false;
            textBoxTermCount.Enabled = false;

        }

        /// <summary>
        /// Unlocks the UI so the users can change params and rerun
        /// </summary>
        private void unlockUI()
        {
            textBoxLambda.Enabled = true;
            textBoxNumRuns.Enabled = true;
            textBoxMu.Enabled = true;
            textBoxSigInit.Enabled = true;
            textBoxTermCount.Enabled = true;

        }


        /// <summary>
        /// Will cause the process to be stopped after the current run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            unlockUI();
            run = false;

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

            
           
            unlockUI();

            //clear display boxes
            textBoxLambda.Clear();
            textBoxNumRuns.Clear();
            textBoxMu.Clear();
            textBoxSigInit.Clear();
            textBoxTermCount.Clear();
            textBoxCurrRun.Clear();
            textBoxAllRuns.Clear();

            textBoxLambda.Text = "49";
            textBoxNumRuns.Text = "10";
            textBoxMu.Text ="7";
            textBoxSigInit.Text = "1";
            textBoxTermCount.Text = "2000";
            
            

            //clear run counts / progress bar

            currRunNum = 0;
            progressBar1.Value = 0;
            progressBar2.Value = 0;

            //clear bestOf variables
            currentGenBest = new Individual();
            allRunBests = new List<Individual>();

            myEs = null; 

        }

        private void buttonRunOne_Click(object sender, EventArgs e)
        {
            lockUI();
            if (myEs == null) 
            {
                GetInputParams();
                myEs = new ES(mu, lambda, sigmaInit, termCount, 2);
                

            }
            myEs.RunOneGen();
            currentGenBest = myEs.ChildList[0];

            textBoxCurrRun.Text = currentGenBest.ToString();

        }


    
        private void GetInputParams()
        {
            mu = Int32.Parse(textBoxMu.Text);
            lambda = Int32.Parse(textBoxLambda.Text);
            sigmaInit = double.Parse(textBoxSigInit.Text);
            termCount = Int32.Parse(textBoxTermCount.Text);
            maxRuns = Int32.Parse(textBoxNumRuns.Text);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetInputParams();
            myEs = new ES(mu, lambda, sigmaInit, termCount, 2);

        }


    }
}