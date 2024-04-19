namespace TProject
{
    partial class Issues
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
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SlateGray;
            button1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Navy;
            button1.Location = new Point(713, 407);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 32;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(50, 121);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 28;
            label1.Text = "your issue";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(164, 121);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(517, 210);
            richTextBox1.TabIndex = 33;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.BackColor = Color.SlateGray;
            button2.Font = new Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Navy;
            button2.Location = new Point(355, 358);
            button2.Name = "button2";
            button2.Size = new Size(95, 31);
            button2.TabIndex = 34;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Issues
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Issues";
            Text = "Issues";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RichTextBox richTextBox1;
        private Button button2;
    }
}