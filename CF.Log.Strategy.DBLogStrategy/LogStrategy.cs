using CF.Log.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CF.Log.Strategy.DBLogStrategy
{
    public class LogStrategy : ILogStrategy
    {
        public void WriteLog(ILogData logData)
        {
            var connection = GetConnnection();
            var command = GetLogCommand(logData.User, logData.LogMessage, logData.LogDate);
            command.Connection = connection;
            command.ExecuteNonQueryAsync();
        }

        private SqlConnection GetConnnection()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = ConfigurationManager.
                ConnectionStrings["LogConnection"].ConnectionString;
            cnn.Open();
            return cnn;

        }


        private SqlCommand GetLogCommand(string userName , string logData, DateTime logDate)
        {
            SqlCommand cmd = new SqlCommand();
            string tableName = ConfigurationManager.AppSettings["LogTableName"];
            string cmdStr = String.Format("Insert into {0} (UserName, LogData, LogDate)"+
                "Values ('{1}','{2}','{3}')",tableName,userName,logData,logDate.ToString("yyyy-MM-dd"));
            cmd.CommandText = cmdStr;
            return cmd;
        }
    }
}
