using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Data;

public class MainConnection
{
    public SqlConnection connection = new SqlConnection("Data Source = DESKTOP-6BN4AHD\\SQLEXPRESS01;" +
                                                        "Initial Catalog = DBUser;" +
                                                        "Integrated Security = True");
    public void open()
    {
        if (connection.State.Equals(ConnectionState.Closed))
            connection.Open();
    }
    public void close()
    {
        if (connection.State.Equals(ConnectionState.Open))
            connection.Close();
    }

}
