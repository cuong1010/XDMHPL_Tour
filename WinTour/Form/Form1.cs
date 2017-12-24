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
        List<TinhThanh> dstinh = new List<TinhThanh>();
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
        private void tabCauhinh_Enter(object sender, EventArgs e)
        {
            refeshTinh();
        }
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
    }
}
