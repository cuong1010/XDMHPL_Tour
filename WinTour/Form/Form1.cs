using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusAndModel.Model;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinTour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        List<TinhThanh> dstinh = new List<TinhThanh>();
        List<DiaDiem> dsdiadiem = new List<DiaDiem>();
        List<LoaiDL> dsloaidl = new List<LoaiDL>();
        List<CTTour> dscttour = new List<CTTour>();
        List<Tour> dstour = new List<Tour>();
        List<CTTour> dsthamquan = new List<CTTour>();
        void refeshTinh()
        {
            GridTinhThanh.Rows.Clear();
            dstinh = (List<TinhThanh>)db.Laytatcathongtin("TinhThanhs");
            if (dstinh[dstinh.Count - 1] != null)
            {
                foreach (var i in dstinh)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridTinhThanh);
                    row.Cells[0].Value = i.MaTinh;
                    row.Cells[1].Value = i.TenTinh;
                    GridTinhThanh.Rows.Add(row);
                }
            }
        }
        void refeshDD()
        {
            GridDD.Rows.Clear();
            dsdiadiem = (List<DiaDiem>)db.Laytatcathongtin("DiaDiems");
            if (dsdiadiem[dsdiadiem.Count - 1] != null)
            {
                foreach (var i in dsdiadiem)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(GridDD);
                    row.Cells[0].Value = i.TenDiaDiem;
                    row.Cells[1].Value = i.TinhThanh.TenTinh;
                    GridDD.Rows.Add(row);
                }
            }
        }
        #region tabCauHinh

        #region CauHinhTinhThanh
        private void btnThemTinh_Click(object sender, EventArgs e)
        {
            TinhThanh tt = new TinhThanh();
            tt.MaTinh = txtMaTinh.Text;
            tt.TenTinh = txtTenTinh.Text;
            if(db.Them(tt)>0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
            refeshTinh();
        }
        private void btnSuaTinh_Click(object sender, EventArgs e)
        {
            int i = GridTinhThanh.CurrentRow.Index;
            dstinh[i].TenTinh = txtTenTinh.Text;
            dstinh[i].MaTinh = txtMaTinh.Text;
            if (db.Sua(dstinh[i]) > 0) MessageBox.Show("Sửa thành công");
            else MessageBox.Show("Thêm thất bại");
            refeshTinh();
        }
        private void GridTinhThanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = GridTinhThanh.CurrentRow.Index;
            txtMaTinh.Text = GridTinhThanh[0, i].Value.ToString();
            txtTenTinh.Text = GridTinhThanh[1, i].Value.ToString();
        }
        #endregion

        #region cauhinhdiadiem

        private void txtThemDD_Click(object sender, EventArgs e)
        {
            DiaDiem dd = new DiaDiem();
            dd.TenDiaDiem = txtTenDD.Text;
            dd.TinhThanhId = dstinh[cbTinhThanh.SelectedIndex].Id;
            if (db.Them(dd) > 0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
            refeshDD();
        }
        private void txtSuaDD_Click(object sender, EventArgs e)
        {
            int i = GridDD.CurrentRow.Index;
            dsdiadiem[i].TenDiaDiem = txtTenDD.Text;
            dsdiadiem[i].TinhThanhId = dstinh[cbTinhThanh.SelectedIndex].Id;
            if (db.Sua(dsdiadiem[i]) > 0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
            refeshDD();
        }
        private void GridDD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = GridDD.CurrentRow.Index;           
            int vt = -1;
            for (int i = 0; i < dstinh.Count; i++)
                if (dstinh[i].Id == dsdiadiem[row].TinhThanh.Id) vt = i;
            txtTenDD.Text = dsdiadiem[row].TenDiaDiem;
            cbTinhThanh.SelectedIndex= vt;
        }
        private void tabDD_Enter(object sender, EventArgs e)
        {
            cbTinhThanh.Items.Clear();
            if (dstinh[dstinh.Count - 1] != null)
            {
                foreach (var i in dstinh)
                {
                    cbTinhThanh.Items.Add(i.TenTinh);
                }
            }
        }
        #endregion

        #endregion

        #region TaoTour
        private void tabTour_Enter(object sender, EventArgs e)
        {
            refeshTinh();
            refeshDD();
            // load ds tỉnh thành
            cbDSTinhTour.Items.Clear();
            if(dstinh[dstinh.Count-1]!=null)
            foreach (var i in dstinh)
            {
                cbDSTinhTour.Items.Add(i.TenTinh);
            }
            //load ds loại DL
            dsloaidl = (List<LoaiDL>)db.Laytatcathongtin("LoaiDLs");
            if (dsloaidl[dsloaidl.Count-1]!=null)
            foreach (var i in dsloaidl)
            {
                cbLoaiDL.Items.Add(i.TenGoi);
            }
        }
        private void cbDSTinhTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDSDDTuor.Items.Clear();
            int vttinh = cbDSTinhTour.SelectedIndex;
            foreach (var i in dstinh[vttinh].DiaDiems)
                cbDSDDTuor.Items.Add(i.TenDiaDiem);
           
        }
        private void cbDSDDTuor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = new DataGridViewRow();
            row.CreateCells(GridDDTour);
            int vt = cbDSTinhTour.SelectedIndex;
            var dsdd = dstinh[vt].DiaDiems.ToList();
            row.Cells[0].Value = GridDDTour.RowCount + 1;            
            row.Cells[1].Value = dstinh[vt].TenTinh;
            row.Cells[2].Value = dsdd[cbDSDDTuor.SelectedIndex].TenDiaDiem;
            row.Cells[3].Value = "Hủy";
            CTTour ct = new CTTour();
            ct.DiaDiemId= dsdd[cbDSDDTuor.SelectedIndex].Id;
            dscttour.Add(ct);
            GridDDTour.Rows.Add(row);
        }
        private void GridDDTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = GridDDTour.CurrentRow.Index;
            if (Convert.ToBoolean(GridDDTour[3, row].Selected) == true)
            {
                dscttour.RemoveAt(row);
                GridDDTour.Rows.RemoveAt(row);
            }
            for (int i = row; i < GridDDTour.Rows.Count; i++)
            {
                GridDDTour[0, i].Value = i + 1;
            }
        }
        private void btnTao_Click(object sender, EventArgs e)
        {
            Tour tour = new Tour();
            tour.TenGoi = txtTenTour.Text;
            tour.DacDiem = txtDacDiem.Text;
            tour.LoaiDLId = dsloaidl[cbLoaiDL.SelectedIndex].Id;var stt = 1;
            foreach (var i in dscttour)
            {
                i.ThuTuThamQuan = stt;
                tour.CTTours.Add(i);
                stt++;
            }
            GiaTour gia = new GiaTour();
            gia.Gia = Convert.ToInt32(txtGiaTour.Text);
            gia.NgayCapNhat = DateTime.Now.Date;
            tour.GiaTours.Add(gia);
            if (db.Them(tour) > 0)
            {
                txtTenTour.Text = "";
                txtDacDiem.Text = "";
                txtGiaTour.Text = "";
                GridDDTour.Rows.Clear();
                MessageBox.Show("Tạo tour thành công");
            }
            else MessageBox.Show("Tạo tour thất bại");
        }
        #endregion

        #region XemTour
        private void tabXemTour_Enter(object sender, EventArgs e)
        {
            listTour.Items.Clear();
            dstour = (List<Tour>)db.Laytatcathongtin("Tours");
            foreach (var i in dstour)
                listTour.Items.Add(i.TenGoi);
        }

        private void listTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            int i = listTour.SelectedIndex;
            if (i >= 0)
            {
                lbTenTour.Text = dstour[i].TenGoi;
                lbDacDiem.Text = dstour[i].DacDiem;
                lbLoaiDL.Text = dstour[i].LoaiDL.TenGoi;
                dsthamquan = dstour[i].CTTours.ToList();
                listTrinhTuThamQuan.Items.Clear();           
                foreach (var ct in dsthamquan)
                {
                    listTrinhTuThamQuan.Items.Add(ct.DiaDiem.TenDiaDiem+"".PadLeft(10)+"("+ ct.DiaDiem.TinhThanh.TenTinh + ")");                 
                }
                listTrinhTuThamQuan.SelectedIndex = 0;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int i = listTrinhTuThamQuan.SelectedIndex;
            if (i > 0)
            {
                var temp = listTrinhTuThamQuan.Items[i];
                listTrinhTuThamQuan.Items[i] = listTrinhTuThamQuan.Items[i - 1];
                listTrinhTuThamQuan.Items[i - 1] = temp;
                var temp2 = dsthamquan[i].DiaDiem;
                dsthamquan[i].DiaDiem = dsthamquan[i - 1].DiaDiem;
                dsthamquan[i - 1].DiaDiem = temp2;
                listTrinhTuThamQuan.SelectedIndex = i-1;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int i = listTrinhTuThamQuan.SelectedIndex;
            if (i < dsthamquan.Count-1)
            {
                var temp = listTrinhTuThamQuan.Items[i];
                listTrinhTuThamQuan.Items[i] = listTrinhTuThamQuan.Items[i + 1];
                listTrinhTuThamQuan.Items[i + 1] = temp;
                var temp2 = dsthamquan[i].DiaDiem;
                dsthamquan[i].DiaDiem = dsthamquan[i + 1].DiaDiem;
                dsthamquan[i + 1].DiaDiem = temp2;
                listTrinhTuThamQuan.SelectedIndex = i + 1;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool flag = true;
            Tour a = dstour[listTour.SelectedIndex];
            for (int i = 0; i < dsthamquan.Count; i++)
            {
                a.CTTours.ToList()[i].DiaDiem = dsthamquan[i].DiaDiem;
               
            }
                if (db.Sua(a) == 0) { flag = false; }
            
            if (flag)
                MessageBox.Show("Cập nhật thành công");
            else MessageBox.Show("Cập nhật thất bại");
        }

        private void btnGia_Click(object sender, EventArgs e)
        {
            if(listTour.SelectedIndex>=0)
            new frmGiaTour(dstour[listTour.SelectedIndex].Id).ShowDialog();
        }
        #endregion

        private void btnTKDoanhThu_Click(object sender, EventArgs e)
        {
            foreach (var series in chartDoanhThu.Series)
            {
                series.Points.Clear();
            }

            DateTime frm = Convert.ToDateTime(doanhthufrom.Text);
            DateTime to = Convert.ToDateTime(doanhthuto.Text);
            if (to < frm) MessageBox.Show("Ngày Sau Phải Lớn Hơn Ngày Trước", "Thông Báo");
            else
            {
                var kqtke = new BusTour().Thongkedoanhthu(frm, to);
                if (kqtke == null) MessageBox.Show("Không có tour nào được tạo", "Thông Báo");
                else
                {
                    var tke = (List<Tour>)db.Laytatcathongtin("Tours");
                    for (int i = 0; i < tke.Count; i++)
                    {
                        chartDoanhThu.Series[0].Points.AddXY(tke[i].TenGoi, kqtke[i, 0]);
                        
                        chartDoanhThu.Series[1].Points.AddY(kqtke[i, 1]);                       
                    }
                    foreach (Series srs in chartDoanhThu.Series)
                    {
                        srs.IsValueShownAsLabel = false;
                        foreach (DataPoint point in srs.Points)
                        {
                            if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) != 0)
                            {
                                point.IsValueShownAsLabel = true;
                            }
                        }
                    }
                }
                
            }
        }
        private void btnTKHD_Click(object sender, EventArgs e)
        {
            foreach (var series in chartHD.Series)
            {
                series.Points.Clear();
            }

            DateTime frm = Convert.ToDateTime(TKHDfrom.Text);
            DateTime to = Convert.ToDateTime(TKHDto.Text);
            if (to < frm) MessageBox.Show("Ngày Sau Phải Lớn Hơn Ngày Trước", "Thông Báo");
            else
            {
                var kqtke = new BusTour().ThongkeHD(frm, to);
                if (kqtke == null) MessageBox.Show("Không có tour nào được tạo", "Thông Báo");
                else
                {
                    var tke = (List<Tour>)db.Laytatcathongtin("Tours");
                    for (int i = 0; i < tke.Count; i++)
                    {
                        chartHD.Series[0].Points.AddXY(tke[i].TenGoi, kqtke[i, 0]);                        
                        chartHD.Series[1].Points.AddY(kqtke[i, 1]);
                        chartHD.Series[2].Points.AddY(kqtke[i, 2]);
                    }
                    foreach (Series srs in chartHD.Series)
                    {
                        srs.IsValueShownAsLabel = false;
                        foreach (DataPoint point in srs.Points)
                        {
                            if (point.YValues.Length > 0 && (double)point.YValues.GetValue(0) != 0)
                            {
                                point.IsValueShownAsLabel = true;
                            }
                        }
                    }
                }

            }
        }
    }
}
