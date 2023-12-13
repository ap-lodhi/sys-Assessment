using Final_Assessment.interfacess;
using Final_Assessment.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Final_Assessment.Dal
{
    public class Register : RegisterInterface
    {
        private readonly string connection = Startup.StaticConfiguration["customData:Connectionstring"];

        // Signup method  with message  funtionality
        public ResponseModel SignupUser(RegisterModel objmodel)
        {

            ResponseModel result = new ResponseModel();
            RegisterModel User = new RegisterModel();
            MailMessage msg = new MailMessage();
             SmtpClient smtp = new SmtpClient();
            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {

                    con.Open();

                    using (SqlCommand checkUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM UserTable WHERE Email = @Email", con))
                    {
                        checkUsernameCmd.Parameters.AddWithValue("@Email", objmodel.Email);
                        int existingUserCount = (int)checkUsernameCmd.ExecuteScalar();

                        if (existingUserCount > 0)
                        {

                            result.status = false;
                            result.message = "User EmailId already exists. Please choose a different email id.";
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand("sp_Insert_RgisterUserData", con))

                            {

                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@Name", objmodel.Name);
                                cmd.Parameters.AddWithValue("@Email", objmodel.Email);
                                cmd.Parameters.AddWithValue("@CreatedAt", DateTime.UtcNow);
                                cmd.Parameters.AddWithValue("@Phone", objmodel.phone);
                                string encryptedPassword = EncryptPassword(objmodel.decryptedPassword);
                                cmd.Parameters.AddWithValue("@EncryptedPassword", encryptedPassword);


                                cmd.Parameters.AddWithValue("@DecryptedPassword", objmodel.decryptedPassword);


                                var id = cmd.ExecuteNonQuery();

                                if (id > 0)
                                {
                                    result.status = true;

                                    msg.From = new MailAddress("anil.patel@cylsys.com");


                                    msg.To.Add(objmodel.Email);

                                    msg.Subject = "Testing Mail For Registration";

                                    msg.Body = "You Registration is successful..!!";

                                    msg.IsBodyHtml = true;

                                    smtp.Host = "smtp-mail.outlook.com";

                                    smtp.Port = 587;

                                    smtp.EnableSsl = true;

                                    smtp.UseDefaultCredentials = false;

                                    smtp.Credentials = new NetworkCredential("anil.patel@cylsys.com", "Cylsys@2");

                                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                                    smtp.Send(msg);
                                    result.message = "User Register Successfully";



                                }
                                else
                                {
                                    result.status = false;
                                    result.message = "Please Check...Something Went wrong...!!!";

                                }
                            }

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

        // password encription method

        private string EncryptPassword(string password)
        {
            string encryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            byte[] clearBytes = Encoding.Unicode.GetBytes(password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }


         public ResponseModel loginUser(RegisterModel objmodel)
        {
            ResponseModel result = new ResponseModel();

            using (SqlConnection con = new SqlConnection(connection))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("ValidateLoginUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", objmodel.Name);
                        cmd.Parameters.AddWithValue("@Email", objmodel.Email);

                        cmd.Parameters.AddWithValue("@DecryptedPassword", objmodel.decryptedPassword);

                        var reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            result.status = true;
                            result.message = "Login successful.";
                        }
                        else
                        {
                            result.status = false;
                            result.message = "Invalid email or password.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.status = false;
                    result.message = "An error occurred. Please try again later.";
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
