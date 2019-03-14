
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace information.Models
{
    public class DBhandle
    {
        private SqlConnection con;

       
        private void Connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
            con = new SqlConnection(constring);

        }
        public bool Addstudent(info smodel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("AddEvent", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id", smodel.Id);
            cmd.Parameters.AddWithValue("@Name", smodel.Name);
            cmd.Parameters.AddWithValue("@Place",smodel.Place);
            cmd.Parameters.AddWithValue("@DOB",smodel.DOB);
            cmd.Parameters.AddWithValue("@Joining", smodel.Joining);
            cmd.Parameters.AddWithValue("@BloodGroup", smodel.BloodGroup);
            cmd.Parameters.AddWithValue("@Designation", smodel.Designation);
            cmd.Parameters.AddWithValue("@Email", smodel.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", smodel.PhoneNo);
            cmd.Parameters.AddWithValue("@Bankname", smodel.Bankname);
            cmd.Parameters.AddWithValue("@AccountNo", smodel.AccountNo);
            cmd.Parameters.AddWithValue("@Type", smodel.Type);
           
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
            
        }
        public List<info> Getdetail()
        {
            Connection();
            List<info> studentlist = new List<info>();

            SqlCommand cmd = new SqlCommand("View", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                studentlist.Add(new info

                {
                        Id = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        Place = Convert.ToString(dr["Place"]),

                    DOB = Convert.ToDateTime(dr["DOB"]),
                    Joining = Convert.ToDateTime(dr["Joining"]),
                    BloodGroup = Convert.ToString(dr["BloodGroup"]),
                       Designation=Convert.ToString(dr["Designation"]),
                        Email = Convert.ToString(dr["Email"]),
                        PhoneNo = Convert.ToInt32(dr["PhoneNo"]),
                        Bankname = Convert.ToString(dr["Bankname"]),
                        AccountNo=Convert.ToInt32(dr["AccountNo"]),
                        Type = Convert.ToString(dr["Type"])
                      
                       
                 });
                
            }
            return studentlist;
        }
           
        




        public bool Updatedetail (info smodel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("UpdateTab", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id", smodel.Id);
            cmd.Parameters.AddWithValue("@Name", smodel.Name);
            cmd.Parameters.AddWithValue("@Place", smodel.Place);
            cmd.Parameters.AddWithValue("@DOB", smodel.DOB);
            cmd.Parameters.AddWithValue("@Joining", smodel.Joining);
            cmd.Parameters.AddWithValue("@BloodGroup", smodel.BloodGroup);
            cmd.Parameters.AddWithValue("@Designation", smodel.Designation);
            cmd.Parameters.AddWithValue("@Email", smodel.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", smodel.PhoneNo);
            cmd.Parameters.AddWithValue("@Bankname", smodel.Bankname);
            cmd.Parameters.AddWithValue("@AccountNo", smodel.AccountNo);
            cmd.Parameters.AddWithValue("@Type", smodel.Type);

           
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;




        }
        public bool Show(info smodel)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("View1", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id", smodel.Id);
            cmd.Parameters.AddWithValue("@Name", smodel.Name);
            cmd.Parameters.AddWithValue("@Place", smodel.Place);
            cmd.Parameters.AddWithValue("@DOB", smodel.DOB);
            cmd.Parameters.AddWithValue("@Joining", smodel.Joining);
            cmd.Parameters.AddWithValue("@BloodGroup", smodel.BloodGroup);
            cmd.Parameters.AddWithValue("@Designation", smodel.Designation);
            cmd.Parameters.AddWithValue("@Email", smodel.Email);
            cmd.Parameters.AddWithValue("@PhoneNo", smodel.PhoneNo);
            cmd.Parameters.AddWithValue("@Bankname", smodel.Bankname);
            cmd.Parameters.AddWithValue("@AccountNo", smodel.AccountNo);
            cmd.Parameters.AddWithValue("@Type", smodel.Type);
           
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;




        }
        public bool Deletedetail(int Id)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("DeleteTab", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@Id",Id);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
            {
                return false;
            }
        }


    }

        
}