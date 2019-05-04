using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Data;
namespace MvcApplication2.Models
{
    public class DataLayer
    {
        private SqlConnection Con;
        string _con;
        public DataLayer()
        {
            Connection();
        }

        private void Connection()
        {
            try
            {
                _con = ConfigurationManager.ConnectionStrings["Db"].ToString();
                Con = new SqlConnection(_con);
                if (System.Data.ConnectionState.Open == Con.State)
                {
                    Con.Close();
                }
                Con.Open();
            }
            catch (Exception ex)
            {

            }
        }

        public List<Tab> CRUD_Tab(Tab model)
        {
            try
            {
                DynamicParameters Para = new DynamicParameters();
                Para.Add("@ID", model.ID);
                Para.Add("@Name", model.Name??string.Empty);
                Para.Add("@Age", model.Age);
                Para.Add("@Email", model.Email??string.Empty);
                Para.Add("@ProcId", model.ProcId);

                var lst = SqlMapper.Query<Tab>(Con, "Proc_M_Tab", Para, commandType: CommandType.StoredProcedure).ToList();

                return lst;
            }
            catch (Exception E)
            {
                return null;
            }
        }
    }
}