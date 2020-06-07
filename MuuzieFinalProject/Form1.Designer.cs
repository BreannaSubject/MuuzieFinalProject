﻿namespace MuuzieFinalProject
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
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Font = new System.Drawing.Font("Gill Sans MT", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.Location = new System.Drawing.Point(35, 81);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(809, 34);
            this.infoLabel1.TabIndex = 1;
            this.infoLabel1.Text = "Pick the genre of music you would like based on the options below:";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
    }
}
