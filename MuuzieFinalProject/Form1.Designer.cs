namespace MuuzieFinalProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.rockLabel = new System.Windows.Forms.Label();
            this.hipHopLabel = new System.Windows.Forms.Label();
            this.popLabel = new System.Windows.Forms.Label();
            this.edmLabel = new System.Windows.Forms.Label();
            this.genreInput = new System.Windows.Forms.TextBox();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.wordsInput = new System.Windows.Forms.TextBox();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.languageInput = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Font = new System.Drawing.Font("Gill Sans MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.titleLabel.Location = new System.Drawing.Point(-3, -1);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(888, 82);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Muuzie";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel1
            // 
            this.infoLabel1.Font = new System.Drawing.Font("Gill Sans MT", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(35, 81);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(809, 34);
            this.infoLabel1.TabIndex = 1;
            this.infoLabel1.Text = "Pick the genre of music you would like based on the options below:";
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rockLabel
            // 
            this.rockLabel.AutoSize = true;
            this.rockLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockLabel.Location = new System.Drawing.Point(142, 115);
            this.rockLabel.Name = "rockLabel";
            this.rockLabel.Size = new System.Drawing.Size(86, 30);
            this.rockLabel.TabIndex = 2;
            this.rockLabel.Text = "1. Rock";
            // 
            // hipHopLabel
            // 
            this.hipHopLabel.AutoSize = true;
            this.hipHopLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hipHopLabel.Location = new System.Drawing.Point(286, 115);
            this.hipHopLabel.Name = "hipHopLabel";
            this.hipHopLabel.Size = new System.Drawing.Size(121, 30);
            this.hipHopLabel.TabIndex = 3;
            this.hipHopLabel.Text = "2.  HipHop";
            // 
            // popLabel
            // 
            this.popLabel.AutoSize = true;
            this.popLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popLabel.Location = new System.Drawing.Point(474, 115);
            this.popLabel.Name = "popLabel";
            this.popLabel.Size = new System.Drawing.Size(75, 30);
            this.popLabel.TabIndex = 4;
            this.popLabel.Text = "3. Pop";
            // 
            // edmLabel
            // 
            this.edmLabel.AutoSize = true;
            this.edmLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edmLabel.Location = new System.Drawing.Point(606, 115);
            this.edmLabel.Name = "edmLabel";
            this.edmLabel.Size = new System.Drawing.Size(86, 30);
            this.edmLabel.TabIndex = 5;
            this.edmLabel.Text = "4. EDM";
            // 
            // genreInput
            // 
            this.genreInput.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreInput.Location = new System.Drawing.Point(360, 162);
            this.genreInput.Name = "genreInput";
            this.genreInput.Size = new System.Drawing.Size(147, 30);
            this.genreInput.TabIndex = 6;
            this.genreInput.TextChanged += new System.EventHandler(this.genreInput_TextChanged);
            // 
            // infoLabel2
            // 
            this.infoLabel2.Font = new System.Drawing.Font("Gill Sans MT", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel2.Location = new System.Drawing.Point(51, 216);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(775, 34);
            this.infoLabel2.TabIndex = 7;
            this.infoLabel2.Text = "Would you like words in your song? Put Y for Yes and N for No: ";
            this.infoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wordsInput
            // 
            this.wordsInput.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsInput.Location = new System.Drawing.Point(360, 271);
            this.wordsInput.Name = "wordsInput";
            this.wordsInput.Size = new System.Drawing.Size(147, 30);
            this.wordsInput.TabIndex = 8;
            this.wordsInput.TextChanged += new System.EventHandler(this.wordsInput_TextChanged);
            // 
            // infoLabel3
            // 
            this.infoLabel3.Font = new System.Drawing.Font("Gill Sans MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel3.Location = new System.Drawing.Point(-7, 304);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(904, 98);
            this.infoLabel3.TabIndex = 9;
            this.infoLabel3.Text = "If you would like words in your song, what language would you prefer them in? \r\nP" +
    "ut E for English or A for Any:";
            this.infoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // languageInput
            // 
            this.languageInput.Font = new System.Drawing.Font("Gill Sans MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.languageInput.Location = new System.Drawing.Point(360, 405);
            this.languageInput.Name = "languageInput";
            this.languageInput.Size = new System.Drawing.Size(147, 30);
            this.languageInput.TabIndex = 10;
            this.languageInput.TextChanged += new System.EventHandler(this.languageInput_TextChanged);
            // 
            // generateButton
            // 
            this.generateButton.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateButton.Location = new System.Drawing.Point(385, 508);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(94, 41);
            this.generateButton.TabIndex = 11;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Gill Sans MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.outputLabel.Location = new System.Drawing.Point(38, 451);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(806, 39);
            this.outputLabel.TabIndex = 12;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.languageInput);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.wordsInput);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.genreInput);
            this.Controls.Add(this.edmLabel);
            this.Controls.Add(this.popLabel);
            this.Controls.Add(this.hipHopLabel);
            this.Controls.Add(this.rockLabel);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Muuzie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label rockLabel;
        private System.Windows.Forms.Label hipHopLabel;
        private System.Windows.Forms.Label popLabel;
        private System.Windows.Forms.Label edmLabel;
        private System.Windows.Forms.TextBox genreInput;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.TextBox wordsInput;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.TextBox languageInput;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

