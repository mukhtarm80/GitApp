using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Phone> phones = new List<Phone>
            {
                new Phone { Id = 11, Name = "Samsung Galaxy Ace 2", Year = 2012},
                new Phone { Id = 12, Name = "Samsung Galaxy S4", Year = 2013},
                new Phone { Id = 13, Name = "iPhone 6", Year = 2014},
                new Phone { Id = 14, Name = "Microsoft Lumia 435", Year = 2015},
                new Phone { Id = 15, Name = "Xiaomi Mi 5", Year = 2015}
            };
            listBox1.DataSource = phones;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;

        }
        void listBox1_SelectedIndexChanged(object sender,EventArgs e) 
        {
            int id = (int)listBox1.SelectedValue;

            Phone phone = (Phone)listBox1.SelectedItem;
            MessageBox.Show(id.ToString() + ". " + phone.Name);
        }
    }
    class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

    }
}
