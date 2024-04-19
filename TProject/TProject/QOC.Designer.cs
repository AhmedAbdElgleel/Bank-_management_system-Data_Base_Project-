namespace TProject
{
    partial class QOC
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = Color.SlateGray;
            button5.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Navy;
            button5.Location = new Point(8, 177);
            button5.Name = "button5";
            button5.Size = new Size(212, 49);
            button5.TabIndex = 22;
            button5.Text = "Show All clients";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SlateGray;
            button4.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Navy;
            button4.Location = new Point(480, 99);
            button4.Name = "button4";
            button4.Size = new Size(212, 49);
            button4.TabIndex = 21;
            button4.Text = "Update Data";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateGray;
            button3.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Navy;
            button3.Location = new Point(243, 99);
            button3.Name = "button3";
            button3.Size = new Size(212, 49);
            button3.TabIndex = 20;
            button3.Text = "Find / Remove client";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(594, 524);
            button2.Name = "button2";
            button2.Size = new Size(98, 35);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(8, 99);
            button1.Name = "button1";
            button1.Size = new Size(212, 49);
            button1.TabIndex = 18;
            button1.Text = "Add Client";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 24;
            label2.Text = "You want to...";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(576, 280);
            dataGridView1.TabIndex = 25;
            dataGridView1.Visible = false;
            // 
            // QOC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(700, 571);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "QOC";
            Text = "QOC";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private Button button4;
        private Button button3;
        public Button button2;
        private Button button1;
        private Label label2;
        public DataGridView dataGridView1;
    }
}