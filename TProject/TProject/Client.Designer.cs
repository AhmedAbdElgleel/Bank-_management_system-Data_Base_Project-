namespace TProject
{
    partial class Client
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            dataGridView1 = new DataGridView();
            button9 = new Button();
            button11 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(44, 116);
            button1.Name = "button1";
            button1.Size = new Size(133, 60);
            button1.TabIndex = 0;
            button1.Text = "Show Balance";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(44, 36);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(131, 36);
            label2.Name = "label2";
            label2.Size = new Size(108, 23);
            label2.TabIndex = 2;
            label2.Text = "Client name,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(245, 36);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 3;
            label3.Text = "You want to...";
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(209, 116);
            button2.Name = "button2";
            button2.Size = new Size(133, 60);
            button2.TabIndex = 4;
            button2.Text = "Send money";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(528, 116);
            button3.Name = "button3";
            button3.Size = new Size(133, 60);
            button3.TabIndex = 5;
            button3.Text = "Withdraw";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(44, 211);
            button4.Name = "button4";
            button4.Size = new Size(133, 60);
            button4.TabIndex = 6;
            button4.Text = "Deposite";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.SlateGray;
            button5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(615, 21);
            button5.Name = "button5";
            button5.Size = new Size(84, 38);
            button5.TabIndex = 7;
            button5.Text = "Sign Out";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.SlateGray;
            button6.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Navy;
            button6.Location = new Point(528, 211);
            button6.Name = "button6";
            button6.Size = new Size(133, 60);
            button6.TabIndex = 8;
            button6.Text = "History";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.SlateGray;
            button8.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.Navy;
            button8.Location = new Point(369, 116);
            button8.Name = "button8";
            button8.Size = new Size(133, 60);
            button8.TabIndex = 10;
            button8.Text = "Update";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 301);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(617, 244);
            dataGridView1.TabIndex = 11;
            dataGridView1.Visible = false;
            // 
            // button9
            // 
            button9.BackColor = Color.SlateGray;
            button9.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.Navy;
            button9.Location = new Point(369, 211);
            button9.Name = "button9";
            button9.Size = new Size(133, 60);
            button9.TabIndex = 13;
            button9.Text = "Show data";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.SlateGray;
            button11.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button11.ForeColor = Color.Navy;
            button11.Location = new Point(209, 211);
            button11.Name = "button11";
            button11.Size = new Size(133, 60);
            button11.TabIndex = 17;
            button11.Text = "Add issue";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(711, 554);
            Controls.Add(button11);
            Controls.Add(button9);
            Controls.Add(dataGridView1);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Client";
            Text = "Client";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        public DataGridView dataGridView1;
        private Button button9;
        private Button button11;
    }
}