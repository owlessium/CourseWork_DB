
namespace CourseWork
{
    partial class Menu
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
            this.btnMovies = new System.Windows.Forms.Button();
            this.btnCritics = new System.Windows.Forms.Button();
            this.btnWatchings = new System.Windows.Forms.Button();
            this.btnComments = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMovies
            // 
            this.btnMovies.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMovies.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMovies.Location = new System.Drawing.Point(11, 42);
            this.btnMovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Size = new System.Drawing.Size(153, 45);
            this.btnMovies.TabIndex = 1;
            this.btnMovies.Text = "Movies";
            this.btnMovies.UseVisualStyleBackColor = false;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // btnCritics
            // 
            this.btnCritics.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnCritics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCritics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCritics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCritics.Location = new System.Drawing.Point(192, 42);
            this.btnCritics.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCritics.Name = "btnCritics";
            this.btnCritics.Size = new System.Drawing.Size(153, 45);
            this.btnCritics.TabIndex = 2;
            this.btnCritics.Text = "Film critics";
            this.btnCritics.UseVisualStyleBackColor = false;
            this.btnCritics.Click += new System.EventHandler(this.btnCritics_Click);
            // 
            // btnWatchings
            // 
            this.btnWatchings.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWatchings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWatchings.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWatchings.Location = new System.Drawing.Point(11, 106);
            this.btnWatchings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWatchings.Name = "btnWatchings";
            this.btnWatchings.Size = new System.Drawing.Size(153, 45);
            this.btnWatchings.TabIndex = 3;
            this.btnWatchings.Text = "Watchings";
            this.btnWatchings.UseVisualStyleBackColor = false;
            // 
            // btnComments
            // 
            this.btnComments.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComments.Location = new System.Drawing.Point(192, 106);
            this.btnComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComments.Name = "btnComments";
            this.btnComments.Size = new System.Drawing.Size(153, 45);
            this.btnComments.TabIndex = 4;
            this.btnComments.Text = "Comments";
            this.btnComments.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select a table";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(11, 167);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Users";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 220);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComments);
            this.Controls.Add(this.btnWatchings);
            this.Controls.Add(this.btnCritics);
            this.Controls.Add(this.btnMovies);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMovies;
        private System.Windows.Forms.Button btnCritics;
        private System.Windows.Forms.Button btnWatchings;
        private System.Windows.Forms.Button btnComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}