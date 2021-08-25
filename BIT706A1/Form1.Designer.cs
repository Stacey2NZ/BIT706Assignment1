namespace BIT706A1
{
    partial class Form1
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
            this.accountLbl = new System.Windows.Forms.Label();
            this.everydayBtn = new System.Windows.Forms.Button();
            this.investmentBtn = new System.Windows.Forms.Button();
            this.omniBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.chooseAccountLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accountLbl
            // 
            this.accountLbl.AutoSize = true;
            this.accountLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountLbl.Location = new System.Drawing.Point(341, 46);
            this.accountLbl.Name = "accountLbl";
            this.accountLbl.Size = new System.Drawing.Size(100, 33);
            this.accountLbl.TabIndex = 0;
            this.accountLbl.Text = "Account";
            // 
            // everydayBtn
            // 
            this.everydayBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.everydayBtn.Location = new System.Drawing.Point(120, 149);
            this.everydayBtn.Name = "everydayBtn";
            this.everydayBtn.Size = new System.Drawing.Size(126, 55);
            this.everydayBtn.TabIndex = 1;
            this.everydayBtn.Text = "Everyday";
            this.everydayBtn.UseVisualStyleBackColor = true;
            this.everydayBtn.Click += new System.EventHandler(this.everydayBtn_Click);
            // 
            // investmentBtn
            // 
            this.investmentBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investmentBtn.Location = new System.Drawing.Point(333, 149);
            this.investmentBtn.Name = "investmentBtn";
            this.investmentBtn.Size = new System.Drawing.Size(126, 55);
            this.investmentBtn.TabIndex = 2;
            this.investmentBtn.Text = "Investment";
            this.investmentBtn.UseVisualStyleBackColor = true;
            // 
            // omniBtn
            // 
            this.omniBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.omniBtn.Location = new System.Drawing.Point(562, 149);
            this.omniBtn.Name = "omniBtn";
            this.omniBtn.Size = new System.Drawing.Size(121, 55);
            this.omniBtn.TabIndex = 3;
            this.omniBtn.Text = "Omni";
            this.omniBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(615, 385);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 38);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // chooseAccountLbl
            // 
            this.chooseAccountLbl.AutoSize = true;
            this.chooseAccountLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseAccountLbl.Location = new System.Drawing.Point(290, 255);
            this.chooseAccountLbl.Name = "chooseAccountLbl";
            this.chooseAccountLbl.Size = new System.Drawing.Size(229, 19);
            this.chooseAccountLbl.TabIndex = 5;
            this.chooseAccountLbl.Text = "Choose your account to get started";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseAccountLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.omniBtn);
            this.Controls.Add(this.investmentBtn);
            this.Controls.Add(this.everydayBtn);
            this.Controls.Add(this.accountLbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accountLbl;
        private System.Windows.Forms.Button everydayBtn;
        private System.Windows.Forms.Button investmentBtn;
        private System.Windows.Forms.Button omniBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label chooseAccountLbl;
    }
}

