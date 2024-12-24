using MySqlConnector;
using System;

class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Server=localhost;Database=db_restaurante;User=root;Password= ;";

        try
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open(); // Tenta abrir a conexão

                Console.WriteLine("Conexão bem-sucedida ao banco de dados!");

                // Exemplo de comando SQL para testar
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM reservas;", connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar()); // Executa a consulta e pega o valor retornado
                Console.WriteLine($"Total de reservas: {count}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
        }
    }
}
