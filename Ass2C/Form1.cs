using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] processLengthsPriority = { 800, 750, 850 };
        int[] processLengthsMulti = { 600, 800, 750 };
        int[] processLengthsRound = { 900, 750, 800 };
        int[] processPriority = { 2, 1, 0 };

        int quantum = 5;
        int currentRound = 0;
        int currentPriority = 0;
        int currentMulti = 0;

        string[] processNames = { "A", "B", "C"};

        public void priority(int[] priority)
        {
            int highest = 0;
            for (int i = 0; i < priority.Length; i++)
            {
                if (priority[i] > highest)
                {
                    highest = priority[i];
                    currentPriority = i;
                }
            }
            processPriority[currentPriority]--;
            Random rnd = new Random();
            int temp = rnd.Next(1, 4);
            switch (temp)
            {
                case 1:
                    processPriority[0]++;
                    break;
                case 2:
                    processPriority[1]++;
                    break;
                case 3:
                    processPriority[2]++;
                    break;
            }
        }

        public void round(int[] lengths, string[] names)
        {
            int tempRound = currentRound;

            switch (tempRound)
            {
                case 0: currentRound = 1;
                    break;
                case 1: currentRound = 2;
                    break;
                case 2: currentRound = 0;
                    break;
            }

        }

        public void multi(int[] priority)
        {
            int highest = 0;
            for (int i = 0; i < priority.Length; i++)
            {
                if (priority[i] > highest)
                {
                    highest = priority[i];
                    currentMulti = i;
                }
            }
            processPriority[currentMulti]--;
            Random rnd = new Random();
            int temp = rnd.Next(1, 4);
            switch (temp)
            {
                case 1:
                    processPriority[0]++;
                    break;
                case 2:
                    processPriority[1]++;
                    break;
                case 3:
                    processPriority[2]++;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbarPriorityA.Step = 1;
            pbarPriorityA.Maximum = processLengthsPriority[0];
            pbarRoundA.Step = 1;
            pbarRoundA.Maximum = processLengthsRound[0];
            pbarMultiA.Step = 1;
            pbarMultiA.Maximum = processLengthsMulti[0];

            pbarPriorityB.Step = 1;
            pbarPriorityB.Maximum = processLengthsPriority[1];
            pbarRoundB.Step = 1;
            pbarRoundB.Maximum = processLengthsRound[1];
            pbarMultiB.Step = 1;
            pbarMultiB.Maximum = processLengthsMulti[1];

            pbarPriorityC.Step = 1;
            pbarPriorityC.Maximum = processLengthsPriority[2];
            pbarRoundC.Step = 1;
            pbarRoundC.Maximum = processLengthsRound[2];
            pbarMultiC.Step = 1;
            pbarMultiC.Maximum = processLengthsMulti[2];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lbxThread.SelectedIndex.ToString() == "-1")
                MessageBox.Show("Please select a thread to add to");
            else if(lbxThread.SelectedIndex.ToString() == "0")
            {
                processLengthsPriority[0] += (int)nudAmount.Value;
                processLengthsMulti[0] += (int)nudAmount.Value;
                processLengthsRound[0] += (int)nudAmount.Value;
            }
            else if (lbxThread.SelectedIndex.ToString() == "1")
            {

                processLengthsPriority[1] += (int)nudAmount.Value;
                processLengthsMulti[1] += (int)nudAmount.Value;
                processLengthsRound[1] += (int)nudAmount.Value;
            }
            else
            {
                processLengthsPriority[2] += (int)nudAmount.Value;
                processLengthsMulti[2] += (int)nudAmount.Value;
                processLengthsRound[2] += (int)nudAmount.Value;
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void BtnPriority_Click(object sender, EventArgs e)
        {
            int cur = 0;
            int totalProcesses = 0;

            for (int i = 0; i < processLengthsPriority.Length; i++)
            {
                if (processLengthsPriority[i] >= 0)
                {
                    totalProcesses += processLengthsPriority[i];
                }
            }

            while (cur < totalProcesses)
            {
                priority(processPriority);
                switch (currentPriority)
                {
                    case 0:
                        if (processLengthsPriority[0] > 0)
                        {
                            pbarPriorityA.PerformStep();
                            processLengthsPriority[0]--;
                            rtbOut.AppendText(processNames[0] + processLengthsPriority[0]);
                            cur++;
                        }
                        break;
                    case 1:
                        if (processLengthsPriority[1] > 0)
                        {
                            pbarPriorityB.PerformStep();
                            processLengthsPriority[1]--;
                            rtbOut.AppendText(processNames[1] + processLengthsPriority[1]);
                            cur++;
                        }
                        break;
                    case 2:
                        if (processLengthsPriority[2] > 0)
                        {
                            pbarPriorityC.PerformStep();
                            processLengthsPriority[2]--;
                            rtbOut.AppendText(processNames[2] + processLengthsPriority[2]);
                            cur++;
                        }
                        break;
                }
            }
        }

        private void BtnRound_Click(object sender, EventArgs e)
        {
            int cur = 0;
            int totalProcesses = 0;

            for (int i = 0; i < processLengthsRound.Length; i++)
            {
                if (processLengthsRound[i] >= 0)
                {
                    totalProcesses += processLengthsRound[i];
                }
            }

            while (cur < totalProcesses)
            {
                switch (currentRound)
                {
                    case 0:
                        if(processLengthsRound[0] > 0)
                        {
                            for (int i = 0; i < quantum; i++)
                            {
                                pbarRoundA.PerformStep();
                                processLengthsRound[0]--;
                                rtbOut.AppendText(processNames[0] + processLengthsRound[0]);
                                cur++;
                            }
                        }
                        break;
                    case 1:
                        if (processLengthsRound[1] > 0)
                        {
                            for (int i = 0; i < quantum; i++)
                            {
                                pbarRoundB.PerformStep();
                                processLengthsRound[1]--;
                                rtbOut.AppendText(processNames[1] + processLengthsRound[1]);
                                cur++;
                            }
                        }   
                        break;
                    case 2:
                        if (processLengthsRound[2] > 0)
                        {
                            for (int i = 0; i < quantum; i++)
                            {
                                pbarRoundC.PerformStep();
                                processLengthsRound[2]--;
                                rtbOut.AppendText(processNames[2] + processLengthsRound[2]);
                                cur++;
                            }
                        }    
                        break;
                }
                round(processLengthsPriority, processNames);
            }
        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            int cur = 0;
            int totalProcesses = 0;

            for (int i = 0; i < processLengthsMulti.Length; i++)
            {
                if (processLengthsMulti[i] >= 0)
                {
                    totalProcesses += processLengthsRound[i];
                }
            }

            while (cur < totalProcesses)
            {
                multi(processPriority);
                switch (currentMulti)
                {
                    case 0:
                        if (processLengthsMulti[0] > 0)
                        {
                            for (int i = 0; i < processLengthsMulti[0]; i++)
                            {
                                pbarMultiA.PerformStep();
                                processLengthsMulti[0]--;
                                rtbOut.AppendText(processNames[0] + processLengthsMulti[0]);
                                cur++; }
                        }
                        break;
                    case 1:
                        if (processLengthsMulti[1] > 0)
                        {
                            for (int i = 0; i < processLengthsMulti[1]; i++)
                            {
                                pbarMultiB.PerformStep();
                                processLengthsMulti[1]--;
                                rtbOut.AppendText(processNames[1] + processLengthsMulti[1]);
                                cur++;
                            }
                        }
                        break;
                    case 2:
                        if (processLengthsMulti[2] > 0)
                        {
                            for (int i = 0; i < processLengthsMulti[2]; i++)
                            {
                                pbarMultiC.PerformStep();
                                processLengthsMulti[2]--;
                                rtbOut.AppendText(processNames[2] + processLengthsMulti[2]);
                                cur++;
                            }
                        }
                        break;
                }
            }
        }
    }
}
