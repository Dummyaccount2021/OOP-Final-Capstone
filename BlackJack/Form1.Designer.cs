
namespace BlackJack
{
    partial class frmBlackJackGame
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
            this.grpPlayerOne = new System.Windows.Forms.GroupBox();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.grpPlayer3 = new System.Windows.Forms.GroupBox();
            this.grpPlayer4 = new System.Windows.Forms.GroupBox();
            this.grpDealer = new System.Windows.Forms.GroupBox();
            this.lblBlackJack = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPlayer3 = new System.Windows.Forms.Label();
            this.lblPlayerFour = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblDealer = new System.Windows.Forms.Label();
            this.optOne = new System.Windows.Forms.RadioButton();
            this.optTwo = new System.Windows.Forms.RadioButton();
            this.optThree = new System.Windows.Forms.RadioButton();
            this.optFour = new System.Windows.Forms.RadioButton();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpPlayerOne.SuspendLayout();
            this.grpPlayer2.SuspendLayout();
            this.grpPlayer3.SuspendLayout();
            this.grpPlayer4.SuspendLayout();
            this.grpDealer.SuspendLayout();
            this.grpOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayerOne
            // 
            this.grpPlayerOne.Controls.Add(this.lblPlayerOne);
            this.grpPlayerOne.Enabled = false;
            this.grpPlayerOne.Location = new System.Drawing.Point(60, 146);
            this.grpPlayerOne.Name = "grpPlayerOne";
            this.grpPlayerOne.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpPlayerOne.Size = new System.Drawing.Size(225, 217);
            this.grpPlayerOne.TabIndex = 0;
            this.grpPlayerOne.TabStop = false;
            this.grpPlayerOne.Text = "Player 1";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblPlayerTwo);
            this.grpPlayer2.Enabled = false;
            this.grpPlayer2.Location = new System.Drawing.Point(59, 369);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(226, 249);
            this.grpPlayer2.TabIndex = 1;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // grpPlayer3
            // 
            this.grpPlayer3.Controls.Add(this.lblPlayer3);
            this.grpPlayer3.Enabled = false;
            this.grpPlayer3.Location = new System.Drawing.Point(736, 114);
            this.grpPlayer3.Name = "grpPlayer3";
            this.grpPlayer3.Size = new System.Drawing.Size(274, 244);
            this.grpPlayer3.TabIndex = 2;
            this.grpPlayer3.TabStop = false;
            this.grpPlayer3.Text = "Player 3";
            // 
            // grpPlayer4
            // 
            this.grpPlayer4.Controls.Add(this.lblPlayerFour);
            this.grpPlayer4.Enabled = false;
            this.grpPlayer4.Location = new System.Drawing.Point(736, 382);
            this.grpPlayer4.Name = "grpPlayer4";
            this.grpPlayer4.Size = new System.Drawing.Size(276, 273);
            this.grpPlayer4.TabIndex = 2;
            this.grpPlayer4.TabStop = false;
            this.grpPlayer4.Text = "Player 4";
            // 
            // grpDealer
            // 
            this.grpDealer.Controls.Add(this.lblDealer);
            this.grpDealer.Controls.Add(this.btnStand);
            this.grpDealer.Controls.Add(this.btnHit);
            this.grpDealer.Enabled = false;
            this.grpDealer.Location = new System.Drawing.Point(392, 210);
            this.grpDealer.Name = "grpDealer";
            this.grpDealer.Size = new System.Drawing.Size(283, 416);
            this.grpDealer.TabIndex = 2;
            this.grpDealer.TabStop = false;
            this.grpDealer.Text = "Dealer";
            // 
            // lblBlackJack
            // 
            this.lblBlackJack.AutoSize = true;
            this.lblBlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlackJack.Location = new System.Drawing.Point(411, 29);
            this.lblBlackJack.Name = "lblBlackJack";
            this.lblBlackJack.Size = new System.Drawing.Size(253, 55);
            this.lblBlackJack.TabIndex = 3;
            this.lblBlackJack.Text = "Black Jack";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(90, 300);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(98, 36);
            this.btnHit.TabIndex = 0;
            this.btnHit.Text = "HIT";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1067, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 36);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(90, 342);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(98, 36);
            this.btnStand.TabIndex = 1;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1067, 348);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(98, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPlayer3
            // 
            this.lblPlayer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer3.Location = new System.Drawing.Point(98, 203);
            this.lblPlayer3.Name = "lblPlayer3";
            this.lblPlayer3.Size = new System.Drawing.Size(100, 23);
            this.lblPlayer3.TabIndex = 0;
            this.lblPlayer3.Text = "Score";
            this.lblPlayer3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerFour
            // 
            this.lblPlayerFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerFour.Location = new System.Drawing.Point(91, 231);
            this.lblPlayerFour.Name = "lblPlayerFour";
            this.lblPlayerFour.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerFour.TabIndex = 1;
            this.lblPlayerFour.Text = "Score";
            this.lblPlayerFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(58, 203);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerTwo.TabIndex = 2;
            this.lblPlayerTwo.Text = "Score";
            this.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(58, 182);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(100, 23);
            this.lblPlayerOne.TabIndex = 2;
            this.lblPlayerOne.Text = "Score";
            this.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDealer
            // 
            this.lblDealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.Location = new System.Drawing.Point(172, 27);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(100, 23);
            this.lblDealer.TabIndex = 1;
            this.lblDealer.Text = "Score";
            this.lblDealer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optOne
            // 
            this.optOne.AutoSize = true;
            this.optOne.Location = new System.Drawing.Point(35, 23);
            this.optOne.Name = "optOne";
            this.optOne.Size = new System.Drawing.Size(45, 17);
            this.optOne.TabIndex = 2;
            this.optOne.TabStop = true;
            this.optOne.Text = "One";
            this.optOne.UseVisualStyleBackColor = true;
            this.optOne.CheckedChanged += new System.EventHandler(this.optOne_CheckedChanged);
            // 
            // optTwo
            // 
            this.optTwo.AutoSize = true;
            this.optTwo.Location = new System.Drawing.Point(143, 23);
            this.optTwo.Name = "optTwo";
            this.optTwo.Size = new System.Drawing.Size(46, 17);
            this.optTwo.TabIndex = 5;
            this.optTwo.TabStop = true;
            this.optTwo.Text = "Two";
            this.optTwo.UseVisualStyleBackColor = true;
            this.optTwo.CheckedChanged += new System.EventHandler(this.optTwo_CheckedChanged);
            // 
            // optThree
            // 
            this.optThree.AutoSize = true;
            this.optThree.Location = new System.Drawing.Point(35, 60);
            this.optThree.Name = "optThree";
            this.optThree.Size = new System.Drawing.Size(53, 17);
            this.optThree.TabIndex = 6;
            this.optThree.TabStop = true;
            this.optThree.Text = "Three";
            this.optThree.UseVisualStyleBackColor = true;
            this.optThree.CheckedChanged += new System.EventHandler(this.optThree_CheckedChanged);
            // 
            // optFour
            // 
            this.optFour.AutoSize = true;
            this.optFour.Location = new System.Drawing.Point(143, 60);
            this.optFour.Name = "optFour";
            this.optFour.Size = new System.Drawing.Size(46, 17);
            this.optFour.TabIndex = 7;
            this.optFour.TabStop = true;
            this.optFour.Text = "Four";
            this.optFour.UseVisualStyleBackColor = true;
            this.optFour.CheckedChanged += new System.EventHandler(this.optFour_CheckedChanged);
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.optFour);
            this.grpOptions.Controls.Add(this.optOne);
            this.grpOptions.Controls.Add(this.optTwo);
            this.grpOptions.Controls.Add(this.optThree);
            this.grpOptions.Location = new System.Drawing.Point(414, 96);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(226, 108);
            this.grpOptions.TabIndex = 2;
            this.grpOptions.TabStop = false;
            this.grpOptions.Enter += new System.EventHandler(this.grpOptions_Enter);
            // 
            // frmBlackJackGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 667);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblBlackJack);
            this.Controls.Add(this.grpDealer);
            this.Controls.Add(this.grpPlayer4);
            this.Controls.Add(this.grpPlayer3);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayerOne);
            this.Name = "frmBlackJackGame";
            this.Text = "Black Jack Game";
            this.Load += new System.EventHandler(this.frmBlackJackGame_Load);
            this.grpPlayerOne.ResumeLayout(false);
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer3.ResumeLayout(false);
            this.grpPlayer4.ResumeLayout(false);
            this.grpDealer.ResumeLayout(false);
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayerOne;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.GroupBox grpPlayer3;
        private System.Windows.Forms.GroupBox grpPlayer4;
        private System.Windows.Forms.GroupBox grpDealer;
        private System.Windows.Forms.Label lblBlackJack;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Label lblPlayer3;
        private System.Windows.Forms.Label lblPlayerFour;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.RadioButton optOne;
        private System.Windows.Forms.RadioButton optTwo;
        private System.Windows.Forms.RadioButton optThree;
        private System.Windows.Forms.RadioButton optFour;
        private System.Windows.Forms.GroupBox grpOptions;
    }
}

