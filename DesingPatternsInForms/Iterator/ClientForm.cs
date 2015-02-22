using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPatternsInForms.Iterator
{
    public partial class ClientForm : Form
    {
        private Iterator _iterator = new Iterator();

        private readonly Customer _error = new Customer { Name = "Error", Code = "Error" };

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            _iterator.FillObjects();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomer(_iterator.GetFirst());
            }
            catch
            {
                DisplayCustomer(_error);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomer(_iterator.GetPrevious());
            }
            catch
            {
                DisplayCustomer(_error);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomer(_iterator.GetNext());
            }
            catch
            {
                DisplayCustomer(_error);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomer(_iterator.GetLast());
            }
            catch
            {
                DisplayCustomer(_error);
            }
        }

        private void buttonGetByIndex_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCustomer(_iterator.GetByIndex(Convert.ToInt32(textBoxIndex.Text)));
            }
            catch
            {
                DisplayCustomer(_error);
            }
        }

        private void DisplayCustomer(Customer customer)
        {
            textBoxCustomerName.Text = customer.Name;
            textBoxCustomerCode.Text = customer.Code;
        }
    }
}
