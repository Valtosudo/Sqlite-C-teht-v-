namespace Sqlite_C_teht_v_;

using Microsoft.Data.Sqlite;

public class Taulut
{
    private string _connectionString = "Data Source = HenkilotJaLemmikit.db";

    public Taulut()
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"CREATE TABLE IF NOT EXISTS Henkilot (id INTEGER PRIMARY KEY, Nimi TEXT, Puhelin INTEGER);";
        command.ExecuteNonQuery();

        command.CommandText = @"CREATE TABLE IF NOT EXISTS Lemmikit (id INTEGER PRIMARY KEY, Nimi TEXT, Rotu TEXT, Omistaja_ID INTEGER, FOREIGN KEY(OmistajaID) REFERENCES Henkilot(id));";
        command.ExecuteNonQuery();
    }

}