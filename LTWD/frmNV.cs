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
    public partial class frmNV : Form
    {
        public delegate void UpdateDataDelegate(string maNV, string tenNV, decimal luongCB);
        public UpdateDataDelegate UpdateData;
        public string MSNV { get; set; }
        public string TenNV { get; set; }
        public decimal LuongCB { get; set; }
        public frmNV(string maNV = "", string tenNV = "", decimal luongCB = 0)
        {
            InitializeComponent();

            // Hiển thị dữ liệu nếu đang sửa
            MSNV = maNV;
            TenNV = tenNV;
            LuongCB = luongCB;

            txtMSNV.Text = MSNV;
            txtTenNV.Text = TenNV;
            txtLuongCb.Text = LuongCB.ToString();
        }
    

        private void btnDongy_Click(object sender, EventArgs e)
        {

            if (UpdateData != null)
            {
                UpdateData(txtMSNV.Text, txtTenNV.Text, decimal.Parse(txtLuongCb.Text));
            }

            this.Close();
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
