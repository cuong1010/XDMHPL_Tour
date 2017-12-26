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
    public partial class frmGiaTour : Form
    {
        Database db = new Database();
        Tour tour;
        public frmGiaTour(int idtour)
        {
            var dstour = (List<Tour>)db.Laytatcathongtin("Tours");
            foreach (var i in dstour)
            {
                if (i.Id == idtour) tour = i;
            }                   
            InitializeComponent();
            refeshGia();
        }
        void refeshGia()
        {
            GridGia.Rows.Clear();
            foreach (var i in tour.GiaTours)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(GridGia);
                row.Cells[0].Value = i.NgayCapNhat;
                row.Cells[1].Value = String.Format(	"{0:0,0}",i.Gia);
                GridGia.Rows.Add(row);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            GiaTour a = new GiaTour();
            a.Gia = Convert.ToInt32(txtGia.Text);
            a.NgayCapNhat = Convert.ToDateTime(txtNgay.Text);
            tour.GiaTours.Add(a);
            if (db.Sua(tour) > 0) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
            refeshGia();
        }
    }
}
