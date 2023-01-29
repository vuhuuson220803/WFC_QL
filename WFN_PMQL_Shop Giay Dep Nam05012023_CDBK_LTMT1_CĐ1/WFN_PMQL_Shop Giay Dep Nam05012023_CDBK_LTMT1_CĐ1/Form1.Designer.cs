namespace WFN_PMQL_Shop_Giay_Dep_Nam05012023_CDBK_LTMT1_CĐ1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ui_Hộp_Tìm_Kiếm = new System.Windows.Forms.TextBox();
            this.uiNút_Biểu_Đồ = new System.Windows.Forms.Button();
            this.uiMã_Màu = new System.Windows.Forms.ComboBox();
            this.uiNăm_Sản_Xuất = new System.Windows.Forms.TextBox();
            this.uiNút_Hủy = new System.Windows.Forms.Button();
            this.uiNút_Lưu = new System.Windows.Forms.Button();
            this.uiNút_Duyệt_Ảnh = new System.Windows.Forms.Button();
            this.uiTình_Trạng_Kho_Hàng = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uiĐơn_Giá = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiTên_Sản_Phẩm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiẢnh = new System.Windows.Forms.PictureBox();
            this.uiNút_Xóa = new System.Windows.Forms.Button();
            this.uiNút_Sửa = new System.Windows.Forms.Button();
            this.uiNút_Thêm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sảnPhẩmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WFN_PMQL_Shop_Giay_Dep_Nam05012023_CDBK_LTMT1_CĐ1.Database1DataSet();
            this.mãSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nămSảnXuấtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnGiáDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãMàuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bITKhoHàngDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.khoHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ảnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sản_PhẩmTableAdapter = new WFN_PMQL_Shop_Giay_Dep_Nam05012023_CDBK_LTMT1_CĐ1.Database1DataSetTableAdapters.Sản_PhẩmTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sảnPhẩmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãSảnPhẩmDataGridViewTextBoxColumn,
            this.tênSảnPhẩmDataGridViewTextBoxColumn,
            this.nămSảnXuấtDataGridViewTextBoxColumn,
            this.đơnGiáDataGridViewTextBoxColumn,
            this.mãMàuDataGridViewTextBoxColumn,
            this.bITKhoHàngDataGridViewCheckBoxColumn,
            this.khoHàngDataGridViewTextBoxColumn,
            this.ảnhDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sảnPhẩmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(843, 191);
            this.dataGridView1.TabIndex = 0;
            // 
            // ui_Hộp_Tìm_Kiếm
            // 
            this.ui_Hộp_Tìm_Kiếm.Location = new System.Drawing.Point(567, 2);
            this.ui_Hộp_Tìm_Kiếm.Name = "ui_Hộp_Tìm_Kiếm";
            this.ui_Hộp_Tìm_Kiếm.Size = new System.Drawing.Size(231, 20);
            this.ui_Hộp_Tìm_Kiếm.TabIndex = 249;
            this.ui_Hộp_Tìm_Kiếm.Text = "Tìm kiếm...";
            // 
            // uiNút_Biểu_Đồ
            // 
            this.uiNút_Biểu_Đồ.Location = new System.Drawing.Point(68, 222);
            this.uiNút_Biểu_Đồ.Name = "uiNút_Biểu_Đồ";
            this.uiNút_Biểu_Đồ.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Biểu_Đồ.TabIndex = 267;
            this.uiNút_Biểu_Đồ.Text = "Vẽ Biểu Đồ";
            this.uiNút_Biểu_Đồ.UseVisualStyleBackColor = true;
            // 
            // uiMã_Màu
            // 
            this.uiMã_Màu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Mã_Màu", true));
            this.uiMã_Màu.FormattingEnabled = true;
            this.uiMã_Màu.Items.AddRange(new object[] {
            "R",
            "G",
            "B",
            "Y"});
            this.uiMã_Màu.Location = new System.Drawing.Point(387, 394);
            this.uiMã_Màu.Name = "uiMã_Màu";
            this.uiMã_Màu.Size = new System.Drawing.Size(139, 21);
            this.uiMã_Màu.TabIndex = 266;
            // 
            // uiNăm_Sản_Xuất
            // 
            this.uiNăm_Sản_Xuất.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Năm_Sản_Xuất", true));
            this.uiNăm_Sản_Xuất.Location = new System.Drawing.Point(387, 318);
            this.uiNăm_Sản_Xuất.Name = "uiNăm_Sản_Xuất";
            this.uiNăm_Sản_Xuất.Size = new System.Drawing.Size(248, 20);
            this.uiNăm_Sản_Xuất.TabIndex = 265;
            // 
            // uiNút_Hủy
            // 
            this.uiNút_Hủy.Location = new System.Drawing.Point(470, 493);
            this.uiNút_Hủy.Name = "uiNút_Hủy";
            this.uiNút_Hủy.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Hủy.TabIndex = 264;
            this.uiNút_Hủy.Text = "Hủy";
            this.uiNút_Hủy.UseVisualStyleBackColor = true;
            // 
            // uiNút_Lưu
            // 
            this.uiNút_Lưu.Location = new System.Drawing.Point(353, 493);
            this.uiNút_Lưu.Name = "uiNút_Lưu";
            this.uiNút_Lưu.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Lưu.TabIndex = 263;
            this.uiNút_Lưu.Text = "Lưu";
            this.uiNút_Lưu.UseVisualStyleBackColor = true;
            // 
            // uiNút_Duyệt_Ảnh
            // 
            this.uiNút_Duyệt_Ảnh.Location = new System.Drawing.Point(117, 493);
            this.uiNút_Duyệt_Ảnh.Name = "uiNút_Duyệt_Ảnh";
            this.uiNút_Duyệt_Ảnh.Size = new System.Drawing.Size(75, 23);
            this.uiNút_Duyệt_Ảnh.TabIndex = 262;
            this.uiNút_Duyệt_Ảnh.Text = "Duyệt Ảnh";
            this.uiNút_Duyệt_Ảnh.UseVisualStyleBackColor = true;
            // 
            // uiTình_Trạng_Kho_Hàng
            // 
            this.uiTình_Trạng_Kho_Hàng.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Kho_Hàng", true));
            this.uiTình_Trạng_Kho_Hàng.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sảnPhẩmBindingSource, "BIT_Kho_Hàng", true));
            this.uiTình_Trạng_Kho_Hàng.FormattingEnabled = true;
            this.uiTình_Trạng_Kho_Hàng.Items.AddRange(new object[] {
            "Còn",
            "Hết"});
            this.uiTình_Trạng_Kho_Hàng.Location = new System.Drawing.Point(387, 429);
            this.uiTình_Trạng_Kho_Hàng.Name = "uiTình_Trạng_Kho_Hàng";
            this.uiTình_Trạng_Kho_Hàng.Size = new System.Drawing.Size(139, 21);
            this.uiTình_Trạng_Kho_Hàng.TabIndex = 261;
            this.uiTình_Trạng_Kho_Hàng.SelectedIndexChanged += new System.EventHandler(this.uiTình_Trạng_Kho_Hàng_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 429);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 260;
            this.label5.Text = "Tình Trạng Kho Hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 259;
            this.label4.Text = "Mã Màu";
            // 
            // uiĐơn_Giá
            // 
            this.uiĐơn_Giá.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Đơn_Giá", true));
            this.uiĐơn_Giá.Location = new System.Drawing.Point(387, 358);
            this.uiĐơn_Giá.Name = "uiĐơn_Giá";
            this.uiĐơn_Giá.Size = new System.Drawing.Size(248, 20);
            this.uiĐơn_Giá.TabIndex = 258;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(257, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 257;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 256;
            this.label2.Text = "Năm Sản Xuất";
            // 
            // uiTên_Sản_Phẩm
            // 
            this.uiTên_Sản_Phẩm.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Tên_Sản_Phẩm", true));
            this.uiTên_Sản_Phẩm.Location = new System.Drawing.Point(387, 279);
            this.uiTên_Sản_Phẩm.Name = "uiTên_Sản_Phẩm";
            this.uiTên_Sản_Phẩm.Size = new System.Drawing.Size(248, 20);
            this.uiTên_Sản_Phẩm.TabIndex = 255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 254;
            this.label6.Text = "Tên Sản Phẩm";
            // 
            // uiẢnh
            // 
            this.uiẢnh.Image = ((System.Drawing.Image)(resources.GetObject("uiẢnh.Image")));
            this.uiẢnh.InitialImage = null;
            this.uiẢnh.Location = new System.Drawing.Point(68, 279);
            this.uiẢnh.Name = "uiẢnh";
            this.uiẢnh.Size = new System.Drawing.Size(156, 208);
            this.uiẢnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uiẢnh.TabIndex = 253;
            this.uiẢnh.TabStop = false;
            // 
            // uiNút_Xóa
            // 
            this.uiNút_Xóa.Location = new System.Drawing.Point(710, 222);
            this.uiNút_Xóa.Name = "uiNút_Xóa";
            this.uiNút_Xóa.Size = new System.Drawing.Size(56, 23);
            this.uiNút_Xóa.TabIndex = 252;
            this.uiNút_Xóa.Text = "Xóa";
            this.uiNút_Xóa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Sửa
            // 
            this.uiNút_Sửa.Location = new System.Drawing.Point(653, 222);
            this.uiNút_Sửa.Name = "uiNút_Sửa";
            this.uiNút_Sửa.Size = new System.Drawing.Size(51, 23);
            this.uiNút_Sửa.TabIndex = 251;
            this.uiNút_Sửa.Text = "Sửa";
            this.uiNút_Sửa.UseVisualStyleBackColor = true;
            // 
            // uiNút_Thêm
            // 
            this.uiNút_Thêm.Location = new System.Drawing.Point(578, 222);
            this.uiNút_Thêm.Name = "uiNút_Thêm";
            this.uiNút_Thêm.Size = new System.Drawing.Size(57, 23);
            this.uiNút_Thêm.TabIndex = 250;
            this.uiNút_Thêm.Text = "Thêm";
            this.uiNút_Thêm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 268;
            this.label1.Text = "Bảng Sản Phẩm Giày Dép Nam";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(257, 474);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(27, 13);
            this.Size.TabIndex = 269;
            this.Size.Text = "Size";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sảnPhẩmBindingSource, "Đơn_Giá", true));
            this.textBox1.Location = new System.Drawing.Point(387, 467);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 270;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.sảnPhẩmBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(910, 154);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(214, 224);
            this.chart1.TabIndex = 271;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // sảnPhẩmBindingSource
            // 
            this.sảnPhẩmBindingSource.DataMember = "Sản_Phẩm";
            this.sảnPhẩmBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mãSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.mãSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Mã_Sản_Phẩm";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Mã_Sản_Phẩm";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.Name = "mãSảnPhẩmDataGridViewTextBoxColumn";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.tênSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Tên_Sản_Phẩm";
            this.tênSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Tên_Sản_Phẩm";
            this.tênSảnPhẩmDataGridViewTextBoxColumn.Name = "tênSảnPhẩmDataGridViewTextBoxColumn";
            // 
            // nămSảnXuấtDataGridViewTextBoxColumn
            // 
            this.nămSảnXuấtDataGridViewTextBoxColumn.DataPropertyName = "Năm_Sản_Xuất";
            this.nămSảnXuấtDataGridViewTextBoxColumn.HeaderText = "Năm_Sản_Xuất";
            this.nămSảnXuấtDataGridViewTextBoxColumn.Name = "nămSảnXuấtDataGridViewTextBoxColumn";
            // 
            // đơnGiáDataGridViewTextBoxColumn
            // 
            this.đơnGiáDataGridViewTextBoxColumn.DataPropertyName = "Đơn_Giá";
            this.đơnGiáDataGridViewTextBoxColumn.HeaderText = "Đơn_Giá";
            this.đơnGiáDataGridViewTextBoxColumn.Name = "đơnGiáDataGridViewTextBoxColumn";
            // 
            // mãMàuDataGridViewTextBoxColumn
            // 
            this.mãMàuDataGridViewTextBoxColumn.DataPropertyName = "Mã_Màu";
            this.mãMàuDataGridViewTextBoxColumn.HeaderText = "Mã_Màu";
            this.mãMàuDataGridViewTextBoxColumn.Name = "mãMàuDataGridViewTextBoxColumn";
            // 
            // bITKhoHàngDataGridViewCheckBoxColumn
            // 
            this.bITKhoHàngDataGridViewCheckBoxColumn.DataPropertyName = "BIT_Kho_Hàng";
            this.bITKhoHàngDataGridViewCheckBoxColumn.HeaderText = "BIT_Kho_Hàng";
            this.bITKhoHàngDataGridViewCheckBoxColumn.Name = "bITKhoHàngDataGridViewCheckBoxColumn";
            this.bITKhoHàngDataGridViewCheckBoxColumn.Visible = false;
            // 
            // khoHàngDataGridViewTextBoxColumn
            // 
            this.khoHàngDataGridViewTextBoxColumn.DataPropertyName = "Kho_Hàng";
            this.khoHàngDataGridViewTextBoxColumn.HeaderText = "Kho_Hàng";
            this.khoHàngDataGridViewTextBoxColumn.Name = "khoHàngDataGridViewTextBoxColumn";
            // 
            // ảnhDataGridViewTextBoxColumn
            // 
            this.ảnhDataGridViewTextBoxColumn.DataPropertyName = "Ảnh";
            this.ảnhDataGridViewTextBoxColumn.HeaderText = "Ảnh";
            this.ảnhDataGridViewTextBoxColumn.Name = "ảnhDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // sản_PhẩmTableAdapter
            // 
            this.sản_PhẩmTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 528);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiNút_Biểu_Đồ);
            this.Controls.Add(this.uiMã_Màu);
            this.Controls.Add(this.uiNăm_Sản_Xuất);
            this.Controls.Add(this.uiNút_Hủy);
            this.Controls.Add(this.uiNút_Lưu);
            this.Controls.Add(this.uiNút_Duyệt_Ảnh);
            this.Controls.Add(this.uiTình_Trạng_Kho_Hàng);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uiĐơn_Giá);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiTên_Sản_Phẩm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uiẢnh);
            this.Controls.Add(this.uiNút_Xóa);
            this.Controls.Add(this.uiNút_Sửa);
            this.Controls.Add(this.uiNút_Thêm);
            this.Controls.Add(this.ui_Hộp_Tìm_Kiếm);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiẢnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sảnPhẩmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource sảnPhẩmBindingSource;
        private Database1DataSetTableAdapters.Sản_PhẩmTableAdapter sản_PhẩmTableAdapter;
        private System.Windows.Forms.TextBox ui_Hộp_Tìm_Kiếm;
        private System.Windows.Forms.Button uiNút_Biểu_Đồ;
        private System.Windows.Forms.ComboBox uiMã_Màu;
        private System.Windows.Forms.TextBox uiNăm_Sản_Xuất;
        private System.Windows.Forms.Button uiNút_Hủy;
        private System.Windows.Forms.Button uiNút_Lưu;
        private System.Windows.Forms.Button uiNút_Duyệt_Ảnh;
        private System.Windows.Forms.ComboBox uiTình_Trạng_Kho_Hàng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uiĐơn_Giá;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiTên_Sản_Phẩm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox uiẢnh;
        private System.Windows.Forms.Button uiNút_Xóa;
        private System.Windows.Forms.Button uiNút_Sửa;
        private System.Windows.Forms.Button uiNút_Thêm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nămSảnXuấtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnGiáDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãMàuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bITKhoHàngDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ảnhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

