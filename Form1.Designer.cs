namespace Choose_a_Picture
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
            this.Choice = new System.Windows.Forms.ComboBox();
            this.Pictures = new System.Windows.Forms.PictureBox();
            this.Quit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).BeginInit();
            this.SuspendLayout();
            // 
            // Choice
            // 
            this.Choice.FormattingEnabled = true;
            this.Choice.Items.AddRange(new object[] {
            "Alien",
            "Dragon",
            "Hydra",
            "Medusa",
            "Scorpius",
            "Shadow"});
            this.Choice.Location = new System.Drawing.Point(76, 112);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(177, 24);
            this.Choice.TabIndex = 0;
            this.Choice.Text = "Choose here";
            this.Choice.SelectedIndexChanged += new System.EventHandler(this.Choice_SelectedIndexChanged);
            // 
            // Pictures
            // 
            this.Pictures.Location = new System.Drawing.Point(452, 66);
            this.Pictures.Name = "Pictures";
            this.Pictures.Size = new System.Drawing.Size(269, 259);
            this.Pictures.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pictures.TabIndex = 1;
            this.Pictures.TabStop = false;
            this.Pictures.Click += new System.EventHandler(this.Pictures_Click);
            // 
            // Quit
            // 
            this.Quit.Location = new System.Drawing.Point(624, 358);
            this.Quit.Name = "Quit";
            this.Quit.Size = new System.Drawing.Size(97, 36);
            this.Quit.TabIndex = 2;
            this.Quit.Text = "Quit";
            this.Quit.UseVisualStyleBackColor = true;
            this.Quit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Quit);
            this.Controls.Add(this.Pictures);
            this.Controls.Add(this.Choice);
            this.Name = "Form1";
            this.Text = "Choose a Picture";
            ((System.ComponentModel.ISupportInitialize)(this.Pictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Choice;
        private System.Windows.Forms.PictureBox Pictures;
        private System.Windows.Forms.Button Quit;
    }
}

