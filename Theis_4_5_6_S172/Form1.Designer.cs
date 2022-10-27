namespace Theis_4_5_6_S172
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.LblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(429, 34);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(260, 42);
            this.CmdAnzeigen1.TabIndex = 0;
            this.CmdAnzeigen1.Text = "Mittelwert a, b, c, d";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(429, 113);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(260, 44);
            this.CmdAnzeigen2.TabIndex = 1;
            this.CmdAnzeigen2.Text = "Mittelwert a, b";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(429, 194);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(260, 41);
            this.CmdAnzeigen3.TabIndex = 2;
            this.CmdAnzeigen3.Text = "Mittelwert ()";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(23, 194);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(73, 25);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "Output:";
            // 
            // LblInput
            // 
            this.LblInput.AutoSize = true;
            this.LblInput.Location = new System.Drawing.Point(23, 43);
            this.LblInput.Name = "LblInput";
            this.LblInput.Size = new System.Drawing.Size(58, 25);
            this.LblInput.TabIndex = 4;
            this.LblInput.Text = "Input:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 272);
            this.Controls.Add(this.LblInput);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Theis 4.5.6, S.172: Beliebig viele Argumente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button CmdAnzeigen1;
        private Button CmdAnzeigen2;
        private Button CmdAnzeigen3;
        private Label LblAnzeige;
        private Label LblInput;
    }
}