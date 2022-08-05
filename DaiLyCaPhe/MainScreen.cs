using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CustomControls;
using DaiLyCaPhe.Forms;

namespace DaiLyCaPhe
{
    public partial class MainScreen : DevExpress.XtraEditors.XtraForm
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void formProcessPaper_Load(object sender, EventArgs e)
        {

        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ImportBillForm importBillForm = new ImportBillForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            tabNavigationPageImportBill.Controls.Add(importBillForm);
            importBillForm.Show();

            ExportBillForm exportBillForm = new ExportBillForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            tabNavigationPageExportBill.Controls.Add(exportBillForm);
            exportBillForm.Show();

            ProcessPaperForm processPaperForm = new ProcessPaperForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            tabNavigationPageProcessPaper.Controls.Add(processPaperForm);
            processPaperForm.Show();
        }
    }
}
