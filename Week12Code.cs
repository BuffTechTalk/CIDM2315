// dotnet command use to install MySql.Data package:
dotnet add package MySql.Data

// SQL scirpts used to generate User table and insert records to it
create table User (
    username VARCHAR(50),
    password VARCHAR(50),
    role VARCHAR(50)
);
insert into User (username, password, role) values ('cwoolward0', 'y1XJu9bKgoP', 'Business Development');
insert into User (username, password, role) values ('dmacclay1', 'ih6Pg9k', 'Business Development');
insert into User (username, password, role) values ('icockren2', '75cZn2T3tNt7', 'Human Resources');
insert into User (username, password, role) values ('cwhartonby3', 'zD9B4BlCCuUU', 'Research and Development');
insert into User (username, password, role) values ('nbrien4', 'HPEbpMo3Z', 'Legal');
insert into User (username, password, role) values ('acoutthart5', '9waoemzJXlh5', 'Accounting');
insert into User (username, password, role) values ('pmarkham6', 'UgY5qzNR35Q', 'Legal');
insert into User (username, password, role) values ('ijonson7', 'da9ButUNb', 'Marketing');
insert into User (username, password, role) values ('sscotchforth8', 'HoFdP7Y2U01k', 'Product Management');
insert into User (username, password, role) values ('sjosefson9', '6I2jO8Z', 'Engineering');
insert into User (username, password, role) values ('dswantona', 'lln29r66Qa', 'Human Resources');
insert into User (username, password, role) values ('ecallabyb', 'HkWgJg8', 'Support');
insert into User (username, password, role) values ('ckinkerc', 'ZzO6Lo', 'Marketing');
insert into User (username, password, role) values ('ihalleyd', '5rzGoc7', 'Human Resources');
insert into User (username, password, role) values ('cmasseye', 'lCQPVLotxkx', 'Services');
insert into User (username, password, role) values ('fyeldonf', '2geuebY5s', 'Training');
insert into User (username, password, role) values ('bpaslowg', 'BpbENQ5', 'Human Resources');
insert into User (username, password, role) values ('eiddiensh', 'FO4eoHh', 'Support');
insert into User (username, password, role) values ('zgetcliffi', '67KLtXGmAD', 'Services');
insert into User (username, password, role) values ('oiwanickij', 'lN12wDHN', 'Training');
insert into User (username, password, role) values ('jinglesantk', '3Lfv2ipxr', 'Legal');
insert into User (username, password, role) values ('kbridgenl', 'SJfqnJ', 'Engineering');
insert into User (username, password, role) values ('ageraldinim', 'FMq50mdOnrQY', 'Training');
insert into User (username, password, role) values ('astuttmann', 'OVwUCRXUe', 'Services');


// Example 1: Connect Remote Database in C# - Find all users whose roles are Engineering

namespace Week12;
// import MySQL package for connecting remote database
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connStr = "server=20.172.0.16;user=YOUR_USERNAME;database=YOUR_DATABASE;port=8080;password=YOUR_PASSWORD";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            // Find all users whose roles are Engineering;
            // We put SQL Comman in "", the string value in SQL is in ''
            string sql = "SELECT username, password, role FROM User WHERE role='Engineering'";
            // the SQL query to be executed is passed to the MySqlCommand
            MySqlCommand cmd = new MySqlCommand(sql, conn);
           
            // ExecuteReader to query the database.
            // The MySqlReader object contains the results generated by the SQL executed on the MySqlCommand object.
            MySqlDataReader rdr = cmd.ExecuteReader();

            // the information stored in MySqlReader is printed out by a while loop
            while (rdr.Read())
            {
                Console.WriteLine($"Username: {rdr[0]} -- Password: {rdr[1]} -- Role: {rdr[2]}");
            }
            // MySqlReader object is disposed of by invoking the Close method
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}


// Example 2: Working SQL with Parameter - Find all users match input role

namespace Week12;
using MySql.Data;
using System.Data;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connStr = "server=20.172.0.16;user=YOUR_USERNAME;database=YOUR_DATABASE;port=8080;password=YOUR_PASSWORD";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
           
            // The parameter is preceded by an '@' symbol to indicate it is to be treated as a parameter.
            string sql = "SELECT username, role FROM User WHERE role= @role";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
           
            // get a role value from keyboard
            Console.WriteLine("Enter a role e.g.:Engineering, Support, Services, Training");
            string user_input = Console.ReadLine();
            // assign input value to the SQL command
            cmd.Parameters.AddWithValue("@role", user_input);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {   // select columon based on column name
                Console.WriteLine($"Username: {rdr["username"]} -- Role: {rdr["role"]}");
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}

//Example 3: Insert/Update/Delete Records - Insert a new student record to User table 
namespace Week12;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class Program
{
    static void Main(string[] args)
    {
        string connStr = "server=20.172.0.16;user=YOUR_USERNAME;database=YOUR_DATABASE;port=8080;password=YOUR_PASSWORD";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
           
            string sql = "INSERT INTO User VALUES (@username, @password, @role)";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            // input information for new record
            Console.WriteLine("Enter Username:");
            string input_username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string input_password = Console.ReadLine();
            Console.WriteLine("Enter Role:");
            string input_role = Console.ReadLine();
            // assign input values to the SQL command
            cmd.Parameters.AddWithValue("@username", input_username);
            cmd.Parameters.AddWithValue("@password", input_password);
            cmd.Parameters.AddWithValue("@role", input_role );
           
            // ExecuteNonQuery to insert, update, and delete data.
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
    }
}



// Example 4: Create Login Application with Database

namespace Week12;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
class Program
{
   static void Main(string[] args)
   {
        string connStr = "server=20.172.0.16;user=YOUR_USERNAME;database=YOUR_DATABASE;port=8080;password=YOUR_PASSWORD";
       MySqlConnection conn = new MySqlConnection(connStr);
       try
       {
           Console.WriteLine("Connecting to MySQL...");
           conn.Open();
            // input information for new record
           Console.WriteLine("Enter Username:");
           string input_username = Console.ReadLine();
           Console.WriteLine("Enter Password:");
           string input_password = Console.ReadLine();
           // sql: count how many records match inputUsername and inputPassword
           // save the counted number into variable countUser
           string sql = @"SELECT COUNT(*) AS countUser FROM User
                   WHERE
                   User.username = @inputUsername
                   AND
                   User.password = @inputPassword;";
           MySqlCommand cmd = new MySqlCommand(sql, conn);
           cmd.Parameters.AddWithValue("@inputUsername", input_username);
           cmd.Parameters.AddWithValue("@inputPassword", input_password);
           MySqlDataReader rdr = cmd.ExecuteReader();
           while (rdr.Read())
           {   // if countUser equals to 1, means can find input values in table
               if(rdr["countUser"].ToString() == "1"){
                   Console.WriteLine("Login Successfully!");
               }
               else{
                   Console.WriteLine("Login Failed!");
               }
           }

           rdr.Close();
           // convert returned value to int datatype
       }

       catch (Exception ex)
       {
           Console.WriteLine(ex.ToString());
       }

       conn.Close();
       Console.WriteLine("Done.");
   }
}



