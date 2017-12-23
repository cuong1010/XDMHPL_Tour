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
            refeshTinh();
            refeshDD();
        }
        List<TinhThanh> dstinh = new List<TinhThanh>();
        List<DiaDiem> dsdiadiem = new List<DiaDiem>();
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
        private void tabCauhinh_Enter(object sender, EventArgs e)
        {
            
        }

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
        private void cbTinhThanh_Click(object sender, EventArgs e)
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
            refeshDD();
        }
        #endregion
       
    }
}
