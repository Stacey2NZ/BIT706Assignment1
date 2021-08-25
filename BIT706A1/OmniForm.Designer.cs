namespace BIT706A1
{
    partial class OmniForm
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
            this.omniAcctLbl = new System.Windows.Forms.Label();
            this.bkBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.curntBlnceLbl = new System.Windows.Forms.Label();
            this.showBlnceLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dpstBtn = new System.Windows.Forms.Button();
            this.wthdrwlBtn = new System.Windows.Forms.Button();
            this.entrAmntLbl = new System.Windows.Forms.Label();
            this.userInptTxtbbx = new System.Windows.Forms.TextBox();
            this.clclteBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.trnsctin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // omniAcctLbl
            // 
            this.omniAcctLbl.AutoSize = true;
            this.omniAcctLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.omniAcctLbl.Location = new System.Drawing.Point(325, 41);
            this.omniAcctLbl.Name = "omniAcctLbl";
            this.omniAcctLbl.Size = new System.Drawing.Size(110, 23);
            this.omniAcctLbl.TabIndex = 0;
            this.omniAcctLbl.Text = "Omni Account";
            // 
            // bkBtn
            // 
            this.bkBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bkBtn.Location = new System.Drawing.Point(23, 12);
            this.bkBtn.Name = "bkBtn";
            this.bkBtn.Size = new System.Drawing.Size(75, 28);
            this.bkBtn.TabIndex = 1;
            this.bkBtn.Text = "Go Back";
            this.bkBtn.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(698, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 30);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // curntBlnceLbl
            // 
            this.curntBlnceLbl.AutoSize = true;
            this.curntBlnceLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curntBlnceLbl.Location = new System.Drawing.Point(228, 84);
            this.curntBlnceLbl.Name = "curntBlnceLbl";
            this.curntBlnceLbl.Size = new System.Drawing.Size(115, 19);
            this.curntBlnceLbl.TabIndex = 3;
            this.curntBlnceLbl.Text = "Current Balance:";
            // 
            // showBlnceLbl
            // 
            this.showBlnceLbl.AutoSize = true;
            this.showBlnceLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBlnceLbl.Location = new System.Drawing.Point(387, 89);
            this.showBlnceLbl.Name = "showBlnceLbl";
            this.showBlnceLbl.Size = new System.Drawing.Size(0, 19);
            this.showBlnceLbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Is this a deposit or withdrawal?";
            // 
            // dpstBtn
            // 
            this.dpstBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpstBtn.Location = new System.Drawing.Point(242, 176);
            this.dpstBtn.Name = "dpstBtn";
            this.dpstBtn.Size = new System.Drawing.Size(101, 40);
            this.dpstBtn.TabIndex = 6;
            this.dpstBtn.Text = "Deposit";
            this.dpstBtn.UseVisualStyleBackColor = true;
            // 
            // wthdrwlBtn
            // 
            this.wthdrwlBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wthdrwlBtn.Location = new System.Drawing.Point(427, 176);
            this.wthdrwlBtn.Name = "wthdrwlBtn";
            this.wthdrwlBtn.Size = new System.Drawing.Size(96, 40);
            this.wthdrwlBtn.TabIndex = 7;
            this.wthdrwlBtn.Text = "Withdrawal";
            this.wthdrwlBtn.UseVisualStyleBackColor = true;
            // 
            // entrAmntLbl
            // 
            this.entrAmntLbl.AutoSize = true;
            this.entrAmntLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entrAmntLbl.Location = new System.Drawing.Point(242, 245);
            this.entrAmntLbl.Name = "entrAmntLbl";
            this.entrAmntLbl.Size = new System.Drawing.Size(99, 19);
            this.entrAmntLbl.TabIndex = 8;
            this.entrAmntLbl.Text = "Enter Amount:";
            // 
            // userInptTxtbbx
            // 
            this.userInptTxtbbx.Location = new System.Drawing.Point(427, 245);
            this.userInptTxtbbx.Name = "userInptTxtbbx";
            this.userInptTxtbbx.Size = new System.Drawing.Size(100, 20);
            this.userInptTxtbbx.TabIndex = 9;
            // 
            // clclteBtn
            // 
            this.clclteBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clclteBtn.Location = new System.Drawing.Point(336, 284);
            this.clclteBtn.Name = "clclteBtn";
            this.clclteBtn.Size = new System.Drawing.Size(99, 34);
            this.clclteBtn.TabIndex = 10;
            this.clclteBtn.Text = "Calculate";
            this.clclteBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(143, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "New Balance:";
            // 
            // trnsctin
            // 
            this.trnsctin.AutoSize = true;
            this.trnsctin.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trnsctin.Location = new System.Drawing.Point(254, 357);
            this.trnsctin.Name = "trnsctin";
            this.trnsctin.Size = new System.Drawing.Size(0, 19);
            this.trnsctin.TabIndex = 12;
            // 
            // OmniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.trnsctin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clclteBtn);
            this.Controls.Add(this.userInptTxtbbx);
            this.Controls.Add(this.entrAmntLbl);
            this.Controls.Add(this.wthdrwlBtn);
            this.Controls.Add(this.dpstBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showBlnceLbl);
            this.Controls.Add(this.curntBlnceLbl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.bkBtn);
            this.Controls.Add(this.omniAcctLbl);
            this.Name = "OmniForm";
            this.Text = "OmniForm";
            this.Load += new System.EventHandler(this.OmniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label omniAcctLbl;
        private System.Windows.Forms.Button bkBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label curntBlnceLbl;
        private System.Windows.Forms.Label showBlnceLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dpstBtn;
        private System.Windows.Forms.Button wthdrwlBtn;
        private System.Windows.Forms.Label entrAmntLbl;
        private System.Windows.Forms.TextBox userInptTxtbbx;
        private System.Windows.Forms.Button clclteBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label trnsctin;
    }
}