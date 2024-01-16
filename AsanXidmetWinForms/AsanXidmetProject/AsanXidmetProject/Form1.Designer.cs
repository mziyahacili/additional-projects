namespace AsanXidmetProject
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dbComboBox = new ComboBox();
            panel2 = new Panel();
            deleteBtn = new Button();
            saveBtn = new Button();
            getDataBtn = new Button();
            dbDataGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dbDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(dbDataGridView, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.333333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.6666641F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dbComboBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 36);
            panel1.TabIndex = 0;
            // 
            // dbComboBox
            // 
            dbComboBox.Dock = DockStyle.Fill;
            dbComboBox.FormattingEnabled = true;
            dbComboBox.Location = new Point(0, 0);
            dbComboBox.Name = "dbComboBox";
            dbComboBox.Size = new Size(394, 23);
            dbComboBox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(saveBtn);
            panel2.Controls.Add(getDataBtn);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(403, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(394, 36);
            panel2.TabIndex = 1;
            // 
            // deleteBtn
            // 
            deleteBtn.Dock = DockStyle.Left;
            deleteBtn.Location = new Point(200, 0);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 36);
            deleteBtn.TabIndex = 4;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Dock = DockStyle.Left;
            saveBtn.Location = new Point(125, 0);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 36);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += SaveBtn_Click;
            // 
            // getDataBtn
            // 
            getDataBtn.Dock = DockStyle.Left;
            getDataBtn.Location = new Point(0, 0);
            getDataBtn.Name = "getDataBtn";
            getDataBtn.Size = new Size(125, 36);
            getDataBtn.TabIndex = 2;
            getDataBtn.Text = "Recrieve All Data";
            getDataBtn.UseVisualStyleBackColor = true;
            getDataBtn.Click += getAllDatabtn_Click;
            // 
            // dbDataGridView
            // 
            dbDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dbDataGridView, 2);
            dbDataGridView.Dock = DockStyle.Fill;
            dbDataGridView.Location = new Point(3, 45);
            dbDataGridView.Name = "dbDataGridView";
            dbDataGridView.Size = new Size(794, 402);
            dbDataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dbDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox dbComboBox;
        private Panel panel2;
        private Button deleteBtn;
        private Button saveBtn;
        private Button getDataBtn;
        private DataGridView dbDataGridView;
    }
}
