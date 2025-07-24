namespace SecureCrypt
{
    partial class mainForm
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
            TitleLabel = new Label();
            EncryptionPanel = new Panel();
            btnEncrypt = new Button();
            progressBarEncrypt = new ProgressBar();
            ResultEncrypt = new TextBox();
            label5 = new Label();
            InputKeyEncrypt = new TextBox();
            label4 = new Label();
            InputTextToEncrypt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            DecryptionPanel = new Panel();
            btnDecrypt = new Button();
            progressBarDecrypt = new ProgressBar();
            ResultDecrypt = new TextBox();
            label6 = new Label();
            InputKeyDecrypt = new TextBox();
            label7 = new Label();
            InputTextToDecrypt = new TextBox();
            label8 = new Label();
            label2 = new Label();
            btnRest = new Button();
            EncryptionPanel.SuspendLayout();
            DecryptionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TitleLabel.ForeColor = Color.Green;
            TitleLabel.Location = new Point(381, 16);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(177, 31);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "SecureCrypt";
            // 
            // EncryptionPanel
            // 
            EncryptionPanel.Controls.Add(btnEncrypt);
            EncryptionPanel.Controls.Add(progressBarEncrypt);
            EncryptionPanel.Controls.Add(ResultEncrypt);
            EncryptionPanel.Controls.Add(label5);
            EncryptionPanel.Controls.Add(InputKeyEncrypt);
            EncryptionPanel.Controls.Add(label4);
            EncryptionPanel.Controls.Add(InputTextToEncrypt);
            EncryptionPanel.Controls.Add(label3);
            EncryptionPanel.Controls.Add(label1);
            EncryptionPanel.Location = new Point(33, 68);
            EncryptionPanel.Name = "EncryptionPanel";
            EncryptionPanel.Size = new Size(423, 378);
            EncryptionPanel.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(111, 166);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(197, 41);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // progressBarEncrypt
            // 
            progressBarEncrypt.Location = new Point(20, 231);
            progressBarEncrypt.Name = "progressBarEncrypt";
            progressBarEncrypt.Size = new Size(378, 34);
            progressBarEncrypt.TabIndex = 12;
            // 
            // ResultEncrypt
            // 
            ResultEncrypt.Location = new Point(20, 303);
            ResultEncrypt.Multiline = true;
            ResultEncrypt.Name = "ResultEncrypt";
            ResultEncrypt.Size = new Size(378, 61);
            ResultEncrypt.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 283);
            label5.Name = "label5";
            label5.Size = new Size(103, 16);
            label5.TabIndex = 10;
            label5.Text = "Encrypted Text :";
            // 
            // InputKeyEncrypt
            // 
            InputKeyEncrypt.Location = new Point(20, 124);
            InputKeyEncrypt.Name = "InputKeyEncrypt";
            InputKeyEncrypt.PlaceholderText = "2 by default";
            InputKeyEncrypt.Size = new Size(378, 23);
            InputKeyEncrypt.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 101);
            label4.Name = "label4";
            label4.Size = new Size(134, 16);
            label4.TabIndex = 8;
            label4.Text = "Enter encryption key :";
            // 
            // InputTextToEncrypt
            // 
            InputTextToEncrypt.Location = new Point(20, 63);
            InputTextToEncrypt.Name = "InputTextToEncrypt";
            InputTextToEncrypt.Size = new Size(378, 23);
            InputTextToEncrypt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 40);
            label3.Name = "label3";
            label3.Size = new Size(128, 16);
            label3.TabIndex = 6;
            label3.Text = "Enter text to encrypt :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 10);
            label1.Name = "label1";
            label1.Size = new Size(114, 25);
            label1.TabIndex = 5;
            label1.Text = "Encryption";
            // 
            // DecryptionPanel
            // 
            DecryptionPanel.Controls.Add(btnDecrypt);
            DecryptionPanel.Controls.Add(progressBarDecrypt);
            DecryptionPanel.Controls.Add(ResultDecrypt);
            DecryptionPanel.Controls.Add(label6);
            DecryptionPanel.Controls.Add(InputKeyDecrypt);
            DecryptionPanel.Controls.Add(label7);
            DecryptionPanel.Controls.Add(InputTextToDecrypt);
            DecryptionPanel.Controls.Add(label8);
            DecryptionPanel.Controls.Add(label2);
            DecryptionPanel.Location = new Point(493, 68);
            DecryptionPanel.Name = "DecryptionPanel";
            DecryptionPanel.Size = new Size(423, 378);
            DecryptionPanel.TabIndex = 4;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(117, 166);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(197, 41);
            btnDecrypt.TabIndex = 15;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // progressBarDecrypt
            // 
            progressBarDecrypt.Location = new Point(26, 231);
            progressBarDecrypt.Name = "progressBarDecrypt";
            progressBarDecrypt.Size = new Size(378, 34);
            progressBarDecrypt.TabIndex = 20;
            // 
            // ResultDecrypt
            // 
            ResultDecrypt.Location = new Point(26, 303);
            ResultDecrypt.Multiline = true;
            ResultDecrypt.Name = "ResultDecrypt";
            ResultDecrypt.Size = new Size(378, 61);
            ResultDecrypt.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 283);
            label6.Name = "label6";
            label6.Size = new Size(105, 16);
            label6.TabIndex = 18;
            label6.Text = "Decrypted Text :";
            // 
            // InputKeyDecrypt
            // 
            InputKeyDecrypt.Location = new Point(26, 124);
            InputKeyDecrypt.Name = "InputKeyDecrypt";
            InputKeyDecrypt.PlaceholderText = "2 by default";
            InputKeyDecrypt.Size = new Size(378, 23);
            InputKeyDecrypt.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(26, 101);
            label7.Name = "label7";
            label7.Size = new Size(135, 16);
            label7.TabIndex = 17;
            label7.Text = "Enter decryption key :";
            // 
            // InputTextToDecrypt
            // 
            InputTextToDecrypt.Location = new Point(26, 63);
            InputTextToDecrypt.Name = "InputTextToDecrypt";
            InputTextToDecrypt.Size = new Size(378, 23);
            InputTextToDecrypt.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(26, 40);
            label8.Name = "label8";
            label8.Size = new Size(129, 16);
            label8.TabIndex = 16;
            label8.Text = "Enter text to decrypt :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 10);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 5;
            label2.Text = "Decryption";
            // 
            // btnRest
            // 
            btnRest.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRest.Location = new Point(390, 465);
            btnRest.Name = "btnRest";
            btnRest.Size = new Size(159, 42);
            btnRest.TabIndex = 5;
            btnRest.Text = "Rest";
            btnRest.UseVisualStyleBackColor = true;
            btnRest.Click += btnRest_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 529);
            Controls.Add(btnRest);
            Controls.Add(DecryptionPanel);
            Controls.Add(EncryptionPanel);
            Controls.Add(TitleLabel);
            Name = "mainForm";
            Text = "SecureCrypt";
            EncryptionPanel.ResumeLayout(false);
            EncryptionPanel.PerformLayout();
            DecryptionPanel.ResumeLayout(false);
            DecryptionPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Panel EncryptionPanel;
        private TextBox InputTextToEncrypt;
        private Label label3;
        private Label label1;
        private Panel DecryptionPanel;
        private Label label2;
        private TextBox ResultEncrypt;
        private Label label5;
        private TextBox InputKeyEncrypt;
        private Label label4;
        private ProgressBar progressBarEncrypt;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private ProgressBar progressBarDecrypt;
        private TextBox ResultDecrypt;
        private Label label6;
        private TextBox InputKeyDecrypt;
        private Label label7;
        private TextBox InputTextToDecrypt;
        private Label label8;
        private Button btnRest;
    }
}
