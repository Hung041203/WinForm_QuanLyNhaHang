using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class UC_DSChucVu: UserControl
    {
        DSChucVuBLL dSChucVu = new DSChucVuBLL();
        public UC_DSChucVu()
        {
            InitializeComponent();
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            DataTable dt = dSChucVu.Get_ListChucVu();
            dataGridView_DSChucVu.DataSource = dt;
        }
    }
}
