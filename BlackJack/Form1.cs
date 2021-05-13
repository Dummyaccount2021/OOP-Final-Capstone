using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class frmBlackJackGame : Form
    {
        public frmBlackJackGame()
        {
            InitializeComponent();
        }

        private void frmBlackJackGame_Load(object sender, EventArgs e)
        {
          
            grpOptions.Location = new Point(420, 350);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void grpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void optOne_CheckedChanged(object sender, EventArgs e)
        {    
            grpPlayerOne.Enabled = true;
            grpDealer.Enabled = true;
            grpOptions.Enabled = false;
            
        }

        private void optTwo_CheckedChanged(object sender, EventArgs e)
        {
            
            grpPlayer2.Enabled = true;
            grpDealer.Enabled = true;
            grpOptions.Enabled = false;
        }

        private void optThree_CheckedChanged(object sender, EventArgs e)
        {
            
            grpPlayer3.Enabled = true;
            grpDealer.Enabled = true;
            grpOptions.Enabled = false;
        }

        private void optFour_CheckedChanged(object sender, EventArgs e)
        {
            
            grpPlayer4.Enabled = true;
            grpDealer.Enabled = true;
            grpOptions.Enabled = false;
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
          
        }

        private void grpDealer_Enter(object sender, EventArgs e)
        {

        }

        private void optAll_CheckedChanged(object sender, EventArgs e)
        {
            grpPlayerOne.Enabled = true;
            grpPlayer2.Enabled = true;
            grpPlayer3.Enabled = true;
            grpPlayer4.Enabled = true;
            grpDealer.Enabled = true;
            grpOptions.Enabled = false;
        }
    }
}
