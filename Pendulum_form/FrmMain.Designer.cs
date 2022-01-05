namespace Pendulum_form
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbArtist = new System.Windows.Forms.ComboBox();
            this.cbAlbum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkURL = new System.Windows.Forms.LinkLabel();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAddURL = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pbAlbum = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Album";
            // 
            // cbArtist
            // 
            this.cbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArtist.FormattingEnabled = true;
            this.cbArtist.Location = new System.Drawing.Point(18, 71);
            this.cbArtist.Name = "cbArtist";
            this.cbArtist.Size = new System.Drawing.Size(228, 33);
            this.cbArtist.TabIndex = 2;
            this.cbArtist.SelectedIndexChanged += new System.EventHandler(this.cbArtist_SelectedIndexChanged);
            // 
            // cbAlbum
            // 
            this.cbAlbum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlbum.FormattingEnabled = true;
            this.cbAlbum.Location = new System.Drawing.Point(289, 71);
            this.cbAlbum.Name = "cbAlbum";
            this.cbAlbum.Size = new System.Drawing.Size(228, 33);
            this.cbAlbum.TabIndex = 3;
            this.cbAlbum.SelectedIndexChanged += new System.EventHandler(this.cbAlbum_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search in track\'s title";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(18, 169);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(499, 31);
            this.tbSearch.TabIndex = 5;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Length,
            this.URL,
            this.id});
            this.dgv.Location = new System.Drawing.Point(19, 227);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(494, 343);
            this.dgv.TabIndex = 6;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.FillWeight = 70F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Length.FillWeight = 30F;
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Visible = false;
            this.URL.Width = 125;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(739, 227);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(433, 158);
            this.rtb.TabIndex = 8;
            this.rtb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "URL(if any):";
            // 
            // linkURL
            // 
            this.linkURL.AutoSize = true;
            this.linkURL.Location = new System.Drawing.Point(734, 443);
            this.linkURL.Name = "linkURL";
            this.linkURL.Size = new System.Drawing.Size(0, 25);
            this.linkURL.TabIndex = 10;
            // 
            // btnAddFile
            // 
            this.btnAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddFile.Location = new System.Drawing.Point(556, 524);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(200, 50);
            this.btnAddFile.TabIndex = 11;
            this.btnAddFile.Text = "Add Discography";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddURL
            // 
            this.btnAddURL.Location = new System.Drawing.Point(762, 524);
            this.btnAddURL.Name = "btnAddURL";
            this.btnAddURL.Size = new System.Drawing.Size(204, 50);
            this.btnAddURL.TabIndex = 12;
            this.btnAddURL.Text = "Add URL";
            this.btnAddURL.UseVisualStyleBackColor = true;
            this.btnAddURL.Click += new System.EventHandler(this.btnAddURL_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(972, 524);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 50);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Selected";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbAlbum
            // 
            this.pbAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAlbum.Location = new System.Drawing.Point(556, 227);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.Size = new System.Drawing.Size(154, 154);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 7;
            this.pbAlbum.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 586);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddURL);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.linkURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.pbAlbum);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbAlbum);
            this.Controls.Add(this.cbArtist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1200, 625);
            this.MinimumSize = new System.Drawing.Size(1200, 625);
            this.Name = "FrmMain";
            this.Text = "Discograpy Tracker";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbArtist;
        private System.Windows.Forms.ComboBox cbAlbum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.PictureBox pbAlbum;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkURL;
        private System.Windows.Forms.Button btnAddFile;
        private System.Windows.Forms.Button btnAddURL;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

