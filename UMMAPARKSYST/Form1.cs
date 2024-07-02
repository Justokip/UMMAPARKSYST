using System.Data.SqlClient;
namespace UMMAPARKSYST
{
    public partial class Form1 : Form
    {
        DataClasses2DataContext db = new DataClasses2DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text != null & txtEmail.Text != null)
                {
                    var item = db.tblAccounts.where(text => text.email == txtEmail & text.password == txtPassword.Text).FirstOrDefault();
                    if (item != null)
                    {
                        WelcomeForm welcomeForm = new WelcomeForm();
                        this.Hide();
                        welcomeForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Account information does not exit.. First create an aaccount");
                    }
                }
               
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error");
            }


          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
