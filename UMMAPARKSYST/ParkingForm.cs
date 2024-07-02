using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMMAPARKSYST
{
    public partial class ParkingForm : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public ParkingForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();
            this.Hide();
        }
        public void Reset()
        {
            txtLocation.Text = "";
            txtSlotno.Text = "";
            labelId.Text = "";

        }
        public void load()
        {
            var lod = db.tblSlots.ToList();
            dataGridView1.DataSource = lod;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSlotno.Text != null & txtLocation.Text != null)
                {
                    //insert
                    tblSlot s = new tblSlot();
                    s.Slot_No = txtSlotno.Text;
                    s.Location = txtLocation.Text;
                    db.tblSlots.InsertOnSubmit(s);
                    db.SubmitChanges();
                    MessageBox.Show("Data Inserted");
                    Reset();
                }
                else
                {
                    MessageBox.Show("SLot number or location box emepty..try again...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void ParkingForm_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
