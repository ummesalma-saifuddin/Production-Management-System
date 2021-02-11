namespace Project_GUI
{
    partial class Form5
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rawMaterialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goharApparelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gohar_ApparelDataSet = new Project_GUI.Gohar_ApparelDataSet();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.raw_MaterialsTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Raw_MaterialsTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.rawMaterialsItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.raw_Materials_ItemsTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Raw_Materials_ItemsTableAdapter();
            this.fKMasterPrRawM4D94879BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.master_Product_has_Raw_Materials_ItemsTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Master_Product_has_Raw_Materials_ItemsTableAdapter();
            this.rawMaterialsItemsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iddetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialsItemsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMasterPrRawM4D94879BBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(10, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(237, 23);
            this.button4.TabIndex = 53;
            this.button4.Text = "Clear All Fields ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(172, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 52;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(91, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 51;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(10, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddetailsDataGridViewTextBoxColumn,
            this.rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn,
            this.quantityavailableDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rawMaterialsItemsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(253, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 426);
            this.dataGridView1.TabIndex = 49;
            // 
            // rawMaterialsBindingSource
            // 
            this.rawMaterialsBindingSource.DataMember = "Raw Materials";
            this.rawMaterialsBindingSource.DataSource = this.goharApparelDataSetBindingSource;
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
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Unit_price", true));
            this.textBox5.Location = new System.Drawing.Point(113, 161);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 20);
            this.textBox5.TabIndex = 42;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Color", true));
            this.textBox4.Location = new System.Drawing.Point(113, 135);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(121, 20);
            this.textBox4.TabIndex = 41;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Quantity_available", true));
            this.textBox3.Location = new System.Drawing.Point(113, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 40;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Id_details", true));
            this.textBox2.Location = new System.Drawing.Point(113, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Unit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(33, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Designation";
            // 
            // raw_MaterialsTableAdapter
            // 
            this.raw_MaterialsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Designation", true));
            this.textBox1.Location = new System.Drawing.Point(113, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 57;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsItemsBindingSource, "Raw_Materials_Category_idRaw_Materials_Category", true));
            this.textBox6.Location = new System.Drawing.Point(113, 30);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 20);
            this.textBox6.TabIndex = 58;
            // 
            // rawMaterialsItemsBindingSource
            // 
            this.rawMaterialsItemsBindingSource.DataMember = "Raw_Materials_Items";
            this.rawMaterialsItemsBindingSource.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // raw_Materials_ItemsTableAdapter
            // 
            this.raw_Materials_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // fKMasterPrRawM4D94879BBindingSource
            // 
            this.fKMasterPrRawM4D94879BBindingSource.DataMember = "FK__Master_Pr__Raw_M__4D94879B";
            this.fKMasterPrRawM4D94879BBindingSource.DataSource = this.rawMaterialsItemsBindingSource;
            // 
            // master_Product_has_Raw_Materials_ItemsTableAdapter
            // 
            this.master_Product_has_Raw_Materials_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // rawMaterialsItemsBindingSource1
            // 
            this.rawMaterialsItemsBindingSource1.DataMember = "Raw_Materials_Items";
            this.rawMaterialsItemsBindingSource1.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // iddetailsDataGridViewTextBoxColumn
            // 
            this.iddetailsDataGridViewTextBoxColumn.DataPropertyName = "Id_details";
            this.iddetailsDataGridViewTextBoxColumn.HeaderText = "Id_details";
            this.iddetailsDataGridViewTextBoxColumn.Name = "iddetailsDataGridViewTextBoxColumn";
            this.iddetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn
            // 
            this.rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn.DataPropertyName = "Raw_Materials_Category_idRaw_Materials_Category";
            this.rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn.HeaderText = "Raw_Materials_Category_idRaw_Materials_Category";
            this.rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn.Name = "rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn";
            // 
            // quantityavailableDataGridViewTextBoxColumn
            // 
            this.quantityavailableDataGridViewTextBoxColumn.DataPropertyName = "Quantity_available";
            this.quantityavailableDataGridViewTextBoxColumn.HeaderText = "Quantity_available";
            this.quantityavailableDataGridViewTextBoxColumn.Name = "quantityavailableDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "Unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "Unit_price";
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            // 
            // rawMaterialsItemsBindingSource2
            // 
            this.rawMaterialsItemsBindingSource2.DataMember = "Raw_Materials_Items";
            this.rawMaterialsItemsBindingSource2.DataSource = this.gohar_ApparelDataSet;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(892, 447);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Raw Materials";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMasterPrRawM4D94879BBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsItemsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource goharApparelDataSetBindingSource;
        private Gohar_ApparelDataSet gohar_ApparelDataSet;
        private System.Windows.Forms.BindingSource rawMaterialsBindingSource;
        private Gohar_ApparelDataSetTableAdapters.Raw_MaterialsTableAdapter raw_MaterialsTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.BindingSource rawMaterialsItemsBindingSource;
        private Gohar_ApparelDataSetTableAdapters.Raw_Materials_ItemsTableAdapter raw_Materials_ItemsTableAdapter;
        private System.Windows.Forms.BindingSource fKMasterPrRawM4D94879BBindingSource;
        private Gohar_ApparelDataSetTableAdapters.Master_Product_has_Raw_Materials_ItemsTableAdapter master_Product_has_Raw_Materials_ItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialsCategoryidRawMaterialsCategoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rawMaterialsItemsBindingSource1;
        private System.Windows.Forms.BindingSource rawMaterialsItemsBindingSource2;
    }
}