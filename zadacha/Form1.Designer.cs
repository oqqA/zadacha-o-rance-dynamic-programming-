namespace zadacha
{
   partial class Form1
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
         this.richTextBox2 = new System.Windows.Forms.RichTextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.dataGridView2 = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
         this.SuspendLayout();
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
         this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
         this.dataGridView1.Location = new System.Drawing.Point(0, 0);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(383, 284);
         this.dataGridView1.TabIndex = 0;
         this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
         this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
         // 
         // Column1
         // 
         this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column1.HeaderText = "Название";
         this.Column1.Name = "Column1";
         // 
         // Column2
         // 
         this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column2.HeaderText = "Вес";
         this.Column2.Name = "Column2";
         // 
         // Column3
         // 
         this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.Column3.HeaderText = "Цена";
         this.Column3.Name = "Column3";
         // 
         // numericUpDown1
         // 
         this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.numericUpDown1.Location = new System.Drawing.Point(478, 129);
         this.numericUpDown1.MinimumSize = new System.Drawing.Size(151, 0);
         this.numericUpDown1.Name = "numericUpDown1";
         this.numericUpDown1.Size = new System.Drawing.Size(151, 20);
         this.numericUpDown1.TabIndex = 1;
         this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
         this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
         // 
         // richTextBox2
         // 
         this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
         this.richTextBox2.CausesValidation = false;
         this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.richTextBox2.Location = new System.Drawing.Point(383, 176);
         this.richTextBox2.Name = "richTextBox2";
         this.richTextBox2.ReadOnly = true;
         this.richTextBox2.Size = new System.Drawing.Size(253, 108);
         this.richTextBox2.TabIndex = 4;
         this.richTextBox2.Text = "";
         this.richTextBox2.WordWrap = false;
         // 
         // label2
         // 
         this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.label2.AutoSize = true;
         this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
         this.label2.Location = new System.Drawing.Point(483, 156);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(146, 13);
         this.label2.TabIndex = 5;
         this.label2.Text = "Вес = 0 Сумма рюкзака = 0";
         this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
         // 
         // dataGridView2
         // 
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4F, System.Drawing.FontStyle.Bold);
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
         dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
         this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
         this.dataGridView2.Location = new System.Drawing.Point(383, 0);
         this.dataGridView2.Name = "dataGridView2";
         this.dataGridView2.ReadOnly = true;
         this.dataGridView2.RowHeadersVisible = false;
         this.dataGridView2.Size = new System.Drawing.Size(253, 121);
         this.dataGridView2.TabIndex = 6;
         // 
         // label1
         // 
         this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(389, 131);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(76, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "Вес рюкзака:";
         // 
         // label3
         // 
         this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(389, 156);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(73, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Наш рюкзак:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(636, 284);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.dataGridView2);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.richTextBox2);
         this.Controls.Add(this.numericUpDown1);
         this.Controls.Add(this.dataGridView1);
         this.MinimumSize = new System.Drawing.Size(652, 323);
         this.Name = "Form1";
         this.Text = "Задача о ранце  (динамическое программирование). Пдо 33-15 Статенин Игорь ";
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView dataGridView1;
      private System.Windows.Forms.DataGridView dataGridView2;
      private System.Windows.Forms.NumericUpDown numericUpDown1;
      private System.Windows.Forms.RichTextBox richTextBox2;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
      private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label3;
   }
}

