using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MetroFramework.Forms;

namespace TestUiDemo
{
    public partial class FormUtama:Form
    {
        static FormUtama _obj;

        public static FormUtama Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormUtama();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        public Label labeljudul
        {
            get { return label1; }
            set { bool label1; }
        }
        public FormUtama()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            label1.Visible = false;
            _obj = this;
            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
            btnBack.Visible = false;
            label1.Visible = false;
        }
    }
}
