using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using VideoClub.Models;

namespace VideoClub.Data
{
    public class DALPeliculas
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VideoClubDB;Integrated Security=True; TrustServerCertificate=true";

        public List<Pelicula> GetPeliculas()
        {
            var peliculas = new List<Pelicula>();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Peliculas", connection);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pelicula = new Pelicula
                        {
                            ID = reader.GetInt32(0),
                            Titulo = reader.GetString(1),
                            Director = reader.GetString(2),
                            Genero = reader.GetString(3),
                            FechaLanzamiento = reader.GetDateTime(4),
                            Disponible = reader.GetBoolean(5)
                        };

                        peliculas.Add(pelicula);
                    }
                }
            }

            return peliculas;
        }

        public Pelicula GetPelicula(int id)
        {
            var pelicula = new Pelicula();

            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM Peliculas WHERE ID = @id", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pelicula.ID = reader.GetInt32(0);
                        pelicula.Titulo = reader.GetString(1);
                        pelicula.Director = reader.GetString(2);
                        pelicula.Genero = reader.GetString(3);
                        pelicula.FechaLanzamiento = reader.GetDateTime(4);
                        pelicula.Disponible = reader.GetBoolean(5);
                    }
                }
            }

            return pelicula;
        }

        public void InsertPelicula(Pelicula pelicula)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO Peliculas (Titulo, Director, Genero, FechaLanzamiento, Disponible) VALUES (@titulo, @director, @genero, @fechaLanzamiento, @disponible)", connection);
                command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = pelicula.Titulo;
                command.Parameters.Add("@director", SqlDbType.VarChar).Value = pelicula.Director;
                command.Parameters.Add("@genero", SqlDbType.VarChar).Value = pelicula.Genero;
                command.Parameters.Add("@fechaLanzamiento", SqlDbType.Date).Value = pelicula.FechaLanzamiento;
                command.Parameters.Add("@disponible", SqlDbType.Bit).Value = pelicula.Disponible;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdatePelicula(int id, Pelicula pelicula)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("UPDATE Peliculas SET Titulo = @titulo, Director = @director, Genero = @genero, FechaLanzamiento = @fechaLanzamiento, Disponible = @disponible WHERE ID = @id", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.Parameters.Add("@titulo", SqlDbType.VarChar).Value = pelicula.Titulo;
                command.Parameters.Add("@director", SqlDbType.VarChar).Value = pelicula.Director;
                command.Parameters.Add("@genero", SqlDbType.VarChar).Value = pelicula.Genero;
                command.Parameters.Add("@fechaLanzamiento", SqlDbType.Date).Value = pelicula.FechaLanzamiento;
                command.Parameters.Add("@disponible", SqlDbType.Bit).Value = pelicula.Disponible;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeletePelicula(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DELETE FROM Peliculas WHERE ID = @id", connection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }



    }
}
