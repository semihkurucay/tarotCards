namespace tarotCards
{
    partial class BackcolorSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackcolorSettings));
            nudRed = new NumericUpDown();
            nudGreen = new NumericUpDown();
            nudBlue = new NumericUpDown();
            trcRed = new TrackBar();
            trcGreen = new TrackBar();
            trcBlue = new TrackBar();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trcRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trcGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trcBlue).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // nudRed
            // 
            nudRed.Location = new Point(61, 40);
            nudRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudRed.Name = "nudRed";
            nudRed.Size = new Size(62, 23);
            nudRed.TabIndex = 0;
            nudRed.ValueChanged += nudRed_ValueChanged;
            // 
            // nudGreen
            // 
            nudGreen.Location = new Point(61, 91);
            nudGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudGreen.Name = "nudGreen";
            nudGreen.Size = new Size(62, 23);
            nudGreen.TabIndex = 1;
            nudGreen.ValueChanged += nudGreen_ValueChanged;
            // 
            // nudBlue
            // 
            nudBlue.Location = new Point(61, 142);
            nudBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nudBlue.Name = "nudBlue";
            nudBlue.Size = new Size(62, 23);
            nudBlue.TabIndex = 2;
            nudBlue.ValueChanged += nudBlue_ValueChanged;
            // 
            // trcRed
            // 
            trcRed.Location = new Point(134, 40);
            trcRed.Maximum = 255;
            trcRed.Name = "trcRed";
            trcRed.Size = new Size(140, 45);
            trcRed.TabIndex = 3;
            trcRed.Scroll += trcRed_Scroll;
            // 
            // trcGreen
            // 
            trcGreen.Location = new Point(134, 91);
            trcGreen.Maximum = 255;
            trcGreen.Name = "trcGreen";
            trcGreen.Size = new Size(140, 45);
            trcGreen.TabIndex = 4;
            trcGreen.Scroll += trcGreen_Scroll;
            // 
            // trcBlue
            // 
            trcBlue.Location = new Point(134, 142);
            trcBlue.Maximum = 255;
            trcBlue.Name = "trcBlue";
            trcBlue.Size = new Size(140, 45);
            trcBlue.TabIndex = 5;
            trcBlue.Scroll += trcBlue_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(nudBlue);
            groupBox2.Controls.Add(nudRed);
            groupBox2.Controls.Add(trcBlue);
            groupBox2.Controls.Add(nudGreen);
            groupBox2.Controls.Add(trcGreen);
            groupBox2.Controls.Add(trcRed);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 206);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(34, 144);
            label3.Name = "label3";
            label3.Size = new Size(21, 21);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(22, 21);
            label2.TabIndex = 7;
            label2.Text = "G";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(34, 42);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 6;
            label1.Text = "R";
            // 
            // BackcolorSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(330, 230);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BackcolorSettings";
            Text = "Arka Pan Rengi";
            FormClosing += BackcolorSettings_FormClosing;
            FormClosed += BackcolorSettings_FormClosed;
            Load += BackcolorSettings_Load;
            ((System.ComponentModel.ISupportInitialize)nudRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trcRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trcGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trcBlue).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NumericUpDown nudRed;
        private NumericUpDown nudGreen;
        private NumericUpDown nudBlue;
        private TrackBar trcRed;
        private TrackBar trcGreen;
        private TrackBar trcBlue;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}