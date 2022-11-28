namespace DataBaseFilmConnectivity
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
            this.buttselect = new System.Windows.Forms.Button();
            this.buttinsert = new System.Windows.Forms.Button();
            this.buttupdate = new System.Windows.Forms.Button();
            this.buttdelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttselect
            // 
            this.buttselect.Location = new System.Drawing.Point(551, 40);
            this.buttselect.Name = "buttselect";
            this.buttselect.Size = new System.Drawing.Size(215, 242);
            this.buttselect.TabIndex = 0;
            this.buttselect.Text = "Select";
            this.buttselect.UseVisualStyleBackColor = true;
            // 
            // buttinsert
            // 
            this.buttinsert.Location = new System.Drawing.Point(611, 302);
            this.buttinsert.Name = "buttinsert";
            this.buttinsert.Size = new System.Drawing.Size(94, 29);
            this.buttinsert.TabIndex = 1;
            this.buttinsert.Text = "Insert";
            this.buttinsert.UseVisualStyleBackColor = true;
            this.buttinsert.Click += new System.EventHandler(this.buttinsert_Click);
            // 
            // buttupdate
            // 
            this.buttupdate.Location = new System.Drawing.Point(611, 345);
            this.buttupdate.Name = "buttupdate";
            this.buttupdate.Size = new System.Drawing.Size(94, 29);
            this.buttupdate.TabIndex = 2;
            this.buttupdate.Text = "Update";
            this.buttupdate.UseVisualStyleBackColor = true;
            // 
            // buttdelete
            // 
            this.buttdelete.Location = new System.Drawing.Point(611, 395);
            this.buttdelete.Name = "buttdelete";
            this.buttdelete.Size = new System.Drawing.Size(94, 29);
            this.buttdelete.TabIndex = 3;
            this.buttdelete.Text = "Delete";
            this.buttdelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(62, 373);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(49, 20);
            this.Name.TabIndex = 5;
            this.Name.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(418, 242);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(205, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(205, 373);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttdelete);
            this.Controls.Add(this.buttupdate);
            this.Controls.Add(this.buttinsert);
            this.Controls.Add(this.buttselect);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name.Text = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttselect;
        private Button buttinsert;
        private Button buttupdate;
        private Button buttdelete;
        private Label label1;
        private Label Name;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}