
namespace backend;

using MySql.Data.MySqlClient;

class DBConnect
{
    string conn_string = @"Server=tcp:laakentertainment.database.windows.net,1433;Initial Catalog=LaakEntertainment;Persist Security Info=False;User ID=AdminLaak;Password=LaakEntertainment1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=2;";
    public void open_connection()
    {
      MySqlConnection conn = new MySqlConnection(conn_string);
      try
      {
        conn.Open();
      }
      catch(MySqlException err)
      {
        Console.WriteLine($"possible error -> {err}");
      }
      finally{ conn.Close(); }
    }
}