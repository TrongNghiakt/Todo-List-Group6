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
using todolist.VIEW.UC;


namespace todolist
{
    public partial class Fmain : Form
    {
        
        public string Textboxvalue { get; set; }

        public Fmain()
        {
            InitializeComponent();
            today today = new today();
            AddUc(today);
            
        }
 
        
        public void AddUc(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            panel_mn.Controls.Clear();
            panel_mn.Controls.Add(uc);
            uc.BringToFront();
        }


  
        private void pic18_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      

        private void btnToday_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(btnToday.Location.X, btnToday.Location.Y);
            today today = new today();
            AddUc(today);
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(btnPriority.Location.X, btnPriority.Location.Y);
            priority priority = new priority();
            AddUc(priority);
        }

        private void btnMyPlan_Click(object sender, EventArgs e)
        {
            this.menupanelaccess.Location = new Point(btnMyPlan.Location.X, btnMyPlan.Location.Y);
            myPlan myPlan = new myPlan();
            AddUc(myPlan);
        }

        private void btnRemind_Click(object sender, EventArgs e)
        {

        }
    }

}
