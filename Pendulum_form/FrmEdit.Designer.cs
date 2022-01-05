namespace Pendulum_form
{
    partial class FrmEdit
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
            this.tbId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(90, 33);
            this.tbId.Margin = new System.Windows.Forms.Padding(6);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(358, 29);
            this.tbId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "title:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(90, 87);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(358, 29);
            this.tbTitle.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "length:";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(90, 137);
            this.tbLength.Margin = new System.Windows.Forms.Padding(6);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(358, 29);
            this.tbLength.TabIndex = 5;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(90, 187);
            this.tbAlbum.Margin = new System.Windows.Forms.Padding(6);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(358, 29);
            this.tbAlbum.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "album:";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(90, 243);
            this.tbURL.Margin = new System.Windows.Forms.Padding(6);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(358, 29);
            this.tbURL.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "url:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(23, 312);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(425, 56);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // FrmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 400);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAlbum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmEdit";
            this.Text = "FrmEdit";
            this.Load += new System.EventHandler(this.FrmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEdit;
    }
}