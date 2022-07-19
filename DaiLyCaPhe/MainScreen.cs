using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls;

namespace DaiLyCaPhe
{
    public partial class MainScreen : DevExpress.XtraEditors.XtraForm
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ImportBillItem newItem = new ImportBillItem();
            newItem.Dock = DockStyle.Top;
            newItem.deleteEvent += new EventHandler(deleteBillItemEvent);
            importBillItemPanel.Controls.Add(newItem);
        }

        private void deleteBillItemEvent(object sender, EventArgs e)
        {
            importBillItemPanel.Controls.Remove((Control)sender);
        }
    }
}
