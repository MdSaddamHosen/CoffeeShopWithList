using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWithList
{
    public partial class CoffeeShopWithList : Form
    {
        List<string> Customernames = new List<string> { };
        List<string> ContactNumbers = new List<string> { };
        List<string> addresses = new List<string> { };
        List<string> OderItem = new List<string> { };
        List<int> quantities = new List<int> { };
        List<int> totalPrices = new List<int> { };
        public CoffeeShopWithList()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (Customernames.Contains(contactNoTextBox.Text) == true)
            {
                MessageBox.Show("Number Already Exists");
            }
            else if (orderItemComboBox.Text == "Select An Item")
            {
                MessageBox.Show("Items Must Be Selected");
            }
            else if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                MessageBox.Show("Quantity Can't Be Empty");

            }

            else
            {
                 
                AddInfo(contactNoTextBox.Text, Convert.ToInt32(quantityTextBox.Text), orderItemComboBox.Text);


            }

            coustomerNameTextBox.Text = " ";
            contactNoTextBox.Text = " ";
            addressTextBox.Text = " ";
            orderItemComboBox.Text = "Select An Item";
            quantityTextBox.Text = " ";
             


        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showCutomerInfo();

        }
        private void showCutomerInfo()
        {
            string see = " ";
            for (int i = 0; i < Customernames.Count(); i++)
            {
                see += "\nName: " + Customernames[i] + "\n";
                see += "Number: " + ContactNumbers[i] + "\n";
                see += "Address: " + addresses[i] + "\n";
                see += "Order: " + OderItem[i] + "\n";
                see += "Quantity: " + quantities[i] + "\n";
                see += "Total Price: " + totalPrices[i] + "\n";
            }
            showInformationRichTextBox.AppendText(see);

        }
        private void AddInfo(string cNumber, int quantity, string item)
        {
             
            Customernames.Add(coustomerNameTextBox.Text);
           ContactNumbers.Add(cNumber);
            addresses.Add(addressTextBox.Text);
             OderItem.Add(item);
            quantities.Add(quantity);

            if (item == "Black")
            {
                totalPrices.Add(quantity * 120);
            }
            else if (item == "Cold")
            {

                totalPrices.Add(quantity * 100);
            }
            else if (item == "Hot")
            {
                totalPrices.Add(quantity * 90);

            }
            else if (item == "Regular")
            {
                totalPrices.Add(quantity * 80);

            }
            string seeInfo = " ";

            for (int i = 0; i < Customernames.Count(); i++)
            {
                seeInfo += "\nName: " + Customernames[i] + "\n";
                seeInfo += "Number: " + ContactNumbers[i] + "\n";
                seeInfo += "Address: " + addresses[i] + "\n";
                seeInfo += "Order: " + OderItem[i] + "\n";
                seeInfo += "Quantity: " + quantities[i] + "\n";
                seeInfo += "Total Price: " + totalPrices[i] + "\n";

            }
            showInformationRichTextBox.AppendText(seeInfo);
           

        }
    }
}
