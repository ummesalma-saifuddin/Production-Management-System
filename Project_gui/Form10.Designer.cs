namespace Project_GUI
{
    partial class Form10
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catalougueIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorsidColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeidSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterProductidMasterProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goharApparelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gohar_ApparelDataSet = new Project_GUI.Gohar_ApparelDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.catalogueTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.CatalogueTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.orders_has_CatalogueTableAdapter1 = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Orders_has_CatalogueTableAdapter();
            this.ordershasCatalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordershasCatalogueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catalougueIDDataGridViewTextBoxColumn,
            this.colorsidColorsDataGridViewTextBoxColumn,
            this.sizeidSizeDataGridViewTextBoxColumn,
            this.masterProductidMasterProductDataGridViewTextBoxColumn,
            this.quantityavailableDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.catalogueBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(220, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 361);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // catalougueIDDataGridViewTextBoxColumn
            // 
            this.catalougueIDDataGridViewTextBoxColumn.DataPropertyName = "Catalougue_ID";
            this.catalougueIDDataGridViewTextBoxColumn.HeaderText = "Catalougue_ID";
            this.catalougueIDDataGridViewTextBoxColumn.Name = "catalougueIDDataGridViewTextBoxColumn";
            // 
            // colorsidColorsDataGridViewTextBoxColumn
            // 
            this.colorsidColorsDataGridViewTextBoxColumn.DataPropertyName = "Colors_idColors";
            this.colorsidColorsDataGridViewTextBoxColumn.HeaderText = "Colors_idColors";
            this.colorsidColorsDataGridViewTextBoxColumn.Name = "colorsidColorsDataGridViewTextBoxColumn";
            // 
            // sizeidSizeDataGridViewTextBoxColumn
            // 
            this.sizeidSizeDataGridViewTextBoxColumn.DataPropertyName = "Size_idSize";
            this.sizeidSizeDataGridViewTextBoxColumn.HeaderText = "Size_idSize";
            this.sizeidSizeDataGridViewTextBoxColumn.Name = "sizeidSizeDataGridViewTextBoxColumn";
            // 
            // masterProductidMasterProductDataGridViewTextBoxColumn
            // 
            this.masterProductidMasterProductDataGridViewTextBoxColumn.DataPropertyName = "Master_Product_idMaster_Product";
            this.masterProductidMasterProductDataGridViewTextBoxColumn.HeaderText = "Master_Product_idMaster_Product";
            this.masterProductidMasterProductDataGridViewTextBoxColumn.Name = "masterProductidMasterProductDataGridViewTextBoxColumn";
            // 
            // quantityavailableDataGridViewTextBoxColumn
            // 
            this.quantityavailableDataGridViewTextBoxColumn.DataPropertyName = "Quantity_available";
            this.quantityavailableDataGridViewTextBoxColumn.HeaderText = "Quantity_available";
            this.quantityavailableDataGridViewTextBoxColumn.Name = "quantityavailableDataGridViewTextBoxColumn";
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataMember = "Catalogue";
            this.catalogueBindingSource.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // goharApparelDataSetBindingSource
            // 
            this.goharApparelDataSetBindingSource.DataSource = this.gohar_ApparelDataSet;
            this.goharApparelDataSetBindingSource.Position = 0;
            // 
            // gohar_ApparelDataSet
            // 
            this.gohar_ApparelDataSet.DataSetName = "Gohar_ApparelDataSet";
            this.gohar_ApparelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catalogueBindingSource, "Catalougue_ID", true));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(80, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Color";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catalogueBindingSource, "Colors_idColors", true));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Blue",
            "Red",
            "Green",
            "Teal",
            "Black",
            "Purple"});
            this.comboBox1.Location = new System.Drawing.Point(80, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(22, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Sizes";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(8, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 82;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(8, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 23);
            this.button2.TabIndex = 83;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(8, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 23);
            this.button3.TabIndex = 84;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(8, 346);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(193, 23);
            this.button4.TabIndex = 85;
            this.button4.Text = "Clear All Fields ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(189, 18);
            this.richTextBox1.TabIndex = 86;
            this.richTextBox1.Text = "Specify Search:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(8, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 23);
            this.button5.TabIndex = 87;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // catalogueTableAdapter
            // 
            this.catalogueTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "L",
            "M",
            "S"});
            this.comboBox2.Location = new System.Drawing.Point(80, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 88;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.catalogueBindingSource, "Catalougue_ID", true));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(80, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 90;
            this.textBox1.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(22, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Quantity";
            // 
            // orders_has_CatalogueTableAdapter1
            // 
            this.orders_has_CatalogueTableAdapter1.ClearBeforeFill = true;
            // 
            // ordershasCatalogueBindingSource
            // 
            this.ordershasCatalogueBindingSource.DataMember = "Orders_has_Catalogue";
            this.ordershasCatalogueBindingSource.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(582, 394);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form10";
            this.Text = "Catalogues";
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordershasCatalogueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource goharApparelDataSetBindingSource;
        private Gohar_ApparelDataSet gohar_ApparelDataSet;
        private System.Windows.Forms.BindingSource catalogueBindingSource;
        private Gohar_ApparelDataSetTableAdapters.CatalogueTableAdapter catalogueTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catalougueIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorsidColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeidSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterProductidMasterProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private Gohar_ApparelDataSetTableAdapters.Orders_has_CatalogueTableAdapter orders_has_CatalogueTableAdapter1;
        private System.Windows.Forms.BindingSource ordershasCatalogueBindingSource;
    }
}