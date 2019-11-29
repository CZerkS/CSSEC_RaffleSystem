using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

public class DatabaseConnect
{
    private MySqlConnection connection;
    private string server, database, userId, password, strConnection;

    public DatabaseConnect()
    {
        Initialize();
    }

    public void Initialize()
    {
        server = "localhost";
        database = "test";
        userId = "root";
        password = "";

        strConnection = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + userId + ";PASSWORD=" + password + ";";

        connection = new MySqlConnection(strConnection);
    }

    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }
        catch (MySqlException e)
        {
            switch (e.Number)
            {
                case 0:
                    MessageBox.Show("Cannot connect to server. Contact: Dwight-09474836516");
                    break;
                case 1045:
                    MessageBox.Show("Invalid username/password, Please try again");
                    break;
            }
            return false;
        }
    }

    private bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }
        catch (MySqlException e)
        {
            MessageBox.Show(e.Message);
            return false;
        }
    }

    List<List<string>> attendanceTableData;
    public List<List<string>> AdduAttendanceData(string adduTable)
    {
        //Temporary will change the table name into variable for flexibility
        attendanceTableData = new List<List<string>>();
        List<string> row;
        
        if (this.OpenConnection() == true)
        {
            //for addu participants
            string query = "SELECT StudentID, Firstname, Lastname FROM test." + adduTable;
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                row = new List<string>() {
                    dataReader["StudentID"].ToString(), dataReader["Firstname"].ToString(),
                    dataReader["Lastname"].ToString()
                };
                attendanceTableData.Add(row);
            }

            dataReader.Close();
            this.CloseConnection();

            return attendanceTableData;
        }
        else
        {
            return attendanceTableData;
        }
    }

    public bool HasAdduPopulation(string adduTable)
    {
        string query = "SELECT StudentID, Firstname, Lastname FROM test." + adduTable;
        if (this.OpenConnection() == true)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                return true;
            }

            dataReader.Close();
            this.CloseConnection();

        }
        else
        {
            MessageBox.Show("No Connection available", "NO CONNECTION");
        }
        return false;
    }

    List<List<string>> guestAttendanceTable;
    public List<List<string>> GuestAttendanceData(string guestTable)
    {
        guestAttendanceTable = new List<List<string>>();
        List<string> row;

        if (this.OpenConnection() == true)
        {
            //for guest participants
            string query = "SELECT guests.guestcode, lastname, firstname, school, timein FROM " + guestTable + " LEFT JOIN guests ON " + guestTable + ".guestcode = guests.guestcode ORDER BY timein";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                row = new List<string>() {
                    dataReader["guestcode"].ToString(), dataReader["firstname"].ToString(),
                    dataReader["lastname"].ToString()
                };
                guestAttendanceTable.Add(row);
            }

            dataReader.Close();
            this.CloseConnection();

            return guestAttendanceTable;
        }
        else
        {
            return guestAttendanceTable;
        }
    }

    public bool HasGuestPopulation(string guestTable)
    {
        string query = "SELECT guests.guestcode, lastname, firstname, school, timein FROM " + guestTable + " LEFT JOIN guests ON " + guestTable + ".guestcode = guests.guestcode ORDER BY timein";
        if (this.OpenConnection() == true)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                return true;
            }

            dataReader.Close();
            this.CloseConnection();
        }
        else
        {
            MessageBox.Show("No Connection available", "NO CONNECTION");
        }
        return false;
    }

    public List<List<string>> EventData()
    {
        List<List<string>> eventTableData = new List<List<string>>();
        List<string> row;

        string query = "SELECT * FROM test.event;";

        if(this.OpenConnection() == true)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                row = new List<string>() {
                    dataReader["eventid"].ToString(), dataReader["name"].ToString(),
                    dataReader["description"].ToString(), dataReader["date"].ToString(),
                    dataReader["tablename"].ToString(), dataReader["guestTablename"].ToString()
                };
                eventTableData.Add(row);
            }
            dataReader.Close();
            this.CloseConnection();

            return eventTableData;
        }
        else
        {
            return eventTableData;
        }
    }
}
