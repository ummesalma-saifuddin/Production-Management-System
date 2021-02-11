namespace Project_GUI
{
    partial class Form9
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
            this.idMasterProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitProductionCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitTotalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goharApparelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gohar_ApparelDataSet = new Project_GUI.Gohar_ApparelDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.master_ProductTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Master_ProductTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.catalogueTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.CatalogueTableAdapter();
            this.master_Product_has_Raw_MaterialTableAdapter = new Project_GUI.Gohar_ApparelDataSetTableAdapters.Master_Product_has_Raw_Materials_ItemsTableAdapter();
            this.catalogueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterProducthasRawMaterialsItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProducthasRawMaterialsItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMasterProductDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.unitProductionCostDataGridViewTextBoxColumn,
            this.unitTotalCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.masterProductBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 334);
            this.dataGridView1.TabIndex = 23;
            // 
            // idMasterProductDataGridViewTextBoxColumn
            // 
            this.idMasterProductDataGridViewTextBoxColumn.DataPropertyName = "idMaster_Product";
            this.idMasterProductDataGridViewTextBoxColumn.HeaderText = "idMaster_Product";
            this.idMasterProductDataGridViewTextBoxColumn.Name = "idMasterProductDataGridViewTextBoxColumn";
            this.idMasterProductDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // unitProductionCostDataGridViewTextBoxColumn
            // 
            this.unitProductionCostDataGridViewTextBoxColumn.DataPropertyName = "Unit_Production_Cost";
            this.unitProductionCostDataGridViewTextBoxColumn.HeaderText = "Unit_Production_Cost";
            this.unitProductionCostDataGridViewTextBoxColumn.Name = "unitProductionCostDataGridViewTextBoxColumn";
            // 
            // unitTotalCostDataGridViewTextBoxColumn
            // 
            this.unitTotalCostDataGridViewTextBoxColumn.DataPropertyName = "Unit_Total_Cost";
            this.unitTotalCostDataGridViewTextBoxColumn.HeaderText = "Unit_Total_Cost";
            this.unitTotalCostDataGridViewTextBoxColumn.Name = "unitTotalCostDataGridViewTextBoxColumn";
            // 
            // masterProductBindingSource
            // 
            this.masterProductBindingSource.DataMember = "Master_Product";
            this.masterProductBindingSource.DataSource = this.goharApparelDataSetBindingSource;
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
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(12, 240);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 23);
            this.button4.TabIndex = 30;
            this.button4.Text = "Clear All Fields ";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(12, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 23);
            this.button3.TabIndex = 29;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(12, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterProductBindingSource, "Name", true));
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(70, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(121, 20);
            this.textBox3.TabIndex = 70;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterProductBindingSource, "idMaster_Product", true));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(70, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "ID";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.Location = new System.Drawing.Point(12, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(174, 23);
            this.button5.TabIndex = 71;
            this.button5.Text = "View Catalogues";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // master_ProductTableAdapter
            // 
            this.master_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Unit Price";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.masterProductBindingSource, "Unit_Production_Cost", true));
            this.textBox1.Location = new System.Drawing.Point(71, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 73;
            // 
            // catalogueTableAdapter
            // 
            this.catalogueTableAdapter.ClearBeforeFill = true;
            // 
            // master_Product_has_Raw_MaterialTableAdapter
            // 
            this.master_Product_has_Raw_MaterialTableAdapter.ClearBeforeFill = true;
            // 
            // catalogueBindingSource
            // 
            this.catalogueBindingSource.DataMember = "Catalogue";
            this.catalogueBindingSource.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // masterProducthasRawMaterialsItemsBindingSource
            // 
            this.masterProducthasRawMaterialsItemsBindingSource.DataMember = "Master_Product_has_Raw_Materials_Items";
            this.masterProducthasRawMaterialsItemsBindingSource.DataSource = this.goharApparelDataSetBindingSource;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(12, 269);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(174, 23);
            this.button6.TabIndex = 74;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(565, 365);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form9";
            this.Text = "Master Products";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goharApparelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gohar_ApparelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterProducthasRawMaterialsItemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.BindingSource goharApparelDataSetBindingSource;
        private Gohar_ApparelDataSet gohar_ApparelDataSet;
        private System.Windows.Forms.BindingSource masterProductBindingSource;
        private Gohar_ApparelDataSetTableAdapters.Master_ProductTableAdapter master_ProductTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMasterProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitProductionCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitTotalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private Gohar_ApparelDataSetTableAdapters.CatalogueTableAdapter catalogueTableAdapter;
        private Gohar_ApparelDataSetTableAdapters.Master_Product_has_Raw_Materials_ItemsTableAdapter master_Product_has_Raw_MaterialTableAdapter;
        private System.Windows.Forms.BindingSource catalogueBindingSource;
        private System.Windows.Forms.BindingSource masterProducthasRawMaterialsItemsBindingSource;
        private System.Windows.Forms.Button button6;
    }
}