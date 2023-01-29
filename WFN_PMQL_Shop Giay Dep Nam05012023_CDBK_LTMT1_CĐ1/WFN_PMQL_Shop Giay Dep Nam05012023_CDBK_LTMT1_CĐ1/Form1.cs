using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFN_PMQL_Shop_Giay_Dep_Nam05012023_CDBK_LTMT1_CĐ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Sản_Phẩm' table. You can move, or remove it, as needed.
            this.sản_PhẩmTableAdapter.Fill(this.database1DataSet.Sản_Phẩm);

        }
        string Thông_Báo { get; set; } // ví dụ: báo lỗi, báo lỗi kiểm duyệt dữ liệu
        string Hành_Động { get; set; } // Thêm, Sửa (cờ đánh dấu cho hàm lưu() )
        Sản_Phẩm Dòng { get; set; } // Trỏ tới bản ghi hiện tại đang được bôi đen trên Bảng
        Database1Entities DB = new Database1Entities(); // Biến này chịu trách nhiệm thao tác, quản lý CSDL cục bộ DB.mdf



        //void enableFormRow(bool on = true)
        void bật_tắt_nút(bool bật = true)
        {
            bool tắt = !bật;

            // Ẩn hiện các nút chức năng
            this.uiNút_Lưu.Enabled = bật;
            this.uiNút_Duyệt_Ảnh.Enabled = bật;
            this.uiNút_Hủy.Enabled = bật;

            this.uiNút_Thêm.Enabled = tắt;
            this.uiNút_Sửa.Enabled = tắt;
            this.uiNút_Xóa.Enabled = tắt;

            // Ẩn hiện các phần tử nhập liệu dòng bản ghi trên Form
            this.uiTên_Sản_Phẩm.Enabled = bật;
            this.uiNăm_Sản_Xuất.Enabled = bật;
            this.uiĐơn_Giá.Enabled = bật;
            this.uiMã_Màu.Enabled = bật;
            this.uiTình_Trạng_Kho_Hàng.Enabled = bật;

        }

        //public void selectRow(int index)
        public void chọn_dòng(int chỉ_số)
        {
            // Bôi đen dòng theo chỉ số của nó
            this.dataGridView1.ClearSelection();
            this.dataGridView1.Rows[chỉ_số].Selected = true;
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[chỉ_số].Cells[0];

            this.uiNút_Sửa.Enabled = true;
            this.uiNút_Xóa.Enabled = true;

            // Lấy ra đối tượng dữ liệu tương ứng với dòng bản ghi trên bảng
            // theo chỉ số của dòng
            this.Dòng = this.DB.Sản_Phẩm.ToList().ElementAt(chỉ_số);

            // Lần đầu tiên khi chưa có Ảnh trong DB thì 
            // trường thông tin này trên C# là null
            // @todo: cho cái ảnh rỗng vào
            if (this.Dòng.Ảnh != null)
            {
                //this.uiẢnh.Image = Image.FromFile("images\\"+this.Dòng.Ảnh);
                this.uiẢnh.ImageLocation = this.Dòng.Ảnh;
            }

            this.bật_tắt_nút(false);
        }

        // Ngay sau khi Form1 hiện lên thì làm gì ?
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Tùy chỉnh thuộc tính Form...
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Tùy Chỉnh Thuộc Tính của bảng dữ liệu (DataGridView)
            // Chế độ chọn: bôi đen toàn dòng
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // Ngăn ko cho sửa ô dữ liệu
            this.dataGridView1.ReadOnly = true;
            // Ngăn ko cho thêm vào dòng trống ở cuối bảng
            this.dataGridView1.AllowUserToAddRows = false;
            // Ràng buộc hàm xử lý sự kiện vào bảng dữ liệu 
            this.dataGridView1.DoubleClick += Nhấp_Đúp_Chuột_Vào_Bảng;
            this.dataGridView1.Click += Nhấp_Chuột_Vào_Bảng;
            this.dataGridView1.MouseClick += Nhấp_Chuột_Phải_Vào_Bảng;

            // Ràng buộc hàm xử lý sự kiện vào các nút chức năng 
            this.uiNút_Thêm.Click += Nhấn_Nút_Thêm;
            this.uiNút_Sửa.Click += Nhấn_Nút_Sửa;
            this.uiNút_Xóa.Click += Nhấn_Nút_Xóa;
            this.uiNút_Lưu.Click += Nhấn_Nút_Lưu;
            this.uiNút_Hủy.Click += Nhấn_Nút_Hủy;

           // this.uiNút_Biểu_Đồ.Click += Nhấn_Nút_Biểu_Đồ;
            this.ui_Hộp_Tìm_Kiếm.KeyPress += Tìm_Kiếm; ;

            // Ràng buộc hàm xử lý sự kiện duyệt ảnh
            this.uiNút_Duyệt_Ảnh.Click += Nhấn_Nút_Duyệt_Ảnh;
            this.uiẢnh.DoubleClick += Nhấp_Đúp_Ảnh;

            // @todo: Xuất file XML ???

            if// nếu
            (this.dataGridView1.Rows.Count > 0)// Bảng có dữ liệu
            // thì
            {
                // bôi đen dòng đầu tiên
                this.chọn_dòng(0);
            }

        }


        // KeyDown hoạt động không đúng !
        // Vì khi xóa chữ trong hộp tìm kiếm, nó lại không hiển thị
        // đầy đủ các dòng bản ghi
        private void Tìm_Kiếm(object sender, KeyPressEventArgs e)
        {
            //throw new NotImplementedException();

            BindingSource bs = new BindingSource();
            bs.DataSource = this.dataGridView1.DataSource;

            //bs.Filter = this.uiBảng.Columns[5].HeaderText.ToString() + " LIKE '%" + this.ui_Hộp_Tìm_Kiếm.Text + "%'";

            var keyword = this.ui_Hộp_Tìm_Kiếm.Text.Trim();

            if (keyword != "")
            {
                bs.Filter = $"Tên_Sản_Phẩm LIKE '%{keyword}%'";
                this.dataGridView1.DataSource = bs;
            }
            else
            {
                // Đoạn mã này cũng không OK, không giải quyết triệt để vấn đề
                //this.sảnPhẩmBindingSource.DataMember = "Sản_Phẩm";
                //this.sảnPhẩmBindingSource.DataSource = this.dBDataSet;

                //this.uiBảng.DataSource = this.sảnPhẩmBindingSource;
            }

        }

       /* private void Nhấn_Nút_Biểu_Đồ(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            var f = new FormChart();
            f.Show();
        }*/

        private void Nhấp_Chuột_Phải_Vào_Bảng(object sender, MouseEventArgs e)
        {
            //throw new NotImplementedException();
            // Nếu nhấp chuột phải
            if (e.Button == MouseButtons.Right)
            {
                // ...thì tạo menu ngữ cảnh 
                var cm = new ContextMenu();

                // Lấy chỉ số của dòng để kiểm tra xem cú nhấp chuột phải có rơi trúng dòng nào không
                int chỉ_số_dòng_bị_nhấp_chuột = this.dataGridView1.HitTest(e.X, e.Y).RowIndex;

                // Nếu nhấp chuột phải vào đúng dòng
                if (chỉ_số_dòng_bị_nhấp_chuột >= 0)
                {
                    // thì bôi đen dòng đó
                    this.chọn_dòng(chỉ_số_dòng_bị_nhấp_chuột);

                    // Tạo các menu con(Sửa,Xóa) trên Menu ngữ cảnh
                    // Có vẻ như không có thuộc tính Image để thêm biểu tượng cho MenuItem
                    var menuItemEdit = new MenuItem("Sửa");
                    menuItemEdit.Click += Nhấn_Nút_Sửa;
                    cm.MenuItems.Add(menuItemEdit);

                    var menuItemDelete = new MenuItem("Xóa");
                    menuItemDelete.Click += Nhấn_Nút_Xóa;
                    cm.MenuItems.Add(menuItemDelete);
                }
                else // ngược lại, nhấp chuột phải ra ngoài các dòng
                {
                    // thì tạo menu con Thêm Mới
                    var menuItemAdd = new MenuItem("Thêm Mới");
                    menuItemAdd.Click += Nhấn_Nút_Thêm;
                    cm.MenuItems.Add(menuItemAdd);
                }

                // Hiển thị menu ngữ cảnh tại tọa độ nhấp chuột
                cm.Show(this.dataGridView1, new Point(e.X, e.Y));

            }
        }

        private void Nhấp_Đúp_Ảnh(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (this.uiNút_Lưu.Enabled)
                this.uiNút_Duyệt_Ảnh.PerformClick();
        }

        private void Nhấn_Nút_Duyệt_Ảnh(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if (!this.uiNút_Lưu.Enabled)
                return;

            // Tạo trình chọn file ảnh
            var ofd = new OpenFileDialog();
            // và cấu hình cho nó
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            ofd.Title = "Hãy chọn Ảnh";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;...";

            // Copy file ảnh mà người dùng chọn lên thư mục thực thi
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sourceFile = ofd.FileName;
                var newFileName = Guid.NewGuid().ToString();
                var targetFile = System.IO.Path.Combine(Application.StartupPath, "images\\" + newFileName);
                System.Console.Write(targetFile);
                System.IO.File.Copy(sourceFile, targetFile);

                // cập nhạt ảnh trên PictureBox
                this.uiẢnh.ImageLocation = "images\\" + newFileName;
            }
        }

        private void Nhấn_Nút_Hủy(object sender, EventArgs e)
        {

            //throw new NotImplementedException();


            if (this.dataGridView1.RowCount > 0)
            {
                // Đoạn này gây lỗi vì lúc bấm nút Add: 
                // Dòng mới có chỉ số -1 được thêm vào: Out of range
                //this.chọn_dòng(this.uiBảng.CurrentCell.RowIndex);

                if (this.Hành_Động == "Thêm")
                {
                    // Gỡ bỏ dòng tạm thời mới thêm vào cuối Bảng dữ liệu
                    // dòng này chưa ăn vào DB cơ sở dữ liệu
                    this.sảnPhẩmBindingSource.RemoveCurrent();

                    // Bôi đen dòng đầu tiên
                    this.chọn_dòng(0);
                }
                else // Hủy việc sửa
                {
                    this.chọn_dòng(this.dataGridView1.CurrentCell.RowIndex);
                }

            }

        }

        bool Dữ_Liệu_Không_Hợp_Lệ
        {
            get
            {
                if (this.uiTên_Sản_Phẩm.Text == "")
                {
                    this.Thông_Báo = "Tên sản phẩm không được trống !";
                    this.uiTên_Sản_Phẩm.Focus();

                    return true;
                }

                //// Không để xảy ra SQLException: Binary truncated
                //if (String.IsNullOrEmpty(this.uiTextBox_RollNumber.Text) || this.uiTextBox_RollNumber.Text.Length > 10)
                //{
                //    this.Msg = "Mã sinh viên không được trống !";
                //    this.uiTextBox_RollNumber.Focus();
                //    return true;
                //}

                //// todo: xác thực email bằng biểu thức chính quy
                //string email_pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
                //if (String.IsNullOrEmpty(this.uiTextBox_Email.Text) ||
                //                            !Regex.IsMatch(this.uiTextBox_Email.Text, email_pattern))
                //{
                //    this.Msg = "Email phải hợp lệ !";
                //    return true;
                //}

                // Ép người dùng phải chọn ảnh khác ảnh rỗng empty-profile.png
                if (!System.IO.File.Exists(this.uiẢnh.ImageLocation))
                {
                    this.Thông_Báo = "Phải chọn ảnh !";
                    return true;
                }

                return false;
            }
        }

        private void Nhấn_Nút_Lưu(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            if// nếu
            (Dữ_Liệu_Không_Hợp_Lệ)
            // thì
            {
                // báo lỗi
                MessageBox.Show(this.Thông_Báo, "Dữ Liệu Ko Hợp Lệ!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // và dừng ở đây, không cho phép lưu dữ liệu không hợp lệ
                return;
            }

            if// nếu
            (Hành_Động == "Thêm")
            {

                // Tạo bản ghi mới
                this.DB.Sản_Phẩm.Add(new Sản_Phẩm()
                {
                    Tên_Sản_Phẩm = this.uiTên_Sản_Phẩm.Text,
                    Mã_Màu = this.uiMã_Màu.Text,
                    //BIT_Kho_Hàng = Convert.ToBoolean(this.uiTình_Trạng_Kho_Hàng.Tag), // Lỗi: DBnull
                    BIT_Kho_Hàng = (this.uiTình_Trạng_Kho_Hàng.Text == "Còn") ? true : false,
                    Kho_Hàng = this.uiTình_Trạng_Kho_Hàng.Text,
                    Đơn_Giá = Convert.ToDouble(this.uiĐơn_Giá.Text),
                    Năm_Sản_Xuất = Convert.ToInt32(this.uiNăm_Sản_Xuất.Text),
                    Ảnh = this.uiẢnh.ImageLocation
                });

                // Lưu dữ liệu mới vào cơ sở dữ liệu
                this.DB.SaveChanges();

                // Tải lại dữ liệu trên giao diện (cập nhật lại)
                this.Form1_Load(this, null);
                this.chọn_dòng(this.dataGridView1.RowCount - 1);

                MessageBox.Show("Đã hoàn tất việc thêm mới !", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else// ngược lại, hành động là "Sửa"
            {
                // Dữ liệu cập nhật tạm
                this.Dòng.Tên_Sản_Phẩm = this.uiTên_Sản_Phẩm.Text;
                this.Dòng.Mã_Màu = this.uiMã_Màu.Text;
                this.Dòng.BIT_Kho_Hàng = Convert.ToBoolean(this.uiTình_Trạng_Kho_Hàng.Tag);
                this.Dòng.Kho_Hàng = this.uiTình_Trạng_Kho_Hàng.Text;
                this.Dòng.Đơn_Giá = Convert.ToDouble(this.uiĐơn_Giá.Text);
                this.Dòng.Năm_Sản_Xuất = Convert.ToInt32(this.uiNăm_Sản_Xuất.Text);
                this.Dòng.Ảnh = this.uiẢnh.ImageLocation;
                // ví dụ: "images\09066d65-862b-4dd9-a95e-e7460534c56d"

                // Lưu thực sự dữ liệu đã sửa vào cơ sở dữ liệu
                this.DB.Entry(this.Dòng).State = System.Data.Entity.EntityState.Modified;
                this.DB.SaveChanges();

                // Cập nhật lại giao diện theo dữ liệu mới
                this.Form1_Load(this, null);
                this.chọn_dòng(this.dataGridView1.CurrentCell.RowIndex);

                MessageBox.Show("Đã hoàn tất việc sửa !", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            this.bật_tắt_nút(false);
        }

        private void Nhấn_Nút_Xóa(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if// nếu không có dòng nào được bôi đen
                (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hãy chọn dòng bản ghi để xóa !", "Xóa Dữ Liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var yes_no = MessageBox.Show("Bạn có chắc muốn xóa ?", "Xác Nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


            if// nếu xác nhận chắc chắn muốn xóa 
                (yes_no == DialogResult.Yes)
            {
                // xóa thực sự trong cơ sở dữ liệu
                this.DB.Entry(this.Dòng).State = System.Data.Entity.EntityState.Deleted;
                this.DB.SaveChanges();

                // Cập nhật lại giao diện theo cơ sở dữ liệu mới
                this.Form1_Load(this, null);

                MessageBox.Show("Đã Hoàn Tất Việc Xóa", "Thành Công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Nhấn_Nút_Sửa(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if// nếu không có dòng nào được bôi đen
                (this.dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Hãy chọn dòng bản ghi để sửa !", "Sửa Dữ Liệu",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.chọn_dòng(this.dataGridView1.CurrentCell.RowIndex);
            this.Hành_Động = "Sửa";
            this.bật_tắt_nút();// bật form lên để sửa
        }

        // Ràng buộc Text vào nguồn dữ liệu như sau:
        // Chọn phần tử, ví dụ uiTextBox
        // mở hộp Properties (F4)
        // vào mục (DataBindings), sau đó chọn thuộc tính muốn ràng buộc
        private void Nhấn_Nút_Thêm(object sender, EventArgs e)
        {
            //throw new NotImplementedException();

            this.sảnPhẩmBindingSource.AddNew();

            this.Hành_Động = "Thêm";
            this.bật_tắt_nút();
        }

        private void Nhấp_Đúp_Chuột_Vào_Bảng(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.uiNút_Sửa.PerformClick();
        }

        private void Nhấp_Chuột_Vào_Bảng(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            this.chọn_dòng(this.dataGridView1.CurrentCell.RowIndex);
        }

        private void uiTình_Trạng_Kho_Hàng_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
