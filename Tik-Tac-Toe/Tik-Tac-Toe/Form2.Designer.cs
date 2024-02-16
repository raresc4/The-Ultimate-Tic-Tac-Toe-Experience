namespace Tik_Tac_Toe
{
    partial class Form2
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(73, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 18);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.AcceptsReturn = true;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(73, 303);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 18);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            button1.Location = new Point(612, 169);
            button1.Name = "button1";
            button1.Size = new Size(132, 67);
            button1.TabIndex = 5;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label1.Location = new Point(73, 38);
            label1.Name = "label1";
            label1.Size = new Size(260, 30);
            label1.TabIndex = 6;
            label1.Text = "Input player1 name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label2.Location = new Point(73, 231);
            label2.Name = "label2";
            label2.Size = new Size(260, 30);
            label2.TabIndex = 7;
            label2.Text = "Input player2 game:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(900, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 161);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Tic-tac-toe";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}