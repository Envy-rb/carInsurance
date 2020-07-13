using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kursvaya.appForm
{
    public partial class ClientForm : Form
    {
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=InsuranceServiceDB.mdb";
        DataSet ds = new DataSet();

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            fillDA();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void fillDA()
        {
            ds.Clear();
            string CommandText;
            CommandText = "SELECT Client.firstname, Client.surname, Client.midname, Client.age, Client.drivingExperience FROM Client";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "Client");
        }
    }
}
