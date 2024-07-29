using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todolist.VIEW;


namespace todolist
{
    public partial class Fmain : Form
    {
        
        public Fmain()
        {
            InitializeComponent();
   

        }
        
       


        private void pic19_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void pic18_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            priority pri = new priority();
            pri.ShowDialog();
            pri = null;
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyPlan plan = new MyPlan();
            plan.ShowDialog();
            plan = null;
            this.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dtp2.Value.ToString("hh:mm tt");
            string title = txt1.Text.ToString();
            string description = txt2.Text.ToString();
            string priority = GetSelectetdPrioity();

            ListViewItem existingItem = FindItemByTitle(title);
            if(existingItem !=null)
            {
                existingItem.SubItems[0].Text = time;
                existingItem.SubItems[1].Text = title;
                existingItem.SubItems[2].Text = description;
                existingItem.SubItems[3].Text = priority;
            }
            else
            {

                int nextNumber = lvw4.Items.Count + 1;
                ListViewItem newItem = new ListViewItem(nextNumber.ToString());
                newItem.SubItems.Add(time);
                newItem.SubItems.Add(title);
                newItem.SubItems.Add(description);
                newItem.SubItems.Add(priority);
                lvw4.Items.Add(newItem);
                clearInputFields();
               
            }
        }
        private string GetSelectetdPrioity()
        {
            if (rdo1.Checked)
                return "I";
            else if (rdo2.Checked)
                return "II";
            else if (rdo3.Checked)
                return "III";
            else if(rdo4.Checked)
                return "IV";
            else
                return string.Empty;
        }

        private ListViewItem FindItemByTitle(string title)
        {
            foreach(ListViewItem item in lvw4.Items)
            {
                if (item.SubItems[1].Text == title) return item;
            }
            return null;
        }

        private void clearInputFields()
        {
            txt1.Clear();
            txt2.Clear();
            dtp2.Value = DateTime.Now;

            rdo1.Checked = false;
            rdo2.Checked = false;
            rdo3.Checked = false;
            rdo4.Checked = false;
        }
    }

}
