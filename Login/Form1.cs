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

namespace Login
{
	public partial class LoginForm : Form
	{
		SqlConnection con = new SqlConnection();
		SqlCommand com = new SqlCommand();
		public LoginForm()
		{
			InitializeComponent();
			con.ConnectionString = @"Data Source = (LocalDB)\LocalDBDemo; Initial Catalog = LoginDemo; Integrated Security = True";
		}

		private void txtUsername_Enter(object sender, EventArgs e)
		{
			if(txtUsername.Text.Equals(@"Username / Email"))
				txtUsername.Text = "";
		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text.Equals(""))
				txtUsername.Text = @"Username / Email";
		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals("Password"))
				txtPassword.Text = "";
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals(""))
				txtPassword.Text = "Password";
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			con.Open();
			com.Connection = con;
			com.CommandText = "SELECT * FROM AUTH";
			SqlDataReader dr = com.ExecuteReader();
			if(dr.Read())
			{
				if (txtUsername.Text.Equals(dr["username"].ToString()) && txtPassword.Text.Equals(dr["password"].ToString()))
					MessageBox.Show("Login Successful", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

				else
					MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			con.Close();
		}
	}
}
