using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using kursvaya.appForm;
using kursvaya.service;

namespace kursvaya
{
    public partial class mainForm : Form
    {
        public dbService dataBase = new dbService();
        DataSet ds = new DataSet();
        string globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id";
        public mainForm()
        {
            InitializeComponent();
        }

        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=InsuranceServiceDB.mdb";

        private void mainForm_Load(object sender, EventArgs e)
        {
            fillDA();
            dataGridView1.DataSource = ds.Tables["Insurance"].DefaultView;
        }

        private void fillDA()
        {
            ds.Clear();
            string CommandText;
            CommandText = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "Insurance");
        }

        private void addRecordButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void executeQuery(string CommandText)
        {
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            conn.Open();
            OleDbCommand myCommand = conn.CreateCommand();
            myCommand.CommandText = CommandText;
            myCommand.ExecuteNonQuery();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ClientForm();
            form.ShowDialog(this);
        }

        private void автомобилиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new CarForm();
            form.ShowDialog(this);
        }

        private void удалитьВыбраннуюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;
            int IDclient, IDcar;
            string CommandText;
            index = int.Parse(dataGridView1.CurrentRow.Cells["id"].Value.ToString());
            CommandText = string.Format("SELECT idClient, idCar FROM Insurance WHERE id = {0}", index);
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet dss = new DataSet();
            dataAdapter.Fill(dss);
            IDclient = int.Parse(dss.Tables[0].Rows[0][0].ToString());
            IDcar = int.Parse(dss.Tables[0].Rows[0][1].ToString());
            CommandText = string.Format("DELETE FROM Client WHERE Client.id = {0}", IDclient);
            executeQuery(CommandText);
            CommandText = string.Format("DELETE FROM Car WHERE Car.id = {0}", IDcar);
            executeQuery(CommandText);
            CommandText = string.Format("DELETE FROM Insurance WHERE Insurance.id = {0}", index.ToString());
            executeQuery(CommandText);
            //label3.Text = index.ToString() + " " + IDclient + " " + IDcar;
            fillDA();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var temp = new recordForm();
            temp.ShowDialog(this);
            record Record = (temp.getRecord());
            if (Record != null && Record.Car != null && Record.Car.Owner != null)
            {
                dataBase.addRecordToDB(Record);
            }
            temp.Close();
            fillDA();
            var form = new certificateForm(Record);
            form.ShowDialog(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void имяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Client.firstname = '{0}'";
        }

        private void номерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Car.number = '{0}'";
        }

        private void номерToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Insurance.id = {0}";
        }

        private void модельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Car.model = '{0}'";
        }

        private void фамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Client.surname = '{0}'";
        }

        private void отчествоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Client.midname = '{0}'";
        }

        private void возрастToolStripMenuItem_Click(object sender, EventArgs e)
        {
            globalQuery = "SELECT Insurance.id, Insurance.price, Insurance.recordDate, Client.firstname, Client.surname, Client.age, Car.model, Car.number FROM(Insurance INNER JOIN Client ON Insurance.idClient = Client.id) INNER JOIN Car ON Insurance.idCar = Car.id Where Client.age = {0}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = string.Format(globalQuery, textBox1.Text);
            ds.Clear();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, ConnectionString);
            dataAdapter.Fill(ds, "Insurance");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fillDA();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"Help\Help.chm");
        }
    }
}