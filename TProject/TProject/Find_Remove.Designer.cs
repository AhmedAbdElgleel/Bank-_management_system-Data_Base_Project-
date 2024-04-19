namespace TProject
{
    partial class Find_Remove
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 303);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(576, 280);
            dataGridView1.TabIndex = 27;
            dataGridView1.Visible = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(597, 548);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 26;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(232, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 23);
            textBox1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(76, 91);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 28;
            label1.Text = "Username";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(232, 188);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 30;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(375, 188);
            button3.Name = "button3";
            button3.Size = new Size(98, 35);
            button3.TabIndex = 31;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Find_Remove
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(707, 595);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Name = "Find_Remove";
            Text = "Find_Remove";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView dataGridView1;
        public Button button2;
        private TextBox textBox1;
        private Label label1;
        public Button button1;
        public Button button3;
    }
}