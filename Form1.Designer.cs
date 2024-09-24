namespace financetracker
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
            dataGridView1 = new DataGridView();
            Housing = new DataGridViewTextBoxColumn();
            Transportation = new DataGridViewTextBoxColumn();
            Travel = new DataGridViewTextBoxColumn();
            Food = new DataGridViewTextBoxColumn();
            Medical = new DataGridViewTextBoxColumn();
            Taxes = new DataGridViewTextBoxColumn();
            Education = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Housing, Transportation, Travel, Food, Medical, Taxes, Education });
            dataGridView1.Location = new Point(0, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(800, 424);
            dataGridView1.TabIndex = 0;
            // 
            // Housing
            // 
            Housing.HeaderText = "Housing";
            Housing.Name = "Housing";
            // 
            // Transportation
            // 
            Transportation.HeaderText = "Transportation";
            Transportation.Name = "Transportation";
            // 
            // Travel
            // 
            Travel.HeaderText = "Travel";
            Travel.Name = "Travel";
            // 
            // Food
            // 
            Food.HeaderText = "Food";
            Food.Name = "Food";
            // 
            // Medical
            // 
            Medical.HeaderText = "Medical";
            Medical.Name = "Medical";
            // 
            // Taxes
            // 
            Taxes.HeaderText = "Taxes";
            Taxes.Name = "Taxes";
            // 
            // Education
            // 
            Education.HeaderText = "Education";
            Education.Name = "Education";
            // 
            // button1
            // 
            button1.Location = new Point(12, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 1;
            button1.Text = "Reports";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 23);
            button2.TabIndex = 2;
            button2.Text = "Calendar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(437, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 23);
            button3.TabIndex = 3;
            button3.Text = "Financial Literacy";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(646, 4);
            button4.Name = "button4";
            button4.Size = new Size(154, 23);
            button4.TabIndex = 4;
            button4.Text = "Transactions";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn Housing;
        private DataGridViewTextBoxColumn Transportation;
        private DataGridViewTextBoxColumn Travel;
        private DataGridViewTextBoxColumn Food;
        private DataGridViewTextBoxColumn Medical;
        private DataGridViewTextBoxColumn Taxes;
        private DataGridViewTextBoxColumn Education;
    }
}
