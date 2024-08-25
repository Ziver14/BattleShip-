namespace SeaBatle
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
            button21 = new Button();
            textBox1 = new TextBox();
            button22 = new Button();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button133 = new Button();
            button134 = new Button();
            checkBox2 = new CheckBox();
            dataGridView1 = new DataGridView();
            А = new DataGridViewTextBoxColumn();
            Б = new DataGridViewTextBoxColumn();
            В = new DataGridViewTextBoxColumn();
            Г = new DataGridViewTextBoxColumn();
            Д = new DataGridViewTextBoxColumn();
            Е = new DataGridViewTextBoxColumn();
            Ж = new DataGridViewTextBoxColumn();
            З = new DataGridViewTextBoxColumn();
            И = new DataGridViewTextBoxColumn();
            К = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button21
            // 
            button21.Location = new Point(755, 61);
            button21.Margin = new Padding(3, 4, 3, 4);
            button21.Name = "button21";
            button21.Size = new Size(139, 42);
            button21.TabIndex = 22;
            button21.Text = "Выстрел";
            button21.UseVisualStyleBackColor = true;
            button21.Click += button21_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(755, 199);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 27);
            textBox1.TabIndex = 23;
            // 
            // button22
            // 
            button22.Location = new Point(755, 129);
            button22.Margin = new Padding(3, 4, 3, 4);
            button22.Name = "button22";
            button22.Size = new Size(140, 41);
            button22.TabIndex = 24;
            button22.Text = "Автовыстрел";
            button22.UseVisualStyleBackColor = true;
            button22.Click += button22_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(645, 242);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Вниз";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(645, 326);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(45, 24);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "x1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(645, 351);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(45, 24);
            radioButton2.TabIndex = 27;
            radioButton2.Text = "x2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(645, 379);
            radioButton3.Margin = new Padding(3, 4, 3, 4);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(45, 24);
            radioButton3.TabIndex = 28;
            radioButton3.Text = "x3";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(645, 413);
            radioButton4.Margin = new Padding(3, 4, 3, 4);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(45, 24);
            radioButton4.TabIndex = 29;
            radioButton4.Text = "x4";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button133
            // 
            button133.Location = new Point(755, 273);
            button133.Margin = new Padding(3, 4, 3, 4);
            button133.Name = "button133";
            button133.Size = new Size(141, 45);
            button133.TabIndex = 30;
            button133.Text = "Поставить";
            button133.UseVisualStyleBackColor = true;
            button133.Click += button133_Click;
            // 
            // button134
            // 
            button134.Location = new Point(755, 326);
            button134.Margin = new Padding(3, 4, 3, 4);
            button134.Name = "button134";
            button134.Size = new Size(139, 51);
            button134.TabIndex = 31;
            button134.Text = "Перерисовать";
            button134.UseVisualStyleBackColor = true;
            button134.Click += button134_Click;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(645, 274);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(87, 24);
            checkBox2.TabIndex = 32;
            checkBox2.Text = "Удалить";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Click += checkBox2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { А, Б, В, Г, Д, Е, Ж, З, И, К });
            dataGridView1.Location = new Point(234, 76);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 25;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(256, 312);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // А
            // 
            А.HeaderText = "А";
            А.MinimumWidth = 6;
            А.Name = "А";
            А.Width = 23;
            // 
            // Б
            // 
            Б.HeaderText = "Б";
            Б.MinimumWidth = 6;
            Б.Name = "Б";
            Б.Width = 25;
            // 
            // В
            // 
            В.HeaderText = "В";
            В.MinimumWidth = 6;
            В.Name = "В";
            В.Width = 25;
            // 
            // Г
            // 
            Г.HeaderText = "Г";
            Г.MinimumWidth = 6;
            Г.Name = "Г";
            Г.Width = 25;
            // 
            // Д
            // 
            Д.HeaderText = "Д";
            Д.MinimumWidth = 6;
            Д.Name = "Д";
            Д.Width = 25;
            // 
            // Е
            // 
            Е.HeaderText = "Е";
            Е.MinimumWidth = 6;
            Е.Name = "Е";
            Е.Width = 25;
            // 
            // Ж
            // 
            Ж.HeaderText = "Ж";
            Ж.MinimumWidth = 6;
            Ж.Name = "Ж";
            Ж.Width = 25;
            // 
            // З
            // 
            З.HeaderText = "З";
            З.MinimumWidth = 6;
            З.Name = "З";
            З.Width = 25;
            // 
            // И
            // 
            И.HeaderText = "И";
            И.MinimumWidth = 6;
            И.Name = "И";
            И.Width = 25;
            // 
            // К
            // 
            К.HeaderText = "К";
            К.MinimumWidth = 6;
            К.Name = "К";
            К.Width = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 600);
            Controls.Add(dataGridView1);
            Controls.Add(checkBox2);
            Controls.Add(button134);
            Controls.Add(button133);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(button22);
            Controls.Add(textBox1);
            Controls.Add(button21);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button21;
        private TextBox textBox1;
        private Button button22;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button133;
        private Button button134;
        private CheckBox checkBox2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn А;
        private DataGridViewTextBoxColumn Б;
        private DataGridViewTextBoxColumn В;
        private DataGridViewTextBoxColumn Г;
        private DataGridViewTextBoxColumn Д;
        private DataGridViewTextBoxColumn Е;
        private DataGridViewTextBoxColumn Ж;
        private DataGridViewTextBoxColumn З;
        private DataGridViewTextBoxColumn И;
        private DataGridViewTextBoxColumn К;
    }
}