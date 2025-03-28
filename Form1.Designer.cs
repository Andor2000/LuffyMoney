namespace LuffyMoney
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            label9 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            tabPage4 = new TabPage();
            label11 = new Label();
            label10 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            tabPage6 = new TabPage();
            textBox8 = new TextBox();
            label14 = new Label();
            button6 = new Button();
            dataGridView2 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            button7 = new Button();
            label13 = new Label();
            textBox7 = new TextBox();
            label12 = new Label();
            comboBox3 = new ComboBox();
            textBox6 = new TextBox();
            label8 = new Label();
            button5 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(648, 373);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(640, 345);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список игроков";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(19, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 35);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(634, 248);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.Frozen = true;
            Column1.HeaderText = "Ник";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 200F;
            Column2.Frozen = true;
            Column2.HeaderText = "Куплено голды";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 200F;
            Column3.Frozen = true;
            Column3.HeaderText = "Потрачено чм";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 200F;
            Column4.Frozen = true;
            Column4.HeaderText = "Доступно чм";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 20);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Ник игрока";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(640, 345);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить игрока";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(302, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(217, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(217, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(160, 35);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 83);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Ник игрока";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(640, 345);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Покупка голды";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(450, 25);
            label9.Name = "label9";
            label9.Size = new Size(50, 30);
            label9.TabIndex = 5;
            label9.Text = "голд 1:2\r\nчм 1:58";
            // 
            // button3
            // 
            button3.Location = new Point(200, 186);
            button3.Name = "button3";
            button3.Size = new Size(205, 44);
            button3.TabIndex = 4;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(201, 120);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(204, 33);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 102);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 2;
            label4.Text = "Количество голды";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 27);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 1;
            label3.Text = "Выберите игрока";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(205, 33);
            comboBox1.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(textBox4);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(comboBox2);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(640, 345);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Списание чм";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(215, 171);
            label11.Name = "label11";
            label11.Size = new Size(103, 15);
            label11.TabIndex = 11;
            label11.Text = "Доступно : 500чм";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(450, 25);
            label10.Name = "label10";
            label10.Size = new Size(50, 30);
            label10.TabIndex = 10;
            label10.Text = "голд 1:2\r\nчм 1:58";
            // 
            // button4
            // 
            button4.Location = new Point(212, 197);
            button4.Name = "button4";
            button4.Size = new Size(205, 44);
            button4.TabIndex = 9;
            button4.Text = "Сохранить";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(213, 131);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(204, 33);
            textBox4.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 113);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 7;
            label5.Text = "Количество чм";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 38);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 6;
            label6.Text = "Выберите игрока";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(212, 59);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(205, 33);
            comboBox2.TabIndex = 5;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBox8);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(dataGridView2);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(640, 345);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "История";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox8.Location = new Point(8, 19);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(160, 35);
            textBox8.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(8, 1);
            label14.Name = "label14";
            label14.Size = new Size(70, 15);
            label14.TabIndex = 3;
            label14.Text = "Ник игрока";
            // 
            // button6
            // 
            button6.Location = new Point(477, 19);
            button6.Name = "button6";
            button6.Size = new Size(109, 32);
            button6.TabIndex = 1;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column5, Column6, Column7, Column8, Column9 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 82);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(640, 263);
            dataGridView2.TabIndex = 0;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Ник";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Дата";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "Тип операции";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "Количество";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // Column9
            // 
            Column9.Frozen = true;
            Column9.HeaderText = "Получено чм";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(button7);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(textBox7);
            tabPage5.Controls.Add(label12);
            tabPage5.Controls.Add(comboBox3);
            tabPage5.Controls.Add(textBox6);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(button5);
            tabPage5.Controls.Add(textBox5);
            tabPage5.Controls.Add(label7);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(640, 345);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Настройки";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(215, 268);
            button7.Name = "button7";
            button7.Size = new Size(205, 44);
            button7.TabIndex = 19;
            button7.Text = "Сохранить";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(327, 200);
            label13.Name = "label13";
            label13.Size = new Size(84, 15);
            label13.TabIndex = 18;
            label13.Text = "Изменить ник";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(327, 218);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(204, 33);
            textBox7.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(117, 200);
            label12.Name = "label12";
            label12.Size = new Size(102, 15);
            label12.TabIndex = 16;
            label12.Text = "Выберите игрока";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(116, 218);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(205, 33);
            comboBox3.TabIndex = 15;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(327, 81);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(204, 33);
            textBox6.TabIndex = 14;
            textBox6.Text = "58";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 63);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 13;
            label8.Text = "Голд за 1 чм";
            // 
            // button5
            // 
            button5.Location = new Point(215, 133);
            button5.Name = "button5";
            button5.Size = new Size(205, 44);
            button5.TabIndex = 12;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(117, 81);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 33);
            textBox5.TabIndex = 11;
            textBox5.Text = "2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(117, 63);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 10;
            label7.Text = "Руб за 1к голды";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 373);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        private ComboBox comboBox1;
        private Button button3;
        private TextBox textBox3;
        private Label label4;
        private Label label3;
        private Button button4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private TextBox textBox6;
        private Label label8;
        private Button button5;
        private TextBox textBox5;
        private Label label7;
        private TabPage tabPage6;
        private Button button6;
        private DataGridView dataGridView2;
        private Label label9;
        private Label label11;
        private Label label10;
        private Button button7;
        private Label label13;
        private TextBox textBox7;
        private Label label12;
        private ComboBox comboBox3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBox8;
        private Label label14;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
