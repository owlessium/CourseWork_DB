
namespace CourseWork
{
    partial class FormForUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForUsers));
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGetAllMyWatchedFilms = new System.Windows.Forms.Button();
            this.btnComment = new System.Windows.Forms.Button();
            this.btnWatchThisFilm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxWatch = new System.Windows.Forms.TextBox();
            this.labelWatch = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.textBoxContRat = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelContRating = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(759, 621);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Managing records";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGetAllMyWatchedFilms);
            this.panel3.Controls.Add(this.btnComment);
            this.panel3.Controls.Add(this.btnWatchThisFilm);
            this.panel3.Location = new System.Drawing.Point(650, 661);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 366);
            this.panel3.TabIndex = 8;
            // 
            // btnGetAllMyWatchedFilms
            // 
            this.btnGetAllMyWatchedFilms.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnGetAllMyWatchedFilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetAllMyWatchedFilms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGetAllMyWatchedFilms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetAllMyWatchedFilms.Location = new System.Drawing.Point(4, 120);
            this.btnGetAllMyWatchedFilms.Name = "btnGetAllMyWatchedFilms";
            this.btnGetAllMyWatchedFilms.Size = new System.Drawing.Size(230, 112);
            this.btnGetAllMyWatchedFilms.TabIndex = 2;
            this.btnGetAllMyWatchedFilms.Text = "View a list of all the movies I\'ve watched";
            this.btnGetAllMyWatchedFilms.UseVisualStyleBackColor = false;
            this.btnGetAllMyWatchedFilms.Click += new System.EventHandler(this.btnGetAllMyWatchedFilms_Click);
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComment.Location = new System.Drawing.Point(254, 6);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(230, 99);
            this.btnComment.TabIndex = 1;
            this.btnComment.Text = "Comment this film";
            this.btnComment.UseVisualStyleBackColor = false;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // btnWatchThisFilm
            // 
            this.btnWatchThisFilm.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnWatchThisFilm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWatchThisFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWatchThisFilm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWatchThisFilm.Location = new System.Drawing.Point(4, 6);
            this.btnWatchThisFilm.Name = "btnWatchThisFilm";
            this.btnWatchThisFilm.Size = new System.Drawing.Size(230, 99);
            this.btnWatchThisFilm.TabIndex = 0;
            this.btnWatchThisFilm.Text = "Watch this film";
            this.btnWatchThisFilm.UseVisualStyleBackColor = false;
            this.btnWatchThisFilm.Click += new System.EventHandler(this.btnWatchThisFilm_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxWatch);
            this.panel2.Controls.Add(this.labelWatch);
            this.panel2.Controls.Add(this.textBoxGenre);
            this.panel2.Controls.Add(this.textBoxDuration);
            this.panel2.Controls.Add(this.textBoxTitle);
            this.panel2.Controls.Add(this.textBoxRating);
            this.panel2.Controls.Add(this.textBoxContRat);
            this.panel2.Controls.Add(this.textBoxId);
            this.panel2.Controls.Add(this.labelDuration);
            this.panel2.Controls.Add(this.labelGenre);
            this.panel2.Controls.Add(this.labelContRating);
            this.panel2.Controls.Add(this.labelRating);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(13, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(632, 276);
            this.panel2.TabIndex = 7;
            // 
            // textBoxWatch
            // 
            this.textBoxWatch.Enabled = false;
            this.textBoxWatch.Location = new System.Drawing.Point(363, 230);
            this.textBoxWatch.Name = "textBoxWatch";
            this.textBoxWatch.Size = new System.Drawing.Size(246, 26);
            this.textBoxWatch.TabIndex = 14;
            // 
            // labelWatch
            // 
            this.labelWatch.AutoSize = true;
            this.labelWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWatch.Location = new System.Drawing.Point(140, 223);
            this.labelWatch.Name = "labelWatch";
            this.labelWatch.Size = new System.Drawing.Size(95, 32);
            this.labelWatch.TabIndex = 13;
            this.labelWatch.Text = "Watch";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Enabled = false;
            this.textBoxGenre.Location = new System.Drawing.Point(363, 154);
            this.textBoxGenre.Multiline = true;
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(246, 32);
            this.textBoxGenre.TabIndex = 12;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Enabled = false;
            this.textBoxDuration.Location = new System.Drawing.Point(363, 191);
            this.textBoxDuration.Multiline = true;
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(246, 32);
            this.textBoxDuration.TabIndex = 11;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Enabled = false;
            this.textBoxTitle.Location = new System.Drawing.Point(363, 43);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(246, 32);
            this.textBoxTitle.TabIndex = 10;
            // 
            // textBoxRating
            // 
            this.textBoxRating.Enabled = false;
            this.textBoxRating.Location = new System.Drawing.Point(363, 80);
            this.textBoxRating.Multiline = true;
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(246, 32);
            this.textBoxRating.TabIndex = 9;
            // 
            // textBoxContRat
            // 
            this.textBoxContRat.Enabled = false;
            this.textBoxContRat.Location = new System.Drawing.Point(363, 117);
            this.textBoxContRat.Multiline = true;
            this.textBoxContRat.Name = "textBoxContRat";
            this.textBoxContRat.Size = new System.Drawing.Size(246, 32);
            this.textBoxContRat.TabIndex = 8;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(363, 6);
            this.textBoxId.Multiline = true;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(246, 32);
            this.textBoxId.TabIndex = 7;
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDuration.Location = new System.Drawing.Point(140, 191);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(123, 32);
            this.labelDuration.TabIndex = 6;
            this.labelDuration.Text = "Duration";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGenre.Location = new System.Drawing.Point(140, 154);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(94, 32);
            this.labelGenre.TabIndex = 5;
            this.labelGenre.Text = "Genre";
            // 
            // labelContRating
            // 
            this.labelContRating.AutoSize = true;
            this.labelContRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelContRating.Location = new System.Drawing.Point(140, 117);
            this.labelContRating.Name = "labelContRating";
            this.labelContRating.Size = new System.Drawing.Size(205, 32);
            this.labelContRating.TabIndex = 4;
            this.labelContRating.Text = "Content Rating";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRating.Location = new System.Drawing.Point(140, 80);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(98, 32);
            this.labelRating.TabIndex = 3;
            this.labelRating.Text = "Rating";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(140, 6);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(38, 32);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(140, 43);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(70, 32);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(3, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(130, 129);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1148, 534);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 69);
            this.panel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(622, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 62);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(729, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 58);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(940, 11);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(204, 39);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(268, 899);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(337, 26);
            this.textBoxComment.TabIndex = 10;
            this.textBoxComment.Visible = false;
            this.textBoxComment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComment_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(15, 896);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Leave a comment:";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 930);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "maximum of 50 characters";
            this.label4.Visible = false;
            // 
            // FormForUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 1060);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormForUsers";
            this.Text = "FormForUsers";
            this.Load += new System.EventHandler(this.FormForUsers_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGetAllMyWatchedFilms;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.Button btnWatchThisFilm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.TextBox textBoxContRat;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelContRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWatch;
        private System.Windows.Forms.Label labelWatch;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}