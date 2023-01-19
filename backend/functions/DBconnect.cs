
namespace backend;

using MySql.Data.MySqlClient;

class DBConnect
{
    String conn_string = "Server=77.169.16.216:3306;Database=LaakEntertainment;user id=root;Password=LaakEntertainment1!";
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