using System;
using System.Windows.Forms;

namespace DesingPatternsInForms.Strategy
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var maths = new Maths();

            maths.Number1 = Convert.ToInt32(textBoxNumber1.Text);
            maths.Number2 = Convert.ToInt32(textBoxNumber2.Text);

            maths.SetStrategy(new AddStrategy());

            textBoxResult.Text = maths.Calculate().ToString();
        }

        private void buttonSubstract_Click(object sender, EventArgs e)
        {
            var maths = new Maths();

            maths.Number1 = Convert.ToInt32(textBoxNumber1.Text);
            maths.Number2 = Convert.ToInt32(textBoxNumber2.Text);

            maths.SetStrategy(new SubstractStrategy());

            textBoxResult.Text = maths.Calculate().ToString();
        }
    }
}
