using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GodChat
{
    public partial class GetNickName : Form
    {
        public GetNickName()
        {
            InitializeComponent();
        }

        private void btnSuchNickName_Click(object sender, EventArgs e)
        {
            if (txtNickName.Text == string.Empty)
            {
                txtNickName.Focus();
                return;
            }

            
            this.Close();
        }
        
        public string GetName()
        {
            return txtNickName.Text.Trim();
        }

        private void GetNickName_Load(object sender, EventArgs e)
        {
            txtNickName.Focus();
        }
    }
}
