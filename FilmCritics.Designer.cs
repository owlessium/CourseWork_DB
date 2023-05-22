
namespace CourseWork
{
    partial class FilmCritics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmCritics));
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxNicknameCritic = new System.Windows.Forms.TextBox();
            this.textBoxNumReviews = new System.Windows.Forms.TextBox();
            this.textBoxIdCritic = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(505, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Managing records";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(432, 428);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(325, 128);
            this.panel3.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(87, 53);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 45);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit record";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(169, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 45);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete record";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add new record";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNicknameCritic);
            this.panel2.Controls.Add(this.textBoxNumReviews);
            this.panel2.Controls.Add(this.textBoxIdCritic);
            this.panel2.Controls.Add(this.labelRating);
            this.panel2.Controls.Add(this.labelId);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(7, 400);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 156);
            this.panel2.TabIndex = 7;
            // 
            // textBoxNicknameCritic
            // 
            this.textBoxNicknameCritic.Location = new System.Drawing.Point(267, 54);
            this.textBoxNicknameCritic.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNicknameCritic.Multiline = true;
            this.textBoxNicknameCritic.Name = "textBoxNicknameCritic";
            this.textBoxNicknameCritic.Size = new System.Drawing.Size(142, 22);
            this.textBoxNicknameCritic.TabIndex = 10;
            // 
            // textBoxNumReviews
            // 
            this.textBoxNumReviews.Location = new System.Drawing.Point(267, 78);
            this.textBoxNumReviews.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumReviews.Multiline = true;
            this.textBoxNumReviews.Name = "textBoxNumReviews";
            this.textBoxNumReviews.Size = new System.Drawing.Size(142, 22);
            this.textBoxNumReviews.TabIndex = 9;
            this.textBoxNumReviews.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumReviews_KeyPress);
            // 
            // textBoxIdCritic
            // 
            this.textBoxIdCritic.Enabled = false;
            this.textBoxIdCritic.Location = new System.Drawing.Point(267, 30);
            this.textBoxIdCritic.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdCritic.Multiline = true;
            this.textBoxIdCritic.Name = "textBoxIdCritic";
            this.textBoxIdCritic.Size = new System.Drawing.Size(142, 22);
            this.textBoxIdCritic.TabIndex = 7;
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRating.Location = new System.Drawing.Point(95, 78);
            this.labelRating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(168, 24);
            this.labelRating.TabIndex = 3;
            this.labelRating.Text = "Number of reviews";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelId.Location = new System.Drawing.Point(95, 30);
            this.labelId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(25, 24);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "Id";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(95, 54);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(95, 24);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Nickname";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 28);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 84);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(765, 347);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 45);
            this.panel1.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(0, -8);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(72, 62);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBack.TabIndex = 5;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(415, 3);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 40);
            this.btnClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClear.TabIndex = 4;
            this.btnClear.TabStop = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(486, 3);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 38);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(557, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(627, 7);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(137, 27);
            this.textBox_search.TabIndex = 1;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film critics";
            // 
            // FilmCritics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 558);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FilmCritics";
            this.Text = "FilmCritics";
            this.Load += new System.EventHandler(this.FilmCritics_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNicknameCritic;
        private System.Windows.Forms.TextBox textBoxNumReviews;
        private System.Windows.Forms.TextBox textBoxIdCritic;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.PictureBox btnClear;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label label1;
    }
}