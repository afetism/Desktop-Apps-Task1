namespace Desktop_Apps_Task1
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            BakuBtn = new Button();
            LondonBtn = new Button();
            ClockLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._5014;
            pictureBox1.Location = new Point(71, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(447, 325);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // BakuBtn
            // 
            BakuBtn.BackColor = Color.IndianRed;
            BakuBtn.FlatAppearance.BorderSize = 0;
            BakuBtn.FlatStyle = FlatStyle.Flat;
            BakuBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BakuBtn.ForeColor = SystemColors.ButtonFace;
            BakuBtn.Location = new Point(557, 116);
            BakuBtn.Name = "BakuBtn";
            BakuBtn.Size = new Size(180, 34);
            BakuBtn.TabIndex = 1;
            BakuBtn.Text = "Baku";
            BakuBtn.UseVisualStyleBackColor = false;
            BakuBtn.Click += BakuBtn_Click;
            // 
            // LondonBtn
            // 
            LondonBtn.BackColor = Color.IndianRed;
            LondonBtn.FlatAppearance.BorderSize = 0;
            LondonBtn.FlatStyle = FlatStyle.Flat;
            LondonBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LondonBtn.ForeColor = SystemColors.ButtonFace;
            LondonBtn.Location = new Point(557, 312);
            LondonBtn.Name = "LondonBtn";
            LondonBtn.Size = new Size(180, 34);
            LondonBtn.TabIndex = 2;
            LondonBtn.Text = "London";
            LondonBtn.UseVisualStyleBackColor = false;
            LondonBtn.Click += LondonBtn_Click;
            // 
            // ClockLabel
            // 
            ClockLabel.AutoSize = true;
            ClockLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClockLabel.Location = new Point(71, 30);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Size = new Size(65, 22);
            ClockLabel.TabIndex = 3;
            ClockLabel.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += London_Timer_Tick;
            // 
            // timer2
            // 
            timer2.Tick += Baku_Timer_Tick;
            // 
            // timer3
            // 
            timer3.Tick += time_tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(ClockLabel);
            Controls.Add(LondonBtn);
            Controls.Add(BakuBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BakuBtn;
        private Button LondonBtn;
        private Label ClockLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}
