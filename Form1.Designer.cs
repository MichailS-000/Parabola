namespace Parabola
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 1D);
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.newDataButton = new System.Windows.Forms.Button();
			this.numberB = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.numberA = new System.Windows.Forms.NumericUpDown();
			this.numberC = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.succsessfulTryes = new System.Windows.Forms.Label();
			this.fullTryes = new System.Windows.Forms.Label();
			this.Table = new System.Windows.Forms.DataGridView();
			this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberA)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberC)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			this.chart1.Location = new System.Drawing.Point(12, 12);
			this.chart1.Name = "chart1";
			series3.BorderWidth = 3;
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series3.Color = System.Drawing.Color.Lime;
			series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series3.Name = "Series1";
			series3.Points.Add(dataPoint3);
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(400, 400);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// newDataButton
			// 
			this.newDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.newDataButton.Location = new System.Drawing.Point(418, 12);
			this.newDataButton.Name = "newDataButton";
			this.newDataButton.Size = new System.Drawing.Size(345, 36);
			this.newDataButton.TabIndex = 1;
			this.newDataButton.Text = "Новые даные";
			this.newDataButton.UseVisualStyleBackColor = true;
			this.newDataButton.Click += new System.EventHandler(this.NewData);
			// 
			// numberB
			// 
			this.numberB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberB.Location = new System.Drawing.Point(568, 54);
			this.numberB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numberB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.numberB.Name = "numberB";
			this.numberB.Size = new System.Drawing.Size(39, 26);
			this.numberB.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.label1.Location = new System.Drawing.Point(420, 51);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(267, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "f(x) =      x +      x +     ";
			// 
			// numberA
			// 
			this.numberA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberA.Location = new System.Drawing.Point(489, 54);
			this.numberA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numberA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.numberA.Name = "numberA";
			this.numberA.Size = new System.Drawing.Size(37, 26);
			this.numberA.TabIndex = 2;
			// 
			// numberC
			// 
			this.numberC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.numberC.Location = new System.Drawing.Point(649, 54);
			this.numberC.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numberC.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
			this.numberC.Name = "numberC";
			this.numberC.Size = new System.Drawing.Size(38, 26);
			this.numberC.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Silver;
			this.label3.Location = new System.Drawing.Point(542, 51);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(13, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Silver;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(421, 387);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(186, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Правильно:      из";
			// 
			// succsessfulTryes
			// 
			this.succsessfulTryes.AutoSize = true;
			this.succsessfulTryes.BackColor = System.Drawing.Color.Silver;
			this.succsessfulTryes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.succsessfulTryes.Location = new System.Drawing.Point(548, 387);
			this.succsessfulTryes.Name = "succsessfulTryes";
			this.succsessfulTryes.Size = new System.Drawing.Size(24, 25);
			this.succsessfulTryes.TabIndex = 8;
			this.succsessfulTryes.Text = "0";
			// 
			// fullTryes
			// 
			this.fullTryes.AutoSize = true;
			this.fullTryes.BackColor = System.Drawing.Color.Silver;
			this.fullTryes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fullTryes.Location = new System.Drawing.Point(603, 387);
			this.fullTryes.Name = "fullTryes";
			this.fullTryes.Size = new System.Drawing.Size(24, 25);
			this.fullTryes.TabIndex = 9;
			this.fullTryes.Text = "0";
			// 
			// Table
			// 
			this.Table.AllowUserToAddRows = false;
			this.Table.AllowUserToDeleteRows = false;
			this.Table.AllowUserToResizeColumns = false;
			this.Table.AllowUserToResizeRows = false;
			this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
			this.Table.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.Table.Location = new System.Drawing.Point(418, 96);
			this.Table.Name = "Table";
			this.Table.RowHeadersVisible = false;
			this.Table.Size = new System.Drawing.Size(196, 260);
			this.Table.TabIndex = 10;
			// 
			// X
			// 
			this.X.HeaderText = "X";
			this.X.Name = "X";
			// 
			// Y
			// 
			this.Y.HeaderText = "f(x)";
			this.Y.Name = "Y";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(775, 419);
			this.Controls.Add(this.Table);
			this.Controls.Add(this.fullTryes);
			this.Controls.Add(this.succsessfulTryes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.numberC);
			this.Controls.Add(this.numberA);
			this.Controls.Add(this.numberB);
			this.Controls.Add(this.newDataButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chart1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "Form1";
			this.Text = "Парабола тест";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberA)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberC)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button newDataButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberB;
        private System.Windows.Forms.NumericUpDown numberA;
        private System.Windows.Forms.NumericUpDown numberC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label succsessfulTryes;
        private System.Windows.Forms.Label fullTryes;
		private System.Windows.Forms.DataGridView Table;
		private System.Windows.Forms.DataGridViewTextBoxColumn X;
		private System.Windows.Forms.DataGridViewTextBoxColumn Y;
	}
}

