using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTransportationService.Abstraction.Interfaces;
using CarTransportationService.Data.Car_Details;
using CarTransportationService.Data.DataBase;
using CarTransportationService.Data.Services;

namespace CarTransportationService.Abstraction.Implementation
{
    internal class CarRepository : IDataBaseRepository<Car>
    {
        public void Add(Car entity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Car (Year, Mark, Model, VehicleType) VALUES (@Year, @Mark, @Model, @VehicleType)";
                        command.Parameters.AddWithValue("@Year", entity.Year);
                        command.Parameters.AddWithValue("@Mark", entity.Mark);
                        command.Parameters.AddWithValue("@Model", entity.Model);
                        command.Parameters.AddWithValue("@VehicleType", entity.VehicleType.ToString());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error adding car: " + ex.Message);
            }
        }

        public List<Car> GetAll()
        {
            List<Car> cars = new List<Car>();

            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Car", connection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car car = new Car(
                                id: int.Parse(reader["Id"].ToString()),
                                year: int.Parse(reader["Year"].ToString()),
                                mark: reader["Mark"].ToString(),
                                model: reader["Model"].ToString(),
                                vehicleType: reader["VehicleType"].ToString().ConvertToVehicleType()
                            );
                            cars.Add(car);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error retrieving cars: " + ex.Message);
            }

            return cars;
        }

        public Car GetItem(int id)
        {
            Car car = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("SELECT * FROM Car WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                car = new Car
                                {
                                    Id = id,
                                    Year = int.Parse(reader["Year"].ToString()),
                                    Mark = reader["Mark"].ToString(),
                                    Model = reader["Model"].ToString(),
                                    VehicleType = reader["VehicleType"].ToString().ConvertToVehicleType()
                                };
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error retrieving car with Id " + id + ": " + ex.Message);
            }

            return car;
        }

        public void Remove(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand("DELETE FROM Car WHERE Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error removing car with Id " + id + ": " + ex.Message);
            }
        }

        public void Update(int id, Car newEntity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = @"UPDATE Car 
                                            SET Year = @Year, 
                                                Mark = @Mark, 
                                                Model = @Model, 
                                                VehicleType = @VehicleType 
                                            WHERE Id = @Id";

                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Year", newEntity.Year);
                        command.Parameters.AddWithValue("@Mark", newEntity.Mark);
                        command.Parameters.AddWithValue("@Model", newEntity.Model);
                        command.Parameters.AddWithValue("@VehicleType", newEntity.VehicleType.ToString());

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error updating car with Id " + id + ": " + ex.Message);
            }
        }
    }
}