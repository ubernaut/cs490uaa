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
        private int numRuns;


        //other vars
        private bool run;
        private int currRunNum;


        //history vars
        private Individual currRun;
        private List<Individual> allRuns;

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            lockUI();

            run = true;

            //repeat numRuns times
            while (run == true && currRunNum < numRuns)
            {
                //@todo: initialize the ES for the current run with proper params
                ES myEs = new ES();

                while (run == true && myEs.CurrentGen < myEs.TermCount)
                {
                    myEs.RunOneGen();

                    //display best of the last generation
                    //in textBoxCurrRun

                    //

                    myEs.CurrentGen++;
                }



                currRunNum++;
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
            throw new Exception("The method or operation is not implemented.");
            unlockUI();
            //clear display boxes
            //clear run counts / progress bar
            //clear bestOf variables
        }

        private void buttonRunOne_Click(object sender, EventArgs e)
        {
            lockUI();
            ES myEs = new ES();


        }



        private void GetInputParams()
        {
            mu = Int32.Parse(textBoxMu.Text);
            lambda = Int32.Parse(textBoxLambda.Text);
            sigmaInit = Int32.Parse(textBoxSigInit.Text);
            termCount = Int32.Parse(textBoxTermCount.Text);
            numRuns = Int32.Parse(textBoxNumRuns.Text);

        }


    }
}