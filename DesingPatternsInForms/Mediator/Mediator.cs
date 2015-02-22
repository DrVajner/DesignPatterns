using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesingPatternsInForms.Mediator
{
    internal class Mediator
    {
        private TextBox _nameTextBox;
        private ListBox _nameListBox;
        private Button _addButton;
        private Button _clearButton;

        public void Register(TextBox tb)
        {
            _nameTextBox = tb;
        }
        public void Register(ListBox lb)
        {
            _nameListBox = lb;
        }
        public void Register(Button b)
        {
            if (b.Text == "Add")
            {
                _addButton = b;
            }
            else
            {
                _clearButton = b;
            }
        }

        public void TextChange()
        {
            if (string.IsNullOrWhiteSpace(_nameTextBox.Text))
            {
                _addButton.Enabled = false;
                _clearButton.Enabled = false;
            }
            else
            {
                _addButton.Enabled = true;
                _clearButton.Enabled = true;
            }
        }
        public void ClickAddButton()
        {
            _nameListBox.Items.Add(_nameTextBox.Text);
            _nameTextBox.Text = string.Empty;
            _addButton.Enabled = false;
            _clearButton.Enabled = false;
        }
        public void ClickClearButton()
        {
            _nameTextBox.Text = string.Empty;
            _addButton.Enabled = false;
            _clearButton.Enabled = false;
        }
    }
}
