using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTWD
{
    public partial class frmListView : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private List<Nv> list = new List<Nv>();
        DataGridViewCellEventArgs e;

        public frmListView()
        {
            InitializeComponent();
            update();
         
        }
   

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.e!=null)
            {
                OpenNhanVienForm(true,this.e.RowIndex);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
            }
        }
        private void OpenNhanVienForm(bool isEdit, int rowIndex = -1)
        {
            string maNV = "", tenNV = "";
            decimal luongCB = 0;

            if (isEdit && rowIndex >= 0)
            {
                var nv = list[rowIndex];
                maNV = nv.MSNV;
                tenNV = nv.TenNV;
                luongCB = nv.LuongCB;
            }

            frmNV formNhanVien = new frmNV(maNV, tenNV, luongCB);
            formNhanVien.UpdateData = (newMaNV, newTenNV, newLuongCB) =>
            {
                if (isEdit)
                {
                    list[rowIndex] = new Nv(newMaNV, newTenNV, newLuongCB);
                }
                else
                {
                    list.Add(new Nv(newMaNV, newTenNV, newLuongCB));
                }
                update();
            };

            formNhanVien.ShowDialog();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            frmNV formNhanVien = new frmNV();

            // Đăng ký delegate để nhận dữ liệu
            formNhanVien.UpdateData = (maNV, tenNV, luongCB) =>
            {
                list.Add(new Nv(maNV, tenNV, luongCB));
                update();
            };

            formNhanVien.ShowDialog();
        }

        private void update()
        {
            dataGridView1.DataSource = new BindingList<Nv>(list);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.e!=null)
            {
                list.RemoveAt(this.e.RowIndex);
                update();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!", "Thông báo");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < list.Count)
            {
                this.e = e;
            }
            else
            {
                this.e = null; 
            }
        }
    }
}
