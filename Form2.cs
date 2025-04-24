using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine
{
    
    public partial class Form2 : Form
    {
        Form1 form1Ref = new Form1();
        public string received;
        public int receivedNumber, itemPrice;
        public Form2(string received, int receivedNumber, int price)
        {
            InitializeComponent();

            this.received = received;
            this.receivedNumber = receivedNumber;
            this.itemPrice = price;
            MakeTheShopping();
        }

        private void MakeTheShopping()
        {
            // add the item label
            Label itemLabel = new Label();
            itemLabel.Name = "ItemLabel";
            itemLabel.Text = this.received;
            itemLabel.Size = new Size(150, 50);
            itemLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            itemLabel.Location = new Point(300, 150);
            itemLabel.ForeColor = Color.White;
            this.Controls.Add(itemLabel);

            // add the item number label
            Label itemNumberLabel = new Label();
            itemNumberLabel.Name = "ItemNumberLabel";
            itemNumberLabel.Text = this.receivedNumber.ToString();
            itemNumberLabel.Size = new Size(80, 50);
            itemNumberLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            itemNumberLabel.Location = new Point(300, 200);
            itemNumberLabel.ForeColor = Color.White;
            this.Controls.Add(itemNumberLabel);

            // add the item price label
            Label itemPriceLabel = new Label();
            itemPriceLabel.Name = "ItemPriceLabel";
            itemPriceLabel.Text = this.itemPrice.ToString() + " TL";
            itemPriceLabel.Size = new Size(150, 50);
            itemPriceLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            itemPriceLabel.Location = new Point(380, 200);
            itemPriceLabel.ForeColor = Color.White;
            this.Controls.Add(itemPriceLabel);

            // add the pay button
            Button payButton = new Button();
            payButton.Name = "PayButton";
            payButton.Text = "Pay";
            payButton.Size = new Size(80, 30);
            payButton.Location = new Point(300, 250);
            payButton.BackColor = Color.White;
            payButton.Click += new EventHandler(PayButton_Click);
            this.Controls.Add(payButton);

            //add the cancel button
            Button cancelButton = new Button();
            cancelButton.Name = "CancelButton";
            cancelButton.Text = "Cancel";
            cancelButton.Size = new Size(80, 30);
            cancelButton.Location = new Point(400, 250);
            cancelButton.BackColor = Color.White;
            cancelButton.Click += new EventHandler(CancelButton_Click);
            this.Controls.Add(cancelButton);

            // add the paying label
            Label payingLabel = new Label();
            payingLabel.Name = "PayingLabel";
            payingLabel.Text = "Enter the amount you are paying";
            payingLabel.Size = new Size(450, 50);
            payingLabel.Font = new Font("Arial", 16, FontStyle.Bold);
            payingLabel.Location = new Point(150, 300);
            payingLabel.ForeColor = Color.White;
            this.Controls.Add(payingLabel);

            // add the paying textbox
            TextBox payingTextBox = new TextBox();
            payingTextBox.Name = "PayingTextBox";
            payingTextBox.Size = new Size(100, 30);
            payingTextBox.Location = new Point(300, 350);
            this.Controls.Add(payingTextBox);

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // Close the form

            Form1.UpdateData(receivedNumber);
            this.Close();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the amount paid from the textbox
                TextBox payingTextBox = (TextBox)this.Controls["PayingTextBox"];
                int amountPaid = int.Parse(payingTextBox.Text);
                // Check if the amount paid is enough
                if (amountPaid >= itemPrice)
                {
                    MessageBox.Show("Payment successful!");
                    MessageBox.Show("Your change is: " + (amountPaid - itemPrice) + " TL");
                    receivedNumber -= 1;
                    Form1.UpdateData(receivedNumber);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Not enough money!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
