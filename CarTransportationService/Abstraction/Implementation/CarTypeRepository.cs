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
using CarTransportationService.Requesting_Information.Car_Details;

namespace CarTransportationService.Abstraction.Implementation
{
    //internal class CarTypeRepository : IDataBaseRepository<CarType>
    //{
    //        public void Add(CarType entity)
    //        {
    //            using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
    //            {
    //                connection.Open();
    //                using (SqlCommand command = new SqlCommand())
    //                {
    //                    command.Connection = connection;
    //                    command.CommandText = "Insert into CarType values(@VehicleType, @Coefficient)";
    //                    command.Parameters.Add(new SqlParameter("@VehicleType", entity.VehicleType.ToString()));
    //                    command.Parameters.Add(new SqlParameter("@Coefficient", entity.Coefficient));
    //                }
    //            }
    //        }
    //        public List<CarType> GetAll()
    //        {
    //            using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
    //            {
    //                connection.Open();
    //                List<CarType> cars = new List<CarType>();
    //                using (SqlCommand command = new SqlCommand())
    //                {
    //                    command.Connection = connection;
    //                    command.CommandText = "Select * From CarType";
    //                    using (SqlDataReader reader = command.ExecuteReader())
    //                    {
    //                        while (reader.Read())
    //                        {
    //                            CarType carType = new CarType(int.Parse(reader["Id"].ToString()), reader["VehicleType"].ToString().ConvertToVehicleType(), float.Parse(reader["Coefficient"].ToString()));
    //                            cars.Add(carType);
    //                        }
    //                    }
    //                }
    //                return cars;
    //            }
    //        }
    //        public Car GetItem(int id)
    //        {
    //            using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
    //            {
    //                connection.Open();
    //                Car car = new Car();
    //                using (SqlCommand command = new SqlCommand())
    //                {
    //                    command.Connection = connection;
    //                    command.CommandText = "Select * From Car where Id = @Id";
    //                    command.Parameters.Add(new SqlParameter("id", id));
    //                    using (SqlDataReader reader = command.ExecuteReader())
    //                    {
    //                        while (reader.Read())
    //                        {
    //                            car.Id = id;
    //                            car.Model = reader["Model"].ToString();
    //                            car.Mark = reader["Mark"].ToString();
    //                            car.Year = int.Parse(reader["Year"].ToString());
    //                            car.VehicleType = reader["VehicleType"].ToString().ConvertToVehicleType();
    //                        }
    //                    }
    //                }
    //                return car;
    //            }
    //        }
    //        public void Remove(int id)
    //        {
    //            using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
    //            {
    //                connection.Open();
    //                using (SqlCommand command = new SqlCommand())
    //                {
    //                    command.Connection = connection;
    //                    command.CommandText = "Delete From Car Where Id = @Id";
    //                    command.Parameters.Add(new SqlParameter("@Id", id));
    //                    command.ExecuteReader();
    //                }
    //            }
    //        }
    //        public void Update(int id, Car NewEntity)
    //        {
    //            using (SqlConnection connection = new SqlConnection(DataBase.CONNECTION_STRING))
    //            {
    //                connection.Open();
    //                using (SqlCommand command = new SqlCommand())
    //                {
    //                    command.Connection = connection;
    //                    command.CommandText = "Update Car set Year = @Year Mark = @Mark, Model = @Model, VehicleType = @VehicleType where @Id = Id";
    //                    command.Parameters.Add(new SqlParameter("@id", id));
    //                    command.Parameters.Add(new SqlParameter("@Year", NewEntity.Year));
    //                    command.Parameters.Add(new SqlParameter("@Mark", NewEntity.Mark));
    //                    command.Parameters.Add(new SqlParameter("@Model", NewEntity.Model));
    //                    command.Parameters.Add(new SqlParameter("@VehicleType", NewEntity.VehicleType));
    //                    command.ExecuteReader();
    //                }
    //            }
    //        }
    //    }
    //}
}
