namespace TProject
{
    partial class Employee
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
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button6 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            button4 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(44, 79);
            button1.Name = "button1";
            button1.Size = new Size(212, 49);
            button1.TabIndex = 9;
            button1.Text = "Quering on a client";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(630, 555);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 10;
            button2.Text = "Sign Out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(253, 19);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 13;
            label3.Text = "You want to...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(107, 19);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 12;
            label2.Text = "employee name,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 11;
            label1.Text = "Welcome";
            // 
            // button6
            // 
            button6.BackColor = Color.SlateGray;
            button6.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Navy;
            button6.Location = new Point(44, 158);
            button6.Name = "button6";
            button6.Size = new Size(212, 49);
            button6.TabIndex = 17;
            button6.Text = "Quering on an employee";
            button6.UseVisualStyleBackColor = false;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(281, 79);
            button3.Name = "button3";
            button3.Size = new Size(212, 49);
            button3.TabIndex = 18;
            button3.Text = "Clients issues";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(565, 247);
            dataGridView1.TabIndex = 19;
            dataGridView1.Visible = false;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(281, 158);
            button4.Name = "button4";
            button4.Size = new Size(212, 49);
            button4.TabIndex = 20;
            button4.Text = "Add issue";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.SlateGray;
            button7.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Navy;
            button7.Location = new Point(516, 158);
            button7.Name = "button7";
            button7.Size = new Size(212, 49);
            button7.TabIndex = 21;
            button7.Text = "Employees issues";
            button7.UseVisualStyleBackColor = false;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SlateGray;
            button8.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Navy;
            button8.Location = new Point(516, 79);
            button8.Name = "button8";
            button8.Size = new Size(212, 49);
            button8.TabIndex = 22;
            button8.Text = "Update data";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(740, 602);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Employee";
            Text = "Employee";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        public Button button2;
        private Label label3;
        private Label label2;
        private Label label1;
        public Button button6;
        private Button button3;
        private DataGridView dataGridView1;
        public Button button4;
        public Button button7;
        private Button button8;
    }
}