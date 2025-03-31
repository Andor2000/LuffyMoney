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
            components = new System.ComponentModel.Container();
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
            textBox9 = new TextBox();
            label16 = new Label();
            label15 = new Label();
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
            bindingSource1 = new BindingSource(components);
            Column10 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
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
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(816, 497);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(733, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список игроков";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(22, 51);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 42);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 129);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(727, 331);
            dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.FillWeight = 200F;
            Column1.Frozen = true;
            Column1.HeaderText = "Ник";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.FillWeight = 200F;
            Column2.Frozen = true;
            Column2.HeaderText = "Куплено голд";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.FillWeight = 200F;
            Column3.Frozen = true;
            Column3.HeaderText = "Потрачено чм";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.FillWeight = 200F;
            Column4.Frozen = true;
            Column4.HeaderText = "Доступно чм";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Ник игрока";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(733, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавить игрока";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(345, 205);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 6;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(248, 205);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 5;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(248, 135);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 42);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(248, 111);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 3;
            label2.Text = "Ник игрока";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox9);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(textBox3);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(label3);
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(733, 464);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Покупка голд";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox9.Location = new Point(352, 160);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(233, 39);
            textBox9.TabIndex = 8;
            textBox9.Enter += textBox9_Enter;
            textBox9.KeyDown += textBox_KeyDown;
            textBox9.KeyPress += textBox_KeyPress;
            textBox9.KeyUp += textBox9_KeyUp;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(352, 136);
            label16.Name = "label16";
            label16.Size = new Size(106, 20);
            label16.TabIndex = 7;
            label16.Text = "Добавится чм";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(352, 208);
            label15.Name = "label15";
            label15.Size = new Size(208, 20);
            label15.TabIndex = 6;
            label15.Text = "Можно закупиться на 0 голд";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(514, 33);
            label9.Name = "label9";
            label9.Size = new Size(63, 40);
            label9.TabIndex = 5;
            label9.Text = "голд 1:2\r\nчм 1:58";
            // 
            // button3
            // 
            button3.Location = new Point(229, 248);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(234, 59);
            button3.TabIndex = 4;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(99, 160);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 39);
            textBox3.TabIndex = 3;
            textBox3.KeyDown += textBox_KeyDown;
            textBox3.KeyPress += textBox_KeyPress;
            textBox3.KeyUp += textBox3_KeyUp;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(99, 136);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 2;
            label4.Text = "Количество голд";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(230, 36);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 1;
            label3.Text = "Выберите игрока";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 64);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(234, 40);
            comboBox1.TabIndex = 0;
            comboBox1.KeyUp += comboBox1_KeyUp;
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
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(733, 464);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Списание чм";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(242, 219);
            label11.Name = "label11";
            label11.Size = new Size(129, 20);
            label11.TabIndex = 11;
            label11.Text = "Доступно : 500чм";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(514, 33);
            label10.Name = "label10";
            label10.Size = new Size(63, 40);
            label10.TabIndex = 10;
            label10.Text = "голд 1:2\r\nчм 1:58";
            // 
            // button4
            // 
            button4.Location = new Point(242, 263);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(234, 59);
            button4.TabIndex = 9;
            button4.Text = "Сохранить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(243, 175);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(233, 39);
            textBox4.TabIndex = 8;
            textBox4.KeyDown += textBox_KeyDown;
            textBox4.KeyPress += textBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(243, 151);
            label5.Name = "label5";
            label5.Size = new Size(113, 20);
            label5.TabIndex = 7;
            label5.Text = "Количество чм";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(243, 51);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 6;
            label6.Text = "Выберите игрока";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(242, 79);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(234, 40);
            comboBox2.TabIndex = 5;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            comboBox2.KeyUp += comboBox1_KeyUp;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(textBox8);
            tabPage6.Controls.Add(label14);
            tabPage6.Controls.Add(button6);
            tabPage6.Controls.Add(dataGridView2);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(808, 464);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "История";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox8.Location = new Point(9, 25);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(182, 42);
            textBox8.TabIndex = 4;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(9, 1);
            label14.Name = "label14";
            label14.Size = new Size(88, 20);
            label14.TabIndex = 3;
            label14.Text = "Ник игрока";
            // 
            // button6
            // 
            button6.Location = new Point(545, 25);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(125, 43);
            button6.TabIndex = 1;
            button6.Text = "Удалить";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column10, Column5, Column6, Column7, Column8, Column9 });
            dataGridView2.Dock = DockStyle.Bottom;
            dataGridView2.Location = new Point(0, 113);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(808, 351);
            dataGridView2.TabIndex = 0;
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
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(733, 464);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Настройки";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(246, 357);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(234, 59);
            button7.TabIndex = 19;
            button7.Text = "Сохранить";
            button7.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(374, 267);
            label13.Name = "label13";
            label13.Size = new Size(107, 20);
            label13.TabIndex = 18;
            label13.Text = "Изменить ник";
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(374, 291);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(233, 39);
            textBox7.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(134, 267);
            label12.Name = "label12";
            label12.Size = new Size(130, 20);
            label12.TabIndex = 16;
            label12.Text = "Выберите игрока";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(133, 291);
            comboBox3.Margin = new Padding(3, 4, 3, 4);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(234, 40);
            comboBox3.TabIndex = 15;
            comboBox3.KeyUp += comboBox1_KeyUp;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(374, 108);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(233, 39);
            textBox6.TabIndex = 14;
            textBox6.Text = "58";
            textBox6.KeyDown += textBox_KeyDown;
            textBox6.KeyPress += textBox_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(374, 84);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 13;
            label8.Text = "Голд за 1 чм";
            // 
            // button5
            // 
            button5.Location = new Point(246, 177);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(234, 59);
            button5.TabIndex = 12;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(134, 108);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 39);
            textBox5.TabIndex = 11;
            textBox5.Text = "2";
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 84);
            label7.Name = "label7";
            label7.Size = new Size(106, 20);
            label7.TabIndex = 10;
            label7.Text = "Руб за 1к голд";
            // 
            // Column10
            // 
            Column10.Frozen = true;
            Column10.HeaderText = "ID";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column5
            // 
            Column5.Frozen = true;
            Column5.HeaderText = "Ник";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.Frozen = true;
            Column6.HeaderText = "Дата";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.Frozen = true;
            Column7.HeaderText = "Тип операции";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.Frozen = true;
            Column8.HeaderText = "Количество";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.Frozen = true;
            Column9.HeaderText = "Приход/Расход ЧМ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 497);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
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
        private BindingSource bindingSource1;
        private Label label15;
        private TextBox textBox9;
        private Label label16;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}
