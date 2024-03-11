namespace Tyuiu.GurbanovYA.Task1.V12
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonWrite_YA = new System.Windows.Forms.Button();
            this.фирмаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.процессорDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.частотаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оЗУDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жДDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.релизDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фирмаDataGridViewTextBoxColumn,
            this.процессорDataGridViewTextBoxColumn,
            this.частотаDataGridViewTextBoxColumn,
            this.оЗУDataGridViewTextBoxColumn,
            this.жДDataGridViewTextBoxColumn,
            this.релизDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.studentBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(14, 17);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(769, 387);
            this.dataGridView.TabIndex = 0;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(708, 415);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 23);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Читать ";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonWrite_YA
            // 
            this.buttonWrite_YA.Location = new System.Drawing.Point(627, 415);
            this.buttonWrite_YA.Name = "buttonWrite_YA";
            this.buttonWrite_YA.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite_YA.TabIndex = 2;
            this.buttonWrite_YA.Text = "Писать";
            this.buttonWrite_YA.UseVisualStyleBackColor = true;
            this.buttonWrite_YA.Click += new System.EventHandler(this.buttonWrite_YA_Click);
            // 
            // фирмаDataGridViewTextBoxColumn
            // 
            this.фирмаDataGridViewTextBoxColumn.DataPropertyName = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.HeaderText = "Фирма";
            this.фирмаDataGridViewTextBoxColumn.Name = "фирмаDataGridViewTextBoxColumn";
            // 
            // процессорDataGridViewTextBoxColumn
            // 
            this.процессорDataGridViewTextBoxColumn.DataPropertyName = "Процессор";
            this.процессорDataGridViewTextBoxColumn.HeaderText = "Процессор";
            this.процессорDataGridViewTextBoxColumn.Name = "процессорDataGridViewTextBoxColumn";
            // 
            // частотаDataGridViewTextBoxColumn
            // 
            this.частотаDataGridViewTextBoxColumn.DataPropertyName = "Частота";
            this.частотаDataGridViewTextBoxColumn.HeaderText = "Частота";
            this.частотаDataGridViewTextBoxColumn.Name = "частотаDataGridViewTextBoxColumn";
            // 
            // оЗУDataGridViewTextBoxColumn
            // 
            this.оЗУDataGridViewTextBoxColumn.DataPropertyName = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.HeaderText = "ОЗУ";
            this.оЗУDataGridViewTextBoxColumn.Name = "оЗУDataGridViewTextBoxColumn";
            // 
            // жДDataGridViewTextBoxColumn
            // 
            this.жДDataGridViewTextBoxColumn.DataPropertyName = "ЖД";
            this.жДDataGridViewTextBoxColumn.HeaderText = "ЖД";
            this.жДDataGridViewTextBoxColumn.Name = "жДDataGridViewTextBoxColumn";
            // 
            // релизDataGridViewTextBoxColumn
            // 
            this.релизDataGridViewTextBoxColumn.DataPropertyName = "Релиз";
            this.релизDataGridViewTextBoxColumn.HeaderText = "Релиз";
            this.релизDataGridViewTextBoxColumn.Name = "релизDataGridViewTextBoxColumn";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataSource = typeof(Tyuiu.GurbanovYA.Task1.V12.Student);
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataSource = typeof(Tyuiu.GurbanovYA.Task1.V12.Student);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Tyuiu.GurbanovYA.Task1.V12.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonWrite_YA);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonWrite_YA;
        private System.Windows.Forms.DataGridViewTextBoxColumn фирмаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn процессорDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn частотаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оЗУDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жДDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn релизDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private System.Windows.Forms.BindingSource studentBindingSource2;
    }
}

