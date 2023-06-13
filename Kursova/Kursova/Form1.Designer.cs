namespace Kursova
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSave = new Button();
            saveFileDialog = new SaveFileDialog();
            pictureBoxFractal = new PictureBox();
            comboBoxFractals = new ComboBox();
            labelDepth = new Label();
            numericUpDownDepth = new NumericUpDown();
            buttonGenerate = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFractal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();

            // Кнопка Зберегти
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(760, 232);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 50);
            btnSave.TabIndex = 0;
            btnSave.Text = "Зберегти фото";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;

            //Діалогове вікно збереження фото
            saveFileDialog.Filter = "JPEG Image|*.jpg";
            saveFileDialog.Title = "Зберегти фрактал як зображення";

            //Вікно з фракталом
            pictureBoxFractal.BackColor = Color.FromArgb(224, 224, 224);
            pictureBoxFractal.BackgroundImage = (Image)resources.GetObject("pictureBoxFractal.BackgroundImage");
            pictureBoxFractal.BackgroundImageLayout = ImageLayout.None;
            pictureBoxFractal.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxFractal.Location = new Point(13, 12);
            pictureBoxFractal.Margin = new Padding(4);
            pictureBoxFractal.Name = "pictureBoxFractal";
            pictureBoxFractal.Size = new Size(595, 595);
            pictureBoxFractal.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFractal.TabIndex = 0;
            pictureBoxFractal.TabStop = false;
            pictureBoxFractal.Click += pictureBoxFractal_Click;

            // Згенеровані фрактали
            comboBoxFractals.AccessibleRole = AccessibleRole.MenuBar;
            comboBoxFractals.BackColor = Color.White;
            comboBoxFractals.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxFractals.ForeColor = Color.Black;
            comboBoxFractals.FormattingEnabled = true;
            comboBoxFractals.Items.AddRange(new object[] { "Трикутник Серпинського", "Ковер Серпинського", "Крива Пеано", "Крива Лева" });
            comboBoxFractals.Location = new Point(760, 56);
            comboBoxFractals.Margin = new Padding(4);
            comboBoxFractals.Name = "comboBoxFractals";
            comboBoxFractals.Size = new Size(199, 29);
            comboBoxFractals.TabIndex = 1;
            comboBoxFractals.SelectedIndexChanged += comboBoxFractals_SelectedIndexChanged;

            // Вибір глибини фракталу
            labelDepth.AutoSize = true;
            labelDepth.BackColor = Color.White;
            labelDepth.Cursor = Cursors.Help;
            labelDepth.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelDepth.ForeColor = Color.Black;
            labelDepth.Location = new Point(668, 107);
            labelDepth.Margin = new Padding(4, 0, 4, 0);
            labelDepth.Name = "labelDepth";
            labelDepth.Size = new Size(73, 21);
            labelDepth.TabIndex = 2;
            labelDepth.Text = "Глибина:";
            labelDepth.Click += labelDepth_Click;

            // Кнопочки вверх вниз у виборі глибини
            numericUpDownDepth.AccessibleRole = AccessibleRole.None;
            numericUpDownDepth.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownDepth.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownDepth.Location = new Point(760, 106);
            numericUpDownDepth.Margin = new Padding(4);
            numericUpDownDepth.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownDepth.Name = "numericUpDownDepth";
            numericUpDownDepth.Size = new Size(199, 28);
            numericUpDownDepth.TabIndex = 3;
            numericUpDownDepth.Value = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDownDepth.ValueChanged += numericUpDownDepth_ValueChanged;

            // Кнопка згенерувати
            buttonGenerate.BackColor = Color.White;
            buttonGenerate.BackgroundImageLayout = ImageLayout.None;
            buttonGenerate.Cursor = Cursors.Hand;
            buttonGenerate.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGenerate.ForeColor = Color.Black;
            buttonGenerate.Location = new Point(760, 162);
            buttonGenerate.Margin = new Padding(4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(199, 50);
            buttonGenerate.TabIndex = 4;
            buttonGenerate.Text = "Згенерувати фрактал";
            buttonGenerate.UseVisualStyleBackColor = false;
            buttonGenerate.Click += buttonGenerate_Click;

            // Текст тип фракталу
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Cursor = Cursors.Help;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(640, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 5;
            label1.Text = "Тип фракталу:";
            label1.Click += label1_Click;

            // Фотка збереження файлу
            pictureBox1.BackColor = Color.White;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(691, 232);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;

            // Фотка генерації фракталу (білий варіант лого)
            pictureBox2.BackColor = Color.White;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(692, 162);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;

            // текст інструкція
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Cursor = Cursors.Help;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(760, 339);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 8;
            label2.Text = "Інструкція";

            // Текст1 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Cursor = Cursors.Help;
            label3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(624, 373);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(396, 21);
            label3.TabIndex = 9;
            label3.Text = "1. Виберіть тип фракталу, який ви хочете згенерувати";

            // Текст 2
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Cursor = Cursors.Help;
            label4.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(624, 406);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(370, 21);
            label4.TabIndex = 10;
            label4.Text = "2. Вкажіть глибину фракталу (більше = красивіше)";
            label4.Click += label4_Click;

            // Текст 3
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Cursor = Cursors.Help;
            label5.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(624, 439);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(252, 21);
            label5.TabIndex = 11;
            label5.Text = "3. Натисніть згенерувати фрактал";
            label5.Click += label5_Click;

            // Текст автора 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Cursor = Cursors.Help;
            label6.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(871, 577);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 21);
            label6.TabIndex = 12;
            label6.Text = "Made by Synenko Andrii";
            
            // Фон
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1033, 620);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxFractal);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(buttonGenerate);
            Controls.Add(numericUpDownDepth);
            Controls.Add(labelDepth);
            Controls.Add(comboBoxFractals);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Генератор Фракталів";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFractal).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Діалогове Вікно кнопки зберегти
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxFractal.Image != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxFractal.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            else
            {
                MessageBox.Show("Спочатку згенеруйте фрактал.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private System.Windows.Forms.PictureBox pictureBoxFractal;
        private System.Windows.Forms.ComboBox comboBoxFractals;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.NumericUpDown numericUpDownDepth;
        private System.Windows.Forms.Button buttonGenerate;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
