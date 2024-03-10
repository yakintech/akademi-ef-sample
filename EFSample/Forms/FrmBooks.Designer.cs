namespace EFSample.Forms
{
    partial class FrmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnOrderByName = new Button();
            btnOrderByDescName = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(84, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 471);
            dataGridView1.TabIndex = 0;
            // 
            // btnOrderByName
            // 
            btnOrderByName.FlatStyle = FlatStyle.Popup;
            btnOrderByName.Location = new Point(84, 56);
            btnOrderByName.Name = "btnOrderByName";
            btnOrderByName.Size = new Size(165, 87);
            btnOrderByName.TabIndex = 1;
            btnOrderByName.Text = "Ada Gore Sirala";
            btnOrderByName.UseVisualStyleBackColor = true;
            btnOrderByName.Click += btnOrderByName_Click;
            // 
            // btnOrderByDescName
            // 
            btnOrderByDescName.FlatStyle = FlatStyle.Popup;
            btnOrderByDescName.Location = new Point(273, 56);
            btnOrderByDescName.Name = "btnOrderByDescName";
            btnOrderByDescName.Size = new Size(165, 87);
            btnOrderByDescName.TabIndex = 1;
            btnOrderByDescName.Text = "Ada Gore Tersten Sirala";
            btnOrderByDescName.UseVisualStyleBackColor = true;
            btnOrderByDescName.Click += btnOrderByDescName_Click;
            // 
            // FrmBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 650);
            Controls.Add(btnOrderByDescName);
            Controls.Add(btnOrderByName);
            Controls.Add(dataGridView1);
            Name = "FrmBooks";
            Text = "FrmBooks";
            Load += FrmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOrderByName;
        private Button btnOrderByDescName;
    }
}