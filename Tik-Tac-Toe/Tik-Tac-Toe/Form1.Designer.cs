namespace Tik_Tac_Toe
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Mono", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(288, 255);
            button1.Name = "button1";
            button1.Size = new Size(177, 29);
            button1.TabIndex = 2;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 36F, FontStyle.Underline, GraphicsUnit.Point, 161);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(171, 41);
            label1.Name = "label1";
            label1.Size = new Size(454, 79);
            label1.TabIndex = 3;
            label1.Text = "Tic-tac-toe ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 161);
            label2.Location = new Point(182, 146);
            label2.Name = "label2";
            label2.Size = new Size(429, 30);
            label2.TabIndex = 4;
            label2.Text = "Press the button below to start:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(792, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-tac-toe";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
