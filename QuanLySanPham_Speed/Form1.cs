using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Text.RegularExpressions;

namespace QuanLySanPham_Speed
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        bool ktra = false;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "2XvGfHe8s7gh72U6Tb6GZa7GMJIUienwZLlOjHd9",
            BasePath = "https://quanlysanpham2-e7a54-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        //IFirebaseConfig config = new FirebaseConfig
        //{
        //    AuthSecret = "52eeKBiVG9Cs3Jbu0KHLEtSlMLtoxZPrpE3PQ4lP",
        //    BasePath = "https://quanlysanpham-9c9e6-default-rtdb.asia-southeast1.firebasedatabase.app/"
        //};

        IFirebaseClient client;

        public bool CheckSoLuong(string soluong)
        {
            return Regex.IsMatch(soluong, "^[0-9]{1,2}$");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
                load();
                load2();
                btnSua.Enabled = false;
                //BindingListSP();
            }
            catch
            {
                //MessageBox.Show("Ket noi that bai");
            }
        }

        private void RetriveSP()
        {
            FirebaseResponse resp = client.Get(@"QuanLySanPham");
            Dictionary<string, Data1> data1 = JsonConvert.DeserializeObject<Dictionary<string, Data1>>(resp.Body.ToString());
            dt.Rows.Clear();
            
            foreach (var item in data1)
            {
                DataRow row = dt.NewRow();
                row["MaSP"] = item.Value.MaSP;
                row["TenSP"] = item.Value.TenSP;
                row["SoLuong"] = item.Value.SoLuong;
                row["ViTri"] = item.Value.ViTri;
                row["Status"] = item.Value.Status;

                dt.Rows.Add(row);
            }
        }

        public async void RetriveGioHang()
        {
            dt2.Rows.Clear();
            int i = 0;
            FirebaseResponse response21 = await client.GetAsync("Count2");
            Count2 obj21 = response21.ResultAs<Count2>();
            int cnt2 = Convert.ToInt32(obj21.cnt2);

            while (true)
            {
                if ((i-1) == (cnt2-1))
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse response22 = await client.GetAsync("QuanLyGioHang/" + (i-1));
                    Data2 obj22 = response22.ResultAs<Data2>();

                    DataRow row = dt2.NewRow();

                    row["MaSP2"] = obj22.MaSP2;
                    row["TenSP2"] = obj22.TenSP2;
                    row["SoLuongMuonLay"] = obj22.SoLuongMuonLay;
                    row["ViTri2"] = obj22.ViTri2;

                    dt2.Rows.Add(row);
                    Total2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void load()
        {
            dt.Columns.Add("MaSP");
            dt.Columns.Add("TenSP");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("ViTri");
            dt.Columns.Add("Status");

            dtgSanPham.DataSource = dt;

            dtgSanPham.Columns[0].HeaderText = "Mã Sản Phẩm";
            dtgSanPham.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgSanPham.Columns[2].HeaderText = "Số Lượng Hàng Còn Trong Kho";
            dtgSanPham.Columns[3].HeaderText = "Vị Trí";
            dtgSanPham.Columns[4].HeaderText = "Status";            
            dtgSanPham.Columns[0].Width = 130;
            dtgSanPham.Columns[1].Width = 170;
            dtgSanPham.Columns[2].Width = 200;
            dtgSanPham.Columns[3].Width = 130;

            RetriveSP();
            ToTal();
        }

        void load2()
        {
            client = new FireSharp.FirebaseClient(config);

            dt2.Columns.Add("MaSP2");
            dt2.Columns.Add("TenSP2");
            dt2.Columns.Add("SoLuongMuonLay");
            dt2.Columns.Add("ViTri2");

            dtgGioHang.DataSource = dt2;

            dtgGioHang.Columns[0].HeaderText = "Mã Sản Phẩm";
            dtgGioHang.Columns[1].HeaderText = "Tên Sản Phẩm";
            dtgGioHang.Columns[2].HeaderText = "Số Lượng Muốn Lấy";
            dtgGioHang.Columns[3].HeaderText = "Vị Trí";
            dtgGioHang.Columns[0].Width = 90;
            dtgGioHang.Columns[1].Width = 140;
            dtgGioHang.Columns[2].Width = 150;
            dtgGioHang.Columns[3].Width = 150;

            RetriveGioHang();
            Total2();
        }

        private void ToTal()
        {
            int count = 0;
            if (dtgSanPham.Rows.Count <= 0)
            {
                txtToTal.Text = "0";
            }
            else
            {
                count = Convert.ToInt32(dtgSanPham.Rows.Count);
                txtToTal.Text = count.ToString();
            }
            if(dtgSanPham.Rows.Count <= 1)
            {
                btnXoa1.Enabled = false;
            }    
            if(dtgSanPham.Rows.Count > 1)
            {
                btnXoa1.Enabled = true;
            }    
        }

        private void Total2()
        {
            int count = 0;
            if (dtgGioHang.Rows.Count <= 0)
            {
                txtToTal2.Text = "0";
            }
            else
            {
                count = Convert.ToInt32(dtgGioHang.Rows.Count);
                txtToTal2.Text = count.ToString();
            }
        }

        //void BindingListSP()
        //{
        //    txtMSP.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "MaSP", true, DataSourceUpdateMode.Never));
        //    txtTSP.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "TenSP", true, DataSourceUpdateMode.Never));
        //    txtSL.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "SoLuong", true, DataSourceUpdateMode.Never));
        //    txtViTri.DataBindings.Add(new Binding("Text", dtgSanPham.DataSource, "ViTri", true, DataSourceUpdateMode.Never));
        //}

        private void dtgSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex==-1)
            {
                return;
            }
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            txtMSP.Enabled = false;
            DataGridViewRow row = dtgSanPham.Rows[e.RowIndex];
            string maSP = row.Cells[0].Value.ToString();
            string tenSP = row.Cells[1].Value.ToString();
            string soLuong = row.Cells[2].Value.ToString();
            string viTri = row.Cells[3].Value.ToString();
            string status = row.Cells[4].Value.ToString();      

            txtMSP.Text = maSP;
            txtTSP.Text = tenSP;
            txtSL.Text = soLuong;
            txtViTri.Text = viTri;
            txtStatus.Text = status;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "TenSP", "*" + txtSearch.Text + "*");//"TenSP like *" + txtLoSanPham.text + "*"
            (dtgSanPham.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }
        void Reset()
        {
            txtMSP.Clear();
            txtTSP.Clear();
            txtSL.Clear();
            txtViTri.Clear();
            txtStatus.Clear();
            txtMSP.Focus();
            btnThem.Enabled = true;
        }

        private async void UpdateSP()
        {
            if (txtMSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSP.Focus();
            }
            else if(!CheckSoLuong(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm đúng quy định (0-99)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtTSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTSP.Focus();
            }
            else if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Focus();
            }
            else if (txtViTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtViTri.Focus();
            }
            else
            {
                var data1 = new Data1
                {
                    MaSP = txtMSP.Text,
                    TenSP = txtTSP.Text,
                    SoLuong = txtSL.Text,
                    ViTri = txtViTri.Text,
                    Status = txtStatus.Text,
                };

                FirebaseResponse response = await client.UpdateAsync("QuanLySanPham/" + txtMSP.Text, data1);
                Data1 result = response.ResultAs<Data1>();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
                RetriveSP();
            }
        }

        private async void AddSP()
        {
            if (txtMSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMSP.Focus();
            }
            else if (txtTSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTSP.Focus();
            }
            else if (!CheckSoLuong(txtSL.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng sản phẩm đúng quy định (0-99)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtSL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSL.Focus();
            }
            else if (txtViTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtViTri.Focus();
            }
            else
            {
                //Lấy tổng số lượng sản phẩm có trong kho
                FirebaseResponse response1 = await client.GetAsync("Count");
                Count1 get = response1.ResultAs<Count1>();
                var data = new Data1
                {
                    MaSP = txtMSP.Text,
                    TenSP = txtTSP.Text,
                    SoLuong = txtSL.Text,
                    ViTri = txtViTri.Text,
                    Status = "1",
                };
                //Đẩy dữ liệu lên Firebase
                SetResponse response2 = await client.SetAsync("QuanLySanPham/" + data.MaSP, data);
                Data1 result = response2.ResultAs<Data1>();
                MessageBox.Show("Đã thêm mới thành công!");
                Reset();

                var obj = new Count1
                {
                    cnt = (Convert.ToInt32(get.cnt) + 1).ToString(),
                };
                SetResponse response3 = await client.SetAsync("Count", obj);
                RetriveSP();
                ToTal();
            }
        }

        private async void AddGioHang()
        {
            FirebaseResponse response20 = await client.GetAsync("QuanLySanPham/" + txtMSP.Text);
            Data1 result1 = response20.ResultAs<Data1>();
            int soluong = Convert.ToInt32(result1.SoLuong);
            string status = result1.Status;
            
            if (!CheckSoLuong(txtSoLuongLay.Text)||txtSoLuongLay.Text == "" || Convert.ToInt32(txtSoLuongLay.Text) > soluong || soluong.ToString() == "0" || txtSoLuongLay.Text == "0")
            {
                MessageBox.Show("Hàng trong kho không đáp ứng được!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongLay.Clear();
            }
            else if (status == "0")
            {
                MessageBox.Show("Sản phẩm này đã có trong giỏ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuongLay.Clear();
            }
            else
            {
                FirebaseResponse response21 = await client.GetAsync("Count2");
                Count2 get = response21.ResultAs<Count2>();
                {
                    var data = new Data2
                    {
                        MaSP2 = txtMSP.Text,
                        TenSP2 = txtTSP.Text,
                        SoLuongMuonLay = txtSoLuongLay.Text,
                        ViTri2 = txtViTri.Text,
                    };
                    var obj2 = new Count2
                    {
                        cnt2 = (Convert.ToInt32(get.cnt2) + 1).ToString(),
                        //cnt2 = (Convert.ToInt32(get.cnt2).ToString())
                    };
                    SetResponse response24 = await client.SetAsync("Count2", obj2);
                    //Đẩy dữ liệu lên Firebase
                    SetResponse response22 = await client.SetAsync("QuanLyGioHang/" + (Convert.ToInt32(obj2.cnt2)-1).ToString(), data);
                    Data2 result2 = response22.ResultAs<Data2>();
                    int soluonglay = int.Parse(result2.SoLuongMuonLay);

                    var data1 = new Data1
                    {
                        MaSP = txtMSP.Text,
                        TenSP = txtTSP.Text,
                        SoLuong = (soluong - soluonglay).ToString(),
                        ViTri = txtViTri.Text,
                        Status = "0",
                    };
                    FirebaseResponse response23 = await client.UpdateAsync("QuanLySanPham/" + txtMSP.Text, data1);
                    Data1 result3 = response23.ResultAs<Data1>();
                    MessageBox.Show("Đã thêm vào giỏ hàng thành công!");
                    txtSoLuongLay.Clear();
                    Reset();
                    RetriveSP();
                    RetriveGioHang();
                }               
            }
        }

        private async void Delete1SP()
        {
            if(txtMSP.Text == ""||txtTSP.Text == ""||txtSL.Text == ""||txtViTri.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm để xóa!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này khỏi kho?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FirebaseResponse response1 = await client.GetAsync("Count");
                    Count1 get = response1.ResultAs<Count1>();
                    int cnt = Convert.ToInt32(get.cnt);

                    FirebaseResponse response2 = await client.DeleteAsync("QuanLySanPham/" + txtMSP.Text);

                    var obj = new Count1
                    {
                        cnt = (Convert.ToInt32(get.cnt) - 1).ToString(),
                    };
                    SetResponse response3 = await client.SetAsync("Count", obj);
                    MessageBox.Show("Đã xóa thành công! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RetriveSP();
                    ToTal();
                    Reset();
                }
            }
            
        }

        private async void CreateNewGioHang()
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn tạo mới giỏ hàng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                FirebaseResponse response20 = await client.GetAsync("Count2");
                Count2 get = response20.ResultAs<Count2>();
                int cnt = Convert.ToInt32(get.cnt2);
                int i = 0;
                while (true)
                {
                    if (i == cnt)
                    {
                        break;
                    }
                    i++;
                    try
                    {
                        FirebaseResponse response21 = await client.DeleteAsync("QuanLyGioHang/" + i);                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                var obj = new Count2
                {
                    cnt2 = "0",
                };
                SetResponse response3 = await client.SetAsync("Count2", obj);
                SetResponse response4 = await client.SetAsync("QuanLyGioHang", "Giỏ hàng đang trống");

                UpdateStatus();

                RetriveGioHang();
                txtToTal2.Text = "0";
            }
        }

        private void UpdateStatus()
        {
            FirebaseResponse resp = client.Get(@"QuanLySanPham");
            Dictionary<string, Data1> data = JsonConvert.DeserializeObject<Dictionary<string, Data1>>(resp.Body.ToString());
            UpdateSanPhamTrongKho(data);
        }

        private void UpdateSanPhamTrongKho(Dictionary<string, Data1> record)
        {
            foreach (var item in record)
            {
                item.Value.Status = "1";
            }
            FirebaseResponse resp = client.Update(@"QuanLySanPham", record);
            RetriveSP();
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Quản lý kho hàng";

                // export header
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export content
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ToExcel(dtgGioHang, saveFileDialog1.FileName);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
            txtMSP.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            UpdateSP();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            AddSP();
        }

        private void btnXoa1_Click(object sender, EventArgs e)
        {
            Delete1SP();
        }

        private void btnThemVaoGioHang_Click(object sender, EventArgs e)
        {
            AddGioHang();
        }

        private void btnGioHangMoi_Click(object sender, EventArgs e)
        {
            CreateNewGioHang();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rt = MessageBox.Show("Bạn muốn thoát?", "Thoát"
                                , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rt == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
