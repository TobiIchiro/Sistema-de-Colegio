using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public class LoginMethods
{
    public void textBoxUsuerClick(TextBox textBoxUser)
    {
        textBoxUser.Text = string.Empty;
        textBoxUser.Focus();
    }
    public void textBoxPasswordClick(TextBox textBoxPassword)
    {
        textBoxPassword.Text = string.Empty;
        textBoxPassword.Focus();
    }
}
