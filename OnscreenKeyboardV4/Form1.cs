using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnscreenKeyboardV4
{
    public partial class Form1 : Form
    {
        int tick_count = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Alphanumeric Keys
        //Each button sends two values to the SendKey function, one small and one capital.
        private void buttonA_Click(object sender, EventArgs e)
        {
            SystemSounds.Asterisk.Play();
            String capital ="A";
            String small ="a";
            SendKey(capital,small,buttonA);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            String capital = "B";
            String small = "b";
            SendKey(capital, small, buttonB);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            String capital = "C";
            String small = "c";
            SendKey(capital, small, buttonC);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            String capital = "D";
            String small = "d";
            SendKey(capital, small, buttonD);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            String capital = "E";
            String small = "e";
            SendKey(capital, small, buttonE);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            String capital = "F";
            String small = "f";
            SendKey(capital, small, buttonF);
        }
        private void buttonG_Click(object sender, EventArgs e)
        {
            String capital = "G";
            String small = "g";
            SendKey(capital, small, buttonG);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            String capital = "H";
            String small = "h";
            SendKey(capital, small, buttonH);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            String capital = "I";
            String small = "i";
            SendKey(capital, small, buttonI);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            String capital = "J";
            String small = "j";
            SendKey(capital, small, buttonJ);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            String capital = "K";
            String small = "k";
            SendKey(capital, small, buttonK);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            String capital = "L";
            String small = "l";
            SendKey(capital, small, buttonL);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            String capital = "M";
            String small = "m";
            SendKey(capital, small, buttonM);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            String capital = "N";
            String small = "n";
            SendKey(capital, small, buttonN);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            String capital = "O";
            String small = "o";
            SendKey(capital, small, buttonO);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            String capital = "P";
            String small = "p";
            SendKey(capital, small, buttonP);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            String capital = "q";
            String small = "q";
            SendKey(capital, small, buttonQ);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            String capital = "R";
            String small = "r";
            SendKey(capital, small, buttonR);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            String capital = "S";
            String small = "s";
            SendKey(capital, small, buttonS);
        }
        private void buttonT_Click(object sender, EventArgs e)
        {
            String capital = "T";
            String small = "t";
            SendKey(capital, small, buttonT);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            String capital = "U";
            String small = "u";
            SendKey(capital, small, buttonU);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            String capital = "V";
            String small = "v";
            SendKey(capital, small, buttonV);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            String capital = "W";
            String small = "w";
            SendKey(capital, small, buttonW);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            String capital = "X";
            String small = "x";
            SendKey(capital, small, buttonX);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            String capital = "Y";
            String small = "y";
            SendKey(capital, small, buttonY);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            String capital = "Z";
            String small = "z";
            SendKey(capital, small, buttonZ);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String capital = "1";
            String small = "1";
            SendKey(capital, small, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String capital = "2";
            String small = "2";
            SendKey(capital, small, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String capital = "3";
            String small = "3";
            SendKey(capital, small, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String capital = "4";
            String small = "4";
            SendKey(capital, small, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String capital = "5";
            String small = "5";
            SendKey(capital, small, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String capital = "6";
            String small = "6";
            SendKey(capital, small, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            String capital = "7";
            String small = "7";
            SendKey(capital, small, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            String capital = "8";
            String small = "8";
            SendKey(capital, small, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String capital = "9";
            String small = "9";
            SendKey(capital, small, button9);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            String capital = "0";
            String small = "0";
            SendKey(capital, small, button0);
        }

        #endregion

        #region Punctuation and Formatting Keys
        private void checkBoxCaps_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            String capital = "{ENTER}";
            String small = "{ENTER}";
            SendKey(capital, small, buttonEnter);
        }

        private void ButtonSpace_Click(object sender, EventArgs e)
        {
            String capital = " ";
            String small = " ";
            SendKey(capital, small, buttonSpace);
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            String capital = "{BACKSPACE}";
            String small = "{BACKSPACE}";
            SendKey(capital, small, buttonBackspace);
        }

        private void buttonBackslash_Click(object sender, EventArgs e)
        {
            String capital = "/";
            String small = "/";
            SendKey(capital, small, buttonBackslash);
        }

        private void buttonSemicolon_Click(object sender, EventArgs e)
        {
            String capital = ";";
            String small = ";";
            SendKey(capital, small, buttonSemicolon);
        }

        private void buttonExclaim_Click(object sender, EventArgs e)
        {
            String capital = "!";
            String small = "!";
            SendKey(capital, small, buttonExclaim);
        }

        private void buttonColon_Click(object sender, EventArgs e)
        {
            String capital = ":";
            String small = ":";
            SendKey(capital, small, buttonColon);
        }

        private void buttonSlash_Click(object sender, EventArgs e)
        {
            String capital = "/";
            String small = "/";
            SendKey(capital, small, buttonSlash);
        }

        private void buttonQuest_Click(object sender, EventArgs e)
        {
            String capital = "?";
            String small = "?";
            SendKey(capital, small, buttonQuest);
        }

        private void buttonComma_Click(object sender, EventArgs e)
        {
            String capital = ",";
            String small = ",";
            SendKey(capital, small, buttonComma);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            String capital = ".";
            String small = ".";
            SendKey(capital, small, buttonStop);
        }

        #endregion

        #region Input/ SendKey function
        private void SendKey(string capital, string small,Button ReturnFocus)
        {
            //this function sends a keystroke to the textbox
            this.richTextBox1.Focus();
            if (checkBoxCaps.Checked)
                SendKeys.SendWait(capital);

            else
                SendKeys.SendWait(small);

            ReturnFocus.Focus();
        }

#endregion

        #region Click automation
        //These functions start a timer which triggers a click on the focussed key after a set duration, then returns focus.6
        private void timer1_Tick(object sender, EventArgs e)
        {
            //tick_count=tick_count++;
            timer1.Stop();
        }

        private void buttonA_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonA.Focus() == true) {
                timer1.Tick += new EventHandler(buttonA_Click);
            }
            //timer1.Tick += new EventHandler(buttonA_Click); //new EventHandler(timer1_Tick);
            /*while (tick_count > 1)
                buttonA.PerformClick();
                tick_count = 0;*/
        }

        private void buttonA_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonB_Enter(object sender, EventArgs e)
        {
            timer1.Start();

            if (buttonB.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonB_Click);
            }
        }

        private void buttonB_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonC_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonC.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonC_Click);
            }
        }

        private void buttonC_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonD_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonD.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonD_Click);
            }
        }

        private void buttonD_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonE_Enter(object sender, EventArgs e)
        {
            timer1.Start(); if (buttonE.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonE_Click);
            }
        }

        private void buttonE_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonF_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonF.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonF_Click);
            }
        }

        private void buttonF_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonG_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonG.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonG_Click);
            }
        }

        private void buttonG_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonH_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonH.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonH_Click);
            }
        }

        private void buttonH_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonI_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonI.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonI_Click);
            }
        }

        private void buttonI_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonJ_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonJ.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonJ_Click);
            }
        }

        private void buttonJ_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonK_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonK.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonK_Click);
            }
        }

        private void buttonK_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonL_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonL.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonL_Click);
            }
        }

        private void buttonL_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonM_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonM.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonM_Click);
            }
        }

        private void buttonM_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonN_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonN.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonN_Click);
            }
        }

        private void buttonN_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonO_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonO.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonO_Click);
            }
        }

        private void buttonO_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonP_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonP.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonP_Click);
            }
        }

        private void buttonP_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonQ_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonQ.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonQ_Click);
            }
        }

        private void buttonQ_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonR_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonR.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonR_Click);
            }
        }

        private void buttonR_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonS_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonS.Focus() == true)
            {
                timer1.Tick += new EventHandler(button20_Click); //An error in naming led to buttonS instead being named button20
            }
        }

        private void buttonS_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonT_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonT.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonT_Click);
            }
        }

        private void buttonT_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonU_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonU.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonU_Click);
            }
        }

        private void buttonU_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonV_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(buttonV_Click);
        }

        private void buttonV_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonW_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonW.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonW_Click);
            }
        }

        private void buttonW_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonX_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonX.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonX_Click);
            }
        }

        private void buttonX_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonY_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonY.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonY_Click);
            }
        }

        private void buttonY_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonZ_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonZ.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonZ_Click);
            }
        }

        private void buttonZ_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button1.Focus() == true)
            {
                timer1.Tick += new EventHandler(button1_Click);
            }
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button2.Focus() == true)
            {
                timer1.Tick += new EventHandler(button2_Click);
            }
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button3.Focus() == true)
            {
                timer1.Tick += new EventHandler(button3_Click);
            }
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button4_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button4.Focus() == true)
            {
                timer1.Tick += new EventHandler(button4_Click);
            }
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button5_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button5.Focus() == true)
            {
                timer1.Tick += new EventHandler(button5_Click);
            }
        }

        private void button5_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button6_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button6.Focus() == true)
            {
                timer1.Tick += new EventHandler(button6_Click);
            }
        }

        private void button6_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button7_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button7.Focus() == true)
            {
                timer1.Tick += new EventHandler(button7_Click);
            }
        }

        private void button7_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button8_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button8.Focus() == true)
            {
                timer1.Tick += new EventHandler(button8_Click);
            }
        }

        private void button8_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button9_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button9.Focus() == true)
            {
                timer1.Tick += new EventHandler(button9_Click);
            }
        }

        private void button9_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button0_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (button0.Focus() == true)
            {
                timer1.Tick += new EventHandler(button0_Click);
            }
        }

        private void button0_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void checkBoxCaps_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(checkBoxCaps_CheckedChanged);
        }

        private void checkBoxCaps_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonEnter_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonEnter.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonEnter_Click);
            }
        }

        private void buttonEnter_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void ButtonSpace_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonSpace.Focus() == true)
            {
                timer1.Tick += new EventHandler(ButtonSpace_Click);
            }
        }

        private void ButtonSpace_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonBackspace_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonBackspace.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonBackspace_Click);
            }
        }

        private void buttonBackspace_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonStop_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonStop.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonStop_Click);
            }
        }

        private void buttonStop_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonComma_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonComma.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonComma_Click);
            }
        }

        private void buttonComma_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonQuest_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonQuest.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonQuest_Click);
            }
        }

        private void buttonQuest_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonBackslash_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonBackslash.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonBackslash_Click);
            }
        }

        private void buttonBackslash_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonSemicolon_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonSemicolon.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonSemicolon_Click);
            }
        }

        private void buttonSemicolon_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonExclaim_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonExclaim.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonExclaim_Click);
            }
        }

        private void buttonExclaim_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonColon_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonColon.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonColon_Click);
            }
        }

        private void buttonColon_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void buttonSlash_Enter(object sender, EventArgs e)
        {
            timer1.Start();
            if (buttonSlash.Focus() == true)
            {
                timer1.Tick += new EventHandler(buttonSlash_Click);
            }
        }

        private void buttonSlash_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        #endregion

        #region Clear the Textbox
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text= string.Empty;
        }

        #endregion

        #region Copy all the text in the textbox
        private void buttonCopy_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text.CopyTo
        }

        #endregion

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
