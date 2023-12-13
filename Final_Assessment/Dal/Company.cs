using Final_Assessment.interfacess;
using Final_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Assessment.Dal
{
    public class Company : CompanyInterface
    {

        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];


        public List<ContryModel> getCountryList()

        {

            List<ContryModel> res = new List<ContryModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("select  CountryId ,CountryName from   Countries", con))

                    {
                        cmd.CommandType = CommandType.Text;



                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                ContryModel u = new ContryModel();
                                u.CountryId = string.IsNullOrEmpty(reader["CountryId"].ToString()) ? 0 : Convert.ToInt32(reader["CountryId"]);

                                u.CountryName = string.IsNullOrWhiteSpace(reader["CountryName"].ToString()) ? "" : reader["CountryName"].ToString();

                                res.Add(u);



                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }



        }

        public List<StateModel> getStateList( int id)

        {

            List<StateModel> res = new List<StateModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetStatesByCountry", con))

                    {
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@CountryId", id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                StateModel u = new StateModel();
                                u.StateId = string.IsNullOrEmpty(reader["StateId"].ToString()) ? 0 : Convert.ToInt32(reader["StateId"]);

                                u.StateName = string.IsNullOrWhiteSpace(reader["StateName"].ToString()) ? "" : reader["StateName"].ToString();

                                res.Add(u);



                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }



        }

        public List<CityModel> getCityList(int id)

        {

            List<CityModel> res = new List<CityModel>();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetcityByState", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@StateId", id);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                CityModel u = new CityModel();

                                u.CityId = string.IsNullOrEmpty(reader["CityId"].ToString()) ? 0 : Convert.ToInt32(reader["CityId"]);

                                u.CityName = string.IsNullOrWhiteSpace(reader["CityName"].ToString()) ? "" : reader["CityName"].ToString();

                                res.Add(u);


                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    Console.WriteLine(ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

                return res;

            }


        }


        public ResponseModel saveCompany(CompanyModel C)

        {

            ResponseModel result = new ResponseModel();

            CompanyModel User = new CompanyModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                try

                {

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertCompanyTable", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CompanyName", C.CompanyName);

                        cmd.Parameters.AddWithValue("@CompanyEmail", C.CompanyEmail);

                        cmd.Parameters.AddWithValue("@CompanyURL", C.CompanyURL);

                        cmd.Parameters.AddWithValue("@Remark", C.Remark);

                        cmd.Parameters.AddWithValue("@CompanyLocation", C.CompanyLocation);

                        cmd.Parameters.AddWithValue("@UserId", C.UserId);

                        cmd.Parameters.AddWithValue("@Phone_Number", C.Phone_Number);

                        cmd.Parameters.AddWithValue("@Number_of_Employees", C.Number_of_Employe);

                        cmd.Parameters.AddWithValue("@Timezone", C.Timezone);


                        cmd.Parameters.AddWithValue("@Country", C.Country);

                        cmd.Parameters.AddWithValue("@State", C.State);

                        cmd.Parameters.AddWithValue("@City", C.City);

                        cmd.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);

                        var id = cmd.ExecuteNonQuery();

                        if (id > 0)

                        {

                            result.status = true;

                            result.message = " Company Saved Successfully";

                        }

                        else

                        {

                            result.status = false;

                            result.message = "Please Check...Something Went wrong...!!!";

                        }

                    }

                }

                catch (Exception ex)

                {

                    result.status = false;

                    Helper.WriteLog("The error is:" + ex);

                    Console.WriteLine("Error is:" + ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

            }

            return result;

        }

        public List<CompanyModel> getComapnyList()
        {
            List<CompanyModel> res = new List<CompanyModel>();

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("GetCompanyDetailsById", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                CompanyModel u = new CompanyModel();
                                u.Company_Id= (int)reader["Company_Id"];
                                u.CompanyName = (string)reader["CompanyName"];
                                u.CompanyEmail = (string)reader["CompanyEmail"];
                                u.CompanyLocation = (string)reader["CompanyLocation"];
                                u.Remark = (string)reader["Remark"];
                                u.CompanyURL = (string)reader["CompanyURL"];
                                u.UserId = (int)reader["UserId"];
                                u.Phone_Number= (string)reader["Phone_Number"];
                                u.Number_of_Employe= (int)reader["Number_of_Employees"];
                                u.Timezone = (string)reader["Timezone"];
                                u.Country = (string)reader["CountryName"];
                                u.State = (string)reader["StateName"];
                                u.City = (string)reader["CityName"];



                                u.CreatedAt = string.IsNullOrWhiteSpace(reader["CreatedAt"].ToString()) ? Convert.ToDateTime(DateTime.Now.ToString("1900-01-01")) : Convert.ToDateTime(reader["CreatedAt"]);
                               

                                res.Add(u);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Helper.WriteLog("The error is:" + ex);
                }
                finally
                {
                    con.Close();
                    con.Dispose();
                }

                return res;
            }
        }


        public CompanyModel editCompany(int id)

        {

            ResponseModel res = new ResponseModel();

            CompanyModel User = new CompanyModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                con.Open();

                try

                {

                    using (SqlCommand cmd = new SqlCommand("GetCompanyDetailsByIdByIDiddddddd", con))

                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CompanyId", id);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)

                        {

                            while (reader.Read())

                            {

                                User.Company_Id = string.IsNullOrEmpty(reader["Company_Id"].ToString()) ? 0 : Convert.ToInt32(reader["Company_Id"]);
                                User.CompanyName = string.IsNullOrWhiteSpace(reader["CompanyName"].ToString()) ? "" : reader["CompanyName"].ToString();
                                User.CompanyURL = string.IsNullOrWhiteSpace(reader["CompanyURL"].ToString()) ? "" : reader["CompanyURL"].ToString();
                                User.CompanyEmail = string.IsNullOrWhiteSpace(reader["CompanyEmail"].ToString()) ? "" : reader["CompanyEmail"].ToString();
                                User.Remark = string.IsNullOrWhiteSpace(reader["Remark"].ToString()) ? "" : reader["Remark"].ToString();
                                User.CompanyLocation = string.IsNullOrWhiteSpace(reader["CompanyLocation"].ToString()) ? "" : reader["CompanyLocation"].ToString();
                                User.UserId = string.IsNullOrEmpty(reader["UserId"].ToString()) ? 0 : Convert.ToInt32(reader["UserId"]);
                                User.Number_of_Employe = string.IsNullOrEmpty(reader["Number_of_Employees"].ToString()) ? 0 : Convert.ToInt32(reader["Number_of_Employees"]);
                                User.Phone_Number=string.IsNullOrWhiteSpace(reader["Phone_Number"].ToString()) ? "" : reader["Phone_Number"].ToString();
                                User.Timezone =string.IsNullOrWhiteSpace(reader["Timezone"].ToString()) ? "" : reader["Timezone"].ToString();
                                User.Country=string.IsNullOrWhiteSpace(reader["CountryName"].ToString()) ? "" : reader["CountryName"].ToString();
                                User.State=string.IsNullOrWhiteSpace(reader["StateName"].ToString()) ? "" : reader["StateName"].ToString();
                                User.City=string.IsNullOrWhiteSpace(reader["CityName"].ToString()) ? "" : reader["CityName"].ToString();
                                  

                            }

                        }

                    }

                }

                catch (Exception ex)

                {

                    res.status = false;
                    Helper.WriteLog("The error is:" + ex);
                    res.message = "Errorr!!!";

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }


            }

            return User;

        }


        public ResponseModel updateCompany(CompanyModel C)

        {

            ResponseModel result = new ResponseModel();

            CompanyModel User = new CompanyModel();

            using (SqlConnection con = new SqlConnection(connection))

            {

                try

                {

                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("Sp_UpdateCompanyDetailsById", con))

                    {
                        cmd.Parameters.AddWithValue("@Company_Id", C.Company_Id);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@CompanyName", C.CompanyName);

                        cmd.Parameters.AddWithValue("@CompanyEmail", C.CompanyEmail);

                        cmd.Parameters.AddWithValue("@CompanyURL", C.CompanyURL);

                        cmd.Parameters.AddWithValue("@Remark", C.Remark);

                        cmd.Parameters.AddWithValue("@CompanyLocation", C.CompanyLocation);

                        cmd.Parameters.AddWithValue("@UserId", C.UserId);

                        cmd.Parameters.AddWithValue("@Phone_Number", C.Phone_Number);

                        cmd.Parameters.AddWithValue("@Number_of_Employees", C.Number_of_Employe);

                        cmd.Parameters.AddWithValue("@Timezone", C.Timezone);


                        cmd.Parameters.AddWithValue("@Country", C.Country);

                        cmd.Parameters.AddWithValue("@State", C.State);

                        cmd.Parameters.AddWithValue("@City", C.City);

             

                        var id = cmd.ExecuteNonQuery();

                        if (id > 0)

                        {

                            result.status = true;

                            result.message = " Company Details  update   Successfully";

                        }

                        else

                        {

                            result.status = false;

                            result.message = "Please Check...Something Went wrong...!!!";

                        }

                    }

                }

                catch (Exception ex)

                {

                    result.status = false;

                    Helper.WriteLog("The error is:" + ex);

                    Console.WriteLine("Error is:" + ex);

                }

                finally

                {

                    con.Close();

                    con.Dispose();

                }

            }

            return result;

        }


    }
}
