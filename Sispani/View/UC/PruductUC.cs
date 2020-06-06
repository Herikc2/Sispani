using System;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class ProductUC : UserControl
    {
        public ProductUC()
        {
            InitializeComponent();
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            cboInsertUnity.SelectedItem = cboInsertUnity.Items[0];
        }
    }
}
