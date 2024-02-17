namespace Tik_Tac_Toe
{
    partial class Form3
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
            button10 = new Button();
            button11 = new Button();
            label1 = new Label();
            label2 = new Label();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button10
            // 
            button10.Location = new Point(654, 403);
            button10.Name = "button10";
            button10.Size = new Size(94, 35);
            button10.TabIndex = 8;
            button10.Text = "Exit";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(60, 403);
            button11.Name = "button11";
            button11.Size = new Size(94, 29);
            button11.TabIndex = 9;
            button11.Text = "New game";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 33);
            label1.Name = "label1";
            label1.Size = new Size(96, 27);
            label1.TabIndex = 10;
            label1.Text = "player1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(522, 33);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 11;
            label2.Text = "player2";
            label2.Click += label2_Click;
            // 
            // button9
            // 
            button9.Location = new Point(424, 272);
            button9.Name = "button9";
            button9.Size = new Size(94, 94);
            button9.TabIndex = 7;
            button9.Tag = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(337, 272);
            button8.Name = "button8";
            button8.Size = new Size(94, 94);
            button8.TabIndex = 6;
            button8.Tag = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(247, 272);
            button7.Name = "button7";
            button7.Size = new Size(94, 94);
            button7.TabIndex = 5;
            button7.Tag = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.Location = new Point(247, 183);
            button4.Name = "button4";
            button4.Size = new Size(94, 94);
            button4.TabIndex = 3;
            button4.Tag = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(337, 183);
            button5.Name = "button5";
            button5.Size = new Size(94, 94);
            button5.TabIndex = 4;
            button5.Tag = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(424, 183);
            button6.Name = "button6";
            button6.Size = new Size(94, 94);
            button6.TabIndex = 4;
            button6.Tag = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(424, 93);
            button3.Name = "button3";
            button3.Size = new Size(94, 94);
            button3.TabIndex = 2;
            button3.Tag = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(337, 93);
            button2.Name = "button2";
            button2.Size = new Size(94, 94);
            button2.TabIndex = 1;
            button2.Tag = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(247, 93);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 0;
            button1.Tag = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form3";
            Text = "Tic-tac-toe";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button10;
        private Button button11;
        private Label label1;
        private Label label2;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}