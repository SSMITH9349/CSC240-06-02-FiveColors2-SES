namespace CSC240_06_02_FiveColors2_SES
{
    partial class welcomeForm
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
            this.introLabel = new System.Windows.Forms.Label();
            this.UxBlueRButton = new System.Windows.Forms.RadioButton();
            this.UxRedRButton = new System.Windows.Forms.RadioButton();
            this.UxGreenButton = new System.Windows.Forms.RadioButton();
            this.UxPurpleRButton = new System.Windows.Forms.RadioButton();
            this.UxYellowRButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // introLabel
            // 
            this.introLabel.AutoSize = true;
            this.introLabel.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.introLabel.Location = new System.Drawing.Point(104, 64);
            this.introLabel.Name = "introLabel";
            this.introLabel.Size = new System.Drawing.Size(413, 28);
            this.introLabel.TabIndex = 0;
            this.introLabel.Text = "Please Choose Color For Background:";
            this.introLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // UxBlueRButton
            // 
            this.UxBlueRButton.AutoSize = true;
            this.UxBlueRButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxBlueRButton.Location = new System.Drawing.Point(104, 173);
            this.UxBlueRButton.Name = "UxBlueRButton";
            this.UxBlueRButton.Size = new System.Drawing.Size(92, 27);
            this.UxBlueRButton.TabIndex = 7;
            this.UxBlueRButton.TabStop = true;
            this.UxBlueRButton.Text = "<--Blue!";
            this.UxBlueRButton.UseVisualStyleBackColor = true;
            this.UxBlueRButton.CheckedChanged += new System.EventHandler(this.UxBlueRButton_CheckedChanged);
            // 
            // UxRedRButton
            // 
            this.UxRedRButton.AutoSize = true;
            this.UxRedRButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxRedRButton.Location = new System.Drawing.Point(396, 173);
            this.UxRedRButton.Name = "UxRedRButton";
            this.UxRedRButton.Size = new System.Drawing.Size(89, 27);
            this.UxRedRButton.TabIndex = 8;
            this.UxRedRButton.TabStop = true;
            this.UxRedRButton.Text = "<--Red!";
            this.UxRedRButton.UseVisualStyleBackColor = true;
            // 
            // UxGreenButton
            // 
            this.UxGreenButton.AutoSize = true;
            this.UxGreenButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxGreenButton.Location = new System.Drawing.Point(242, 245);
            this.UxGreenButton.Name = "UxGreenButton";
            this.UxGreenButton.Size = new System.Drawing.Size(107, 27);
            this.UxGreenButton.TabIndex = 9;
            this.UxGreenButton.TabStop = true;
            this.UxGreenButton.Text = "<--Green!";
            this.UxGreenButton.UseVisualStyleBackColor = true;
            // 
            // UxPurpleRButton
            // 
            this.UxPurpleRButton.AutoSize = true;
            this.UxPurpleRButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxPurpleRButton.Location = new System.Drawing.Point(104, 310);
            this.UxPurpleRButton.Name = "UxPurpleRButton";
            this.UxPurpleRButton.Size = new System.Drawing.Size(110, 27);
            this.UxPurpleRButton.TabIndex = 10;
            this.UxPurpleRButton.TabStop = true;
            this.UxPurpleRButton.Text = "<--Purple!";
            this.UxPurpleRButton.UseVisualStyleBackColor = true;
            // 
            // UxYellowRButton
            // 
            this.UxYellowRButton.AutoSize = true;
            this.UxYellowRButton.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.UxYellowRButton.Location = new System.Drawing.Point(380, 310);
            this.UxYellowRButton.Name = "UxYellowRButton";
            this.UxYellowRButton.Size = new System.Drawing.Size(105, 27);
            this.UxYellowRButton.TabIndex = 0;
            this.UxYellowRButton.TabStop = true;
            this.UxYellowRButton.Text = "<--Yellow";
            this.UxYellowRButton.UseVisualStyleBackColor = true;
            // 
            // welcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 411);
            this.Controls.Add(this.UxYellowRButton);
            this.Controls.Add(this.UxPurpleRButton);
            this.Controls.Add(this.UxGreenButton);
            this.Controls.Add(this.UxRedRButton);
            this.Controls.Add(this.UxBlueRButton);
            this.Controls.Add(this.introLabel);
            this.Name = "welcomeForm";
            this.Text = "Color Choice";
            this.Load += new System.EventHandler(this.welcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label introLabel;
        private RadioButton UxBlueRButton;
        private RadioButton UxRedRButton;
        private RadioButton UxGreenButton;
        private RadioButton UxPurpleRButton;
        private RadioButton UxYellowRButton;
    }
}