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
        private bool run;
        private int numRuns;
        private int currRunNum;

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
            throw new Exception("The method or operation is not implemented.");
        }

        /// <summary>
        /// Unlocks the UI so the users can change params and rerun
        /// </summary>
        private void unlockUI()
        {
            throw new Exception("The method or operation is not implemented.");
        }


        /// <summary>
        /// Will cause the process to be stopped after the current run
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {

            run = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            throw new Exception("The method or operation is not implemented.");
            unlockUI();
            //clear display boxes
            //clear run counts
            //clear bestOf variables
        }




        

    }
}