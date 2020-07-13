using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace kursvaya.service
{
    public class dbService
    {
        public string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=InsuranceServiceDB.mdb";
        public void addRecordToDB(record record)
        {
            car car = record.Car;
            person person = car.Owner;
            string personQuery = string.Format("INSERT INTO [Client]([firstname], [surname], [midname], [age], [drivingExperience]) VALUES ('{0}','{1}','{2}','{3}',{4})", person.Name, person.Surname, person.MiddleName, person.Age, person.DrivingExperience);
            executeQuery(personQuery);
            string CommandText = "SELECT Max(Client.id) from Client";
            DataSet ds = new DataSet();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds);
            int personId = int.Parse((((DataRow)(ds.Tables[0].Select().GetValue(0))).ItemArray[0].ToString()));
            string carQuery = string.Format("INSERT INTO [Car]([model], [number], [price], [idClient]) VALUES ('{0}','{1}','{2}',{3})", car.Model, car.Number, car.Price, personId.ToString());
            executeQuery(carQuery);
            CommandText = "SELECT Max(Car.id) from Car";
            dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            ds.Clear();
            dataAdapter.Fill(ds);
            int carId = int.Parse((((DataRow)(ds.Tables[0].Select().GetValue(0))).ItemArray[0].ToString()));
            string recordQuery = string.Format("INSERT INTO [Insurance]([price], [recordDate],[idClient],[idCar]) VALUES ('{0}','{1}',{2}, {3})", record.InsurancePrice, record.Date.ToShortDateString(), personId.ToString(), carId.ToString());

            executeQuery(recordQuery);
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
    }
}