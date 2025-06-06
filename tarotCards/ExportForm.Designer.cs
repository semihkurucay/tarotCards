namespace tarotCards
{
    partial class ExportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportForm));
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtMe = new TextBox();
            txtWho = new TextBox();
            txtWhy = new TextBox();
            txtFilePath = new TextBox();
            btnSelectFilePath = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 30);
            label1.TabIndex = 0;
            label1.Text = "Bakan Kişi : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 80);
            label2.Name = "label2";
            label2.Size = new Size(133, 30);
            label2.TabIndex = 1;
            label2.Text = "Bakılan Kişi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 124);
            label3.Name = "label3";
            label3.Size = new Size(170, 30);
            label3.TabIndex = 2;
            label3.Text = "Bakılma Sebebi : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 216);
            label4.Name = "label4";
            label4.Size = new Size(184, 30);
            label4.TabIndex = 3;
            label4.Text = "Kaydedilecek Yer : ";
            // 
            // txtMe
            // 
            txtMe.BorderStyle = BorderStyle.None;
            txtMe.Location = new Point(198, 33);
            txtMe.Name = "txtMe";
            txtMe.Size = new Size(213, 28);
            txtMe.TabIndex = 5;
            // 
            // txtWho
            // 
            txtWho.BorderStyle = BorderStyle.None;
            txtWho.Location = new Point(198, 77);
            txtWho.Name = "txtWho";
            txtWho.Size = new Size(213, 28);
            txtWho.TabIndex = 6;
            // 
            // txtWhy
            // 
            txtWhy.BorderStyle = BorderStyle.None;
            txtWhy.Location = new Point(198, 121);
            txtWhy.Name = "txtWhy";
            txtWhy.Size = new Size(213, 28);
            txtWhy.TabIndex = 7;
            // 
            // txtFilePath
            // 
            txtFilePath.BorderStyle = BorderStyle.None;
            txtFilePath.Location = new Point(198, 216);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(213, 28);
            txtFilePath.TabIndex = 8;
            // 
            // btnSelectFilePath
            // 
            btnSelectFilePath.BackColor = SystemColors.Control;
            btnSelectFilePath.Cursor = Cursors.Hand;
            btnSelectFilePath.FlatStyle = FlatStyle.Flat;
            btnSelectFilePath.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectFilePath.Location = new Point(417, 213);
            btnSelectFilePath.Name = "btnSelectFilePath";
            btnSelectFilePath.Size = new Size(50, 35);
            btnSelectFilePath.TabIndex = 10;
            btnSelectFilePath.Text = "Seç";
            btnSelectFilePath.UseVisualStyleBackColor = false;
            btnSelectFilePath.Click += btnSelectFilePath_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.Control;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(8, 308);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(471, 35);
            btnSave.TabIndex = 11;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ExportForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(491, 355);
            Controls.Add(btnSave);
            Controls.Add(btnSelectFilePath);
            Controls.Add(txtFilePath);
            Controls.Add(txtWhy);
            Controls.Add(txtWho);
            Controls.Add(txtMe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExportForm";
            Load += ExportForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMe;
        private TextBox txtWho;
        private TextBox txtWhy;
        private TextBox txtFilePath;
        private Button btnSelectFilePath;
        private Button btnSave;
    }
}