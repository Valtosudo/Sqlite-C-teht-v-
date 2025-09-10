namespace Sqlite_C_teht_v_;

using Microsoft.Data.Sqlite;

public class Taulut
{
    private string _connectionString = "Data Source = Lemmikki.db";

    public Taulut()
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"CREATE TABLE IF NOT EXISTS Henkilot (id INTEGER PRIMARY KEY, Nimi TEXT, Puhelin INTEGER);";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS Lemmikit (id INTEGER PRIMARY KEY, Nimi TEXT, Rotu TEXT, OmistajaID INTEGER;";
            command.ExecuteNonQuery();
        }
    }

    public void LisaaHenkilo(string nimi, int puhelin)
    {
        using (var connection = new SqliteConnection(_connectionString))
        {
            connection.Open();
            var commandForCheck = connection.CreateCommand();
            commandForCheck.CommandText = @"SELECT id FROM Henkilot WHERE Nimi = $nimi AND Puhelin = $puhelin;";
            commandForCheck.Parameters.AddWithValue("$nimi", nimi);
            commandForCheck.Parameters.AddWithValue("$puhelin", puhelin);
            object? id = commandForCheck.ExecuteScalar();
        }
    }

    public void LisaaLemmikki(string nimi, string rotu, int omistajaID)
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Lemmikit (Nimi, Rotu, OmistajaID) VALUES ($nimi, $rotu, $omistajaID);";
        command.Parameters.AddWithValue("$nimi", nimi);
        command.Parameters.AddWithValue("$rotu", rotu);
        command.Parameters.AddWithValue("$omistajaID", omistajaID);
        command.ExecuteNonQuery();
    }

}