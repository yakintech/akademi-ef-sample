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
            txtSearch = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtMinPrice = new TextBox();
            label3 = new Label();
            txtMaxPrice = new TextBox();
            btnSearchByPrice = new Button();
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
            // txtSearch
            // 
            txtSearch.Location = new Point(543, 53);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 56);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 3;
            label1.Text = "Arama:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(469, 118);
            label2.Name = "label2";
            label2.Size = new Size(46, 25);
            label2.TabIndex = 4;
            label2.Text = "Min:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(521, 118);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(150, 31);
            txtMinPrice.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(692, 118);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 4;
            label3.Text = "Max:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(747, 118);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(150, 31);
            txtMaxPrice.TabIndex = 5;
            // 
            // btnSearchByPrice
            // 
            btnSearchByPrice.Location = new Point(918, 115);
            btnSearchByPrice.Name = "btnSearchByPrice";
            btnSearchByPrice.Size = new Size(112, 34);
            btnSearchByPrice.TabIndex = 6;
            btnSearchByPrice.Text = "Search";
            btnSearchByPrice.UseVisualStyleBackColor = true;
            btnSearchByPrice.Click += btnSearchByPrice_Click;
            // 
            // FrmBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 650);
            Controls.Add(btnSearchByPrice);
            Controls.Add(txtMaxPrice);
            Controls.Add(label3);
            Controls.Add(txtMinPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSearch);
            Controls.Add(btnOrderByDescName);
            Controls.Add(btnOrderByName);
            Controls.Add(dataGridView1);
            Name = "FrmBooks";
            Text = "FrmBooks";
            Load += FrmBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOrderByName;
        private Button btnOrderByDescName;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private TextBox txtMinPrice;
        private Label label3;
        private TextBox txtMaxPrice;
        private Button btnSearchByPrice;
    }
}