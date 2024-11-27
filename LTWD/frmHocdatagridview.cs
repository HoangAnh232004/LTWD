using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTWD
{
    public partial class frmHocdatagridview : Form
    {
        DataGridViewCellEventArgs Ev;
        List<Student> students = new List<Student>();
        public frmHocdatagridview()
        {
            InitializeComponent();
        }
        List<Student> Students = new List<Student>();

        private void frmHocdatagridview_Load(object sender, EventArgs e)
        {
          
            students.Add(new Student(1, "A", "0234384233"));
            students.Add(new Student(2, "B", "4254565"));
            students.Add(new Student(3, "C", "254544"));
            dataGridView1.DataSource = students;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Ev = e;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                txtID.Text = selectedRow.Cells["Id"].Value?.ToString();
                txtPhone.Text = selectedRow.Cells["Phone"].Value?.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    row.Cells["ID"].Value = int.Parse(txtID.Text);
                    row.Cells["Name"].Value = txtName.Text;
                    row.Cells["Phone"].Value = int.Parse(txtPhone.Text);
                    ClearInputs();
                }
                else
                {
                    MessageBox.Show("Please select a single row to edit.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing data: " + ex.Message);
            }
        }
        private void ClearInputs()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhone.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string Phone = txtPhone.Text;
            students.Add(new Student(id, name, Phone));
            dataGridView1.DataSource = new BindingList<Student>(students);

        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            students.RemoveAt(Ev.RowIndex);
            dataGridView1.DataSource = new BindingList<Student>(students);
        }

        private void btnGuidulieu_Click(object sender, EventArgs e)
        {
            frmNhanDATA f = new frmNhanDATA();
            delPassData del = new delPassData(f.funData);
            del(textBox1);
            f.Show();
        }
        public delegate void delPassData(System.Windows.Forms.TextBox text);
    }
    
}
