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
            //grp location changes on runtime
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //application exits when clicked
        }

        private void grpOptions_Enter(object sender, EventArgs e)
        {

        }

        private void optOne_CheckedChanged(object sender, EventArgs e)
        {
            //enable player one grp
            //enable dealers grp
            //disable grpOptions
        }

        private void optTwo_CheckedChanged(object sender, EventArgs e)
        {
            //enable player two grp
            //enable dealers grp
            //disable grpOptions
        }

        private void optThree_CheckedChanged(object sender, EventArgs e)
        {
            //enable player three grp
            //enable dealers grp
            //disable grpOptions
        }

        private void optFour_CheckedChanged(object sender, EventArgs e)
        {
            //enable player four grp
            //enable dealers grp
            //disable grpOptions
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            //current player value is save
            //moves onto next player
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //continue dealing card to current player
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //resets the entire application
        }
    }
}
