namespace View
{
    partial class MainView
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
            this.btnGetData = new System.Windows.Forms.Button();
            this.mainData = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DirectionGB = new System.Windows.Forms.GroupBox();
            this.sourcesCB1 = new System.Windows.Forms.ComboBox();
            this.sourcesCB2 = new System.Windows.Forms.ComboBox();
            this.changeDirection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DirectionGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(12, 12);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 55);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "GetData";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainData
            // 
            this.mainData.AllowUserToAddRows = false;
            this.mainData.AllowUserToDeleteRows = false;
            this.mainData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mainData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainData.Location = new System.Drawing.Point(6, 16);
            this.mainData.Name = "mainData";
            this.mainData.ReadOnly = true;
            this.mainData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.mainData.RowTemplate.Height = 100;
            this.mainData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mainData.Size = new System.Drawing.Size(750, 305);
            this.mainData.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mainData);
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 292);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DirectionGB
            // 
            this.DirectionGB.Controls.Add(this.changeDirection);
            this.DirectionGB.Controls.Add(this.sourcesCB2);
            this.DirectionGB.Controls.Add(this.sourcesCB1);
            this.DirectionGB.Location = new System.Drawing.Point(93, 12);
            this.DirectionGB.Name = "DirectionGB";
            this.DirectionGB.Size = new System.Drawing.Size(198, 55);
            this.DirectionGB.TabIndex = 4;
            this.DirectionGB.TabStop = false;
            this.DirectionGB.Text = "groupBox2";
            // 
            // sourcesCB1
            // 
            this.sourcesCB1.Enabled = false;
            this.sourcesCB1.FormattingEnabled = true;
            this.sourcesCB1.Items.AddRange(new object[] {
            "Loot",
            "Swap"});
            this.sourcesCB1.Location = new System.Drawing.Point(6, 19);
            this.sourcesCB1.Name = "sourcesCB1";
            this.sourcesCB1.Size = new System.Drawing.Size(72, 21);
            this.sourcesCB1.TabIndex = 0;
            this.sourcesCB1.Text = "Loot";
            // 
            // sourcesCB2
            // 
            this.sourcesCB2.Enabled = false;
            this.sourcesCB2.FormattingEnabled = true;
            this.sourcesCB2.Items.AddRange(new object[] {
            "Swap",
            "Loot"});
            this.sourcesCB2.Location = new System.Drawing.Point(120, 19);
            this.sourcesCB2.Name = "sourcesCB2";
            this.sourcesCB2.Size = new System.Drawing.Size(72, 21);
            this.sourcesCB2.TabIndex = 0;
            this.sourcesCB2.Text = "Swap";
            // 
            // changeDirection
            // 
            this.changeDirection.Location = new System.Drawing.Point(84, 17);
            this.changeDirection.Name = "changeDirection";
            this.changeDirection.Size = new System.Drawing.Size(30, 23);
            this.changeDirection.TabIndex = 1;
            this.changeDirection.Text = "=>";
            this.changeDirection.UseVisualStyleBackColor = true;
            this.changeDirection.Click += new System.EventHandler(this.changeDirection_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DirectionGB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetData);
            this.Name = "MainView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.DirectionGB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox DirectionGB;
        private System.Windows.Forms.Button changeDirection;
        private System.Windows.Forms.ComboBox sourcesCB2;
        private System.Windows.Forms.ComboBox sourcesCB1;
        public System.Windows.Forms.DataGridView mainData;
    }
}

