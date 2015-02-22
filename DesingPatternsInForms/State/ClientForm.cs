using System;
using System.Windows.Forms;

namespace DesingPatternsInForms.State
{
    public partial class ClientForm : Form
    {
        private State _state = new State();

        public ClientForm()
        {
            InitializeComponent();
            GetStatus();
        }

        private void buttonPressSwitch_Click(object sender, EventArgs e)
        {
            _state.PressSwitch();
            GetStatus();
        }

        private void GetStatus()
        {
            textBoxState.Text = _state.GetStatus();
        }
    }
}
