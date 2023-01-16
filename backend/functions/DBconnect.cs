


namespace backend;

using MySql.Data.MySqlClient;

class DBConnect
{
/*
    private MySqlConnection connection;

    //Constructor
    public DBConnect()
    {
        string connStr = "Server=77.169.16.216:3306/phpmyadmin;User=AdminLaak;Database=LaakEntertainment;Password=LaakTheater1!";
        string connectionStr = "server=";
        connection = new MySqlConnection(connStr);
        connection.Open();
    }

    public async void getData(){
        await connection.OpenAsync();

        using var command = new MySqlCommand("SELECT * FROM `test`;", connection);
        using var reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var value = reader.GetValue(0);
            Console.WriteLine(value);
        }
    }
    */
     String conn_string = "Server=77.169.16.216:3306/phpmyadmin;Database=LaakEntertainment;user id=root;Password=LaakTEntertainment1!";
    public void open_connection()
    {
      MySqlConnection conn = new MySqlConnection(conn_string);
      try
      {
        conn.Open();  // connection opened
      }
      catch(MySqlException err)
      {
        Console.WriteLine($"possible error -> {err}");
      }
      finally{ conn.Close(); } //closes the connection finally
    }
}