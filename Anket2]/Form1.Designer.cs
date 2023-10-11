namespace Anket2_
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
            panel1 = new Panel();
            lbl_error = new Label();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            tbox_gmail = new TextBox();
            label3 = new Label();
            tbox_surname = new TextBox();
            label2 = new Label();
            tbox_name = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            button2 = new Button();
            label5 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            button1 = new Button();
            tbox_file_name = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            Gmails = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(lbl_error);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbox_gmail);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbox_surname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbox_name);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(43, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 326);
            panel1.TabIndex = 0;
            // 
            // lbl_error
            // 
            lbl_error.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_error.ForeColor = Color.Crimson;
            lbl_error.Location = new Point(27, 276);
            lbl_error.Name = "lbl_error";
            lbl_error.Size = new Size(250, 25);
            lbl_error.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(27, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(27, 218);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 6;
            label4.Text = "BirthDate";
            // 
            // tbox_gmail
            // 
            tbox_gmail.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_gmail.Location = new Point(27, 174);
            tbox_gmail.Name = "tbox_gmail";
            tbox_gmail.Size = new Size(250, 30);
            tbox_gmail.TabIndex = 5;
            tbox_gmail.MouseLeave += tbox_gmail_MouseLeave;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(27, 146);
            label3.Name = "label3";
            label3.Size = new Size(98, 25);
            label3.TabIndex = 4;
            label3.Text = "Gmail";
            // 
            // tbox_surname
            // 
            tbox_surname.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_surname.Location = new Point(27, 107);
            tbox_surname.Name = "tbox_surname";
            tbox_surname.Size = new Size(250, 30);
            tbox_surname.TabIndex = 3;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(27, 79);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 2;
            label2.Text = "Surname";
            // 
            // tbox_name
            // 
            tbox_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_name.Location = new Point(27, 40);
            tbox_name.Name = "tbox_name";
            tbox_name.Size = new Size(250, 30);
            tbox_name.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(27, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // panel2
            // 
            panel2.BackColor = Color.GhostWhite;
            panel2.Controls.Add(button2);
            panel2.Location = new Point(24, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(373, 85);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ScrollBar;
            button2.Location = new Point(16, 3);
            button2.Name = "button2";
            button2.Size = new Size(337, 79);
            button2.TabIndex = 1;
            button2.Text = "ADD";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseEnter += button2_MouseEnter;
            button2.MouseLeave += button2_MouseLeave;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(30, 13);
            label5.Name = "label5";
            label5.Size = new Size(72, 25);
            label5.TabIndex = 1;
            label5.Text = "file_name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.GhostWhite;
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(tbox_file_name);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(403, 356);
            panel3.Name = "panel3";
            panel3.Size = new Size(373, 85);
            panel3.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Desktop;
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.Window;
            button4.Location = new Point(173, 46);
            button4.Name = "button4";
            button4.Size = new Size(158, 29);
            button4.TabIndex = 11;
            button4.Text = "SAVE";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            button4.MouseEnter += button4_MouseEnter;
            button4.MouseLeave += button4_MouseLeave;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Desktop;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(36, 46);
            button1.Name = "button1";
            button1.Size = new Size(149, 29);
            button1.TabIndex = 10;
            button1.Text = "LOAD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseEnter += button1_MouseEnter;
            button1.MouseLeave += button1_MouseLeave;
            // 
            // tbox_file_name
            // 
            tbox_file_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbox_file_name.Location = new Point(30, 13);
            tbox_file_name.Name = "tbox_file_name";
            tbox_file_name.Size = new Size(310, 30);
            tbox_file_name.TabIndex = 9;
            tbox_file_name.Text = "file name...";
            tbox_file_name.MouseEnter += textBox4_MouseEnter;
            tbox_file_name.MouseLeave += tbox_file_name_MouseLeave;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ScrollBar;
            button3.Location = new Point(18, 3);
            button3.Name = "button3";
            button3.Size = new Size(337, 79);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.WindowText;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Gmails });
            dataGridView1.GridColor = SystemColors.Window;
            dataGridView1.Location = new Point(421, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(331, 314);
            dataGridView1.TabIndex = 12;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Gmails
            // 
            Gmails.HeaderText = "Gmails";
            Gmails.MinimumWidth = 6;
            Gmails.Name = "Gmails";
            Gmails.Width = 280;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private TextBox tbox_gmail;
        private Label label3;
        private TextBox tbox_surname;
        private Label label2;
        private TextBox tbox_name;
        private Label label1;
        private Panel panel2;
        private Button button2;
        private Label label5;
        private Panel panel3;
        private Button button3;
        private Button button1;
        private TextBox tbox_file_name;
        private Button button4;
        private Label lbl_error;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Gmails;
    }
}