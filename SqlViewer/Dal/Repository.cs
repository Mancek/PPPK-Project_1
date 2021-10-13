using SqlViewer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer.Dal
{
    class Repository : IRepository
    {
        private string cs;

        private const string ConString = "Server={0};Uid={1};Pwd={2}";
        private const string DatabaseConString = "{0};Database={1}";
        private const string SelectDatabases = "SELECT name As Name FROM sys.databases";

        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }

        public OutputResult ExecuteCommand(string tbQuery, Database usingDatabase)
        {
            using (SqlConnection con = new SqlConnection(string.Format(DatabaseConString, cs, usingDatabase.Name)))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = tbQuery;
                    cmd.CommandType = CommandType.Text;
                    Command command = ParseCommand(tbQuery);
                    switch (command)
                    {
                        case Command.SELECT:
                            return PrepareOutput(tbQuery, con);
                        case Command.UPDATE:
                            return new OutputResult { Message = $"Updated {cmd.ExecuteNonQuery()} rows." };
                        case Command.DELETE:
                            return new OutputResult { Message = $"Deleted {cmd.ExecuteNonQuery()} rows." };
                        case Command.INSERT:
                            return new OutputResult { Message = $"Inserted {cmd.ExecuteNonQuery()} rows." };
                        case Command.CREATE:
                            cmd.ExecuteNonQuery();
                            return new OutputResult { Message = $"Commands completed successfully." };
                        case Command.ALTER:
                            cmd.ExecuteNonQuery();
                            return new OutputResult { Message = $"Commands completed successfully." };
                        case Command.DROP:
                            cmd.ExecuteNonQuery();
                            return new OutputResult { Message = $"Commands completed successfully." };
                        default:
                            throw new Exception("Unrecognized SQL Command.");
                    }
                }
            }
        }

        private static OutputResult PrepareOutput(string tbQuery, SqlConnection con)
        {
            OutputResult output = new OutputResult
            {
                Message = "",
                Data = new DataSet()
            };
            using (SqlDataAdapter da = new SqlDataAdapter(tbQuery, con))
            {
                DataSet ds = new DataSet();
                da.Fill(output.Data);
            }
            return output;
        }

        private Command ParseCommand(string query)
        {
            string[] queryString = query.Split(' ');
            return (Command)Enum.Parse(typeof(Command), queryString[0].ToUpper());
        }
    }
}
