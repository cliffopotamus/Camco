using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamcoForm
{
    public partial class NewCustomerForm : Form
    {
        public NewCustomerForm()
        {
            InitializeComponent();
        }

        private void BtnCustomerAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelZipCode_Click(object sender, EventArgs e)
        {

        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCustomerForm_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        /*
private void buttonFinishCustomer_Click(object sender, EventArgs e)
{
  string messageName = textBoxName.Text;
  MessageBox.Show(messageName);
  var Cust = new Customers();
  Cust.name = textBoxName;


  string message = "Do you want to close this window?";
  string title = "Close Window";
  MessageBoxButtons buttons = MessageBoxButtons.YesNo;
  DialogResult result = MessageBox.Show(message, title, buttons);

  if (result == DialogResult.Yes)
  {
      this.Close();
  }
  else
  {
      //DO SOMETHING 
  }

}
}

public class Customers
{
public string name;

public Customers();


}
*/
    }
}


