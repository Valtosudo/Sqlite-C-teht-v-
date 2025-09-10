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

        command.CommandText = @"CREATE TABLE IF NOT EXISTS Lemmikit (id INTEGER PRIMARY KEY, Nimi TEXT, Rotu TEXT, OmistajaID INTEGER, FOREIGN KEY(OmistajaID) REFERENCES Henkilot(id));";
        command.ExecuteNonQuery();
    }

    public void LisaaHenkilo(string nimi, int puhelin)
    {
        var connection = new SqliteConnection(_connectionString);
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = @"INSERT INTO Henkilot (Nimi, Puhelin) VALUES ($nimi, $puhelin);";
        command.Parameters.AddWithValue("$nimi", nimi);
        command.Parameters.AddWithValue("$puhelin", puhelin);
        command.ExecuteNonQuery();
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