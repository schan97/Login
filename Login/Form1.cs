﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtUsername_Enter(object sender, EventArgs e)
		{
			if(txtUsername.Text.Equals(@"Username / Email"))
			{
				txtUsername.Text = "";
			}

		}

		private void txtUsername_Leave(object sender, EventArgs e)
		{
			if (txtUsername.Text.Equals(""))
			{
				txtUsername.Text = @"Username / Email";
			}

		}

		private void txtPassword_Enter(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals("Password"))
			{
				txtPassword.Text = "";
			}
		}

		private void txtPassword_Leave(object sender, EventArgs e)
		{
			if (txtPassword.Text.Equals(""))
			{
				txtPassword.Text = "Password";
			}
		}
	}
}
