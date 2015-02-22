using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPatternsInForms.Mediator
{
    public partial class ClientForm : Form
    {
        private Mediator _mediator = new Mediator();

        public ClientForm()
        {
            InitializeComponent();

            _mediator.Register(textBoxName);
            _mediator.Register(listBoxNames);
            _mediator.Register(buttonAdd);
            _mediator.Register(buttonClear);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            _mediator.TextChange();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _mediator.ClickAddButton();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            _mediator.ClickClearButton();
        }
    }
}
