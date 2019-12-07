using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsAppBluetooth
{
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-7878PVB\SQLEXPRESS;Initial Catalog=User;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            panelLogin.Show();
            panelSignup.Hide();
            panelAfterSignin.Hide();
            panelSearch.Hide();
            panelIncomming.Hide();
            panelMessage.Hide();
            panelLogin.Location = new Point(10, 10);
            panelLogin.Size = new Size(518, 437);
            panelSignup.Location = new Point(10, 10);
            panelSignup.Size = new Size(518, 437);
            panelAfterSignin.Location = new Point(10, 10);
            panelAfterSignin.Size = new Size(518, 437);
            panelSearch.Location = new Point(40,20);
            panelSearch.Size = new Size(380, 305);
            panelIncomming.Location = new Point(40, 20);
            panelIncomming.Size = new Size(380, 305);
            panelMessage.Location = new Point(10, 10);
            panelMessage.Size = new Size(518, 437);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)  //panel Login
        {
            panelSignup.Hide();
            panelAfterSignin.Hide();
            panelSearch.Hide();
            panelMessage.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonSignup_Click_1(object sender, EventArgs e)
        {
            panelSignup.Show();
        }

        private void buttonSignup_Click_2(object sender, EventArgs e)
        {
            panelSignup.Show();
        }

        private void labelSignUpTittle_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelSignup.Hide();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e) // create Account
        {
            try
            {
                con.Open();
                if(con.State==System.Data.ConnectionState.Open)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("insert into Form(Name,Username,Password)values('"+ textBoxSignupName.Text+ "','"  + textBoxSignupUsername.Text + "','" + textBoxSignupPassword.Text + "')", con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Account Created");
                }

            }
            catch
            {
                MessageBox.Show("Username already taken");
            }
            textBoxSignupName.Text = string.Empty;
            textBoxSignupUsername.Text = string.Empty;
            textBoxSignupPassword.Text = string.Empty;
        }

        private void buttonSignin_Click(object sender, EventArgs e) //button
        {
            if (textBoxSigninUsername.Text == "" && textBoxSigninPassword.Text == "")
            {
                MessageBox.Show("Invalid Input");

            }
            else
            {


                try
                {

                    SqlCommand sql = new SqlCommand("select * from Form where Username= @username and Password= @pass", con);
                    sql.Parameters.AddWithValue("@username", textBoxSigninUsername.Text);
                    sql.Parameters.AddWithValue("@pass", textBoxSigninPassword.Text);
                    con.Open();
                    SqlDataAdapter adpt = new SqlDataAdapter(sql);
                    DataSet ds = new DataSet();
                    adpt.Fill(ds);
                    con.Close();
                    int count = ds.Tables[0].Rows.Count;
                    if (count == 1)
                    {
                        panelAfterSignin.Show();
                    }
                    else
                    {
                        MessageBox.Show("Inavlid Input");
                    }

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.ToString());
                }
                textBoxSigninUsername.Text = string.Empty;
                textBoxSigninPassword.Text = string.Empty;
            }
        }
        

        private void buttonAvailable_Click(object sender, EventArgs e)
        {
            panelSearch.Show();
            panelIncomming.Hide();
        }

        private void panelAfterSignin_Paint(object sender, PaintEventArgs e) //Panel After Sign in
        {
            panelMessage.Hide();
        }

        private void panelIncomming_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelIncomming.Show();
            panelSearch.Hide();
        }

        private void buttonConnectIncomming_Click(object sender, EventArgs e)
        {
            panelMessage.Show();
            panelAfterSignin.Hide();
        }

        private void buttonConnectAvailable_Click(object sender, EventArgs e)
        {
            panelMessage.Show();
            panelAfterSignin.Hide();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            panelLogin.Show();
            panelMessage.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSignupName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panelSignup_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
