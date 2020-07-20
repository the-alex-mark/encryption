namespace Encryption
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elem_encrypt = new System.Windows.Forms.Button();
            this.elem_clear = new System.Windows.Forms.Button();
            this.elem_sourceText = new System.Windows.Forms.TextBox();
            this.elem_key = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.elem_alphabet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.elem_cipherText = new System.Windows.Forms.TextBox();
            this.elem_RU = new System.Windows.Forms.RadioButton();
            this.elem_EN = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.elem_key)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходные данные:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label2.Location = new System.Drawing.Point(498, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ:";
            // 
            // elem_encrypt
            // 
            this.elem_encrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.elem_encrypt.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.elem_encrypt.Location = new System.Drawing.Point(337, 287);
            this.elem_encrypt.Name = "elem_encrypt";
            this.elem_encrypt.Size = new System.Drawing.Size(121, 23);
            this.elem_encrypt.TabIndex = 4;
            this.elem_encrypt.Text = "Зашифровать";
            this.elem_encrypt.UseVisualStyleBackColor = true;
            this.elem_encrypt.Click += new System.EventHandler(this.elem_encrypt_Click);
            // 
            // elem_clear
            // 
            this.elem_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.elem_clear.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.elem_clear.Location = new System.Drawing.Point(464, 287);
            this.elem_clear.Name = "elem_clear";
            this.elem_clear.Size = new System.Drawing.Size(121, 23);
            this.elem_clear.TabIndex = 5;
            this.elem_clear.Text = "Очистить";
            this.elem_clear.UseVisualStyleBackColor = true;
            this.elem_clear.Click += new System.EventHandler(this.elem_clear_Click);
            // 
            // elem_sourceText
            // 
            this.elem_sourceText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elem_sourceText.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.elem_sourceText.Location = new System.Drawing.Point(15, 28);
            this.elem_sourceText.Name = "elem_sourceText";
            this.elem_sourceText.Size = new System.Drawing.Size(479, 21);
            this.elem_sourceText.TabIndex = 0;
            this.elem_sourceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.elem_sourceText_KeyPress);
            this.elem_sourceText.KeyUp += new System.Windows.Forms.KeyEventHandler(this.elem_sourceText_KeyUp);
            // 
            // elem_key
            // 
            this.elem_key.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elem_key.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.elem_key.Location = new System.Drawing.Point(501, 28);
            this.elem_key.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.elem_key.Name = "elem_key";
            this.elem_key.Size = new System.Drawing.Size(83, 21);
            this.elem_key.TabIndex = 1;
            this.elem_key.ValueChanged += new System.EventHandler(this.elem_key_ValueChanged);
            this.elem_key.KeyUp += new System.Windows.Forms.KeyEventHandler(this.elem_key_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.elem_alphabet);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.groupBox1.Location = new System.Drawing.Point(15, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Алфавит  ";
            // 
            // elem_alphabet
            // 
            this.elem_alphabet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elem_alphabet.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.elem_alphabet.Location = new System.Drawing.Point(3, 17);
            this.elem_alphabet.Name = "elem_alphabet";
            this.elem_alphabet.Size = new System.Drawing.Size(563, 157);
            this.elem_alphabet.TabIndex = 0;
            this.elem_alphabet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Результат:";
            // 
            // elem_cipherText
            // 
            this.elem_cipherText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elem_cipherText.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.elem_cipherText.Location = new System.Drawing.Point(15, 259);
            this.elem_cipherText.Name = "elem_cipherText";
            this.elem_cipherText.ReadOnly = true;
            this.elem_cipherText.Size = new System.Drawing.Size(569, 21);
            this.elem_cipherText.TabIndex = 2;
            // 
            // elem_RU
            // 
            this.elem_RU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elem_RU.AutoSize = true;
            this.elem_RU.Checked = true;
            this.elem_RU.Location = new System.Drawing.Point(15, 288);
            this.elem_RU.Name = "elem_RU";
            this.elem_RU.Size = new System.Drawing.Size(89, 20);
            this.elem_RU.TabIndex = 2;
            this.elem_RU.TabStop = true;
            this.elem_RU.Text = "Кириллица";
            this.elem_RU.UseVisualStyleBackColor = true;
            this.elem_RU.CheckedChanged += new System.EventHandler(this.elem_RU_CheckedChanged);
            // 
            // elem_EN
            // 
            this.elem_EN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elem_EN.AutoSize = true;
            this.elem_EN.Location = new System.Drawing.Point(110, 288);
            this.elem_EN.Name = "elem_EN";
            this.elem_EN.Size = new System.Drawing.Size(81, 20);
            this.elem_EN.TabIndex = 3;
            this.elem_EN.Text = "Латиница";
            this.elem_EN.UseVisualStyleBackColor = true;
            this.elem_EN.CheckedChanged += new System.EventHandler(this.elem_EN_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(596, 322);
            this.Controls.Add(this.elem_EN);
            this.Controls.Add(this.elem_RU);
            this.Controls.Add(this.elem_cipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.elem_key);
            this.Controls.Add(this.elem_sourceText);
            this.Controls.Add(this.elem_clear);
            this.Controls.Add(this.elem_encrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шифр \"Цезаря\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elem_key)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button elem_encrypt;
        private System.Windows.Forms.Button elem_clear;
        private System.Windows.Forms.TextBox elem_sourceText;
        private System.Windows.Forms.NumericUpDown elem_key;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label elem_alphabet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox elem_cipherText;
        private System.Windows.Forms.RadioButton elem_RU;
        private System.Windows.Forms.RadioButton elem_EN;
    }
}

