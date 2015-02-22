using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPatternsInForms.Memento
{
    public partial class ClientForm : Form
    {
        private Customer _customer = new Customer();

        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _customer.Name = textBoxCustomerName.Text;
            _customer.Code = textBoxCustomerCode.Text;
            _customer.Address = textBoxCustomerAddress.Text;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _customer.Revert();
            DisplayCustomer();
        }

        private void DisplayCustomer()
        {
            textBoxCustomerName.Text = _customer.Name;
            textBoxCustomerCode.Text = _customer.Code;
            textBoxCustomerAddress.Text = _customer.Address;
        }
    }
}
