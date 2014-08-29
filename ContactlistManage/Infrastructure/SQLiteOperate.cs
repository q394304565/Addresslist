using System;
using System.Data.SQLite;
using System.IO;
using System.Reflection;

namespace Infrastructure
{
    public class SQLiteOperate
    {
        public const string ConnectionString = "data source=.\\Config.db";
        public static void CreateDB()
        {
            if (!File.Exists(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + ".\\Config.db"))
            {
                using (var sqlConn = new SQLiteConnection(ConnectionString))
                {
                    var sql = "CREATE TABLE [TB_Config] (" +
                               "[Id] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT," +
                               "[Name] NVARCHAR(50) NOT NULL, " +
                               "[Config] BLOB); ";
                    try
                    {
                        sqlConn.Open();
                        var cmd = sqlConn.CreateCommand();
                        cmd.CommandText = sql;
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        sqlConn.Close();
                    }
                }
            }
        }

        public static UserConfig GetUserConfig()
        {
            using (var sqlConn = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    sqlConn.Open();
                    var cmd = sqlConn.CreateCommand();
                    cmd.CommandText = "select Config from TB_Config where name='UserConfig'";
                    var data = cmd.ExecuteScalar();
                    if (data == null)
                        return null;
                    return ObjectEx.FromBinary<UserConfig>((byte[])data);
                }
                catch (Exception)
                {
                    sqlConn.Close();
                }
            }
            return null;
        }

        public static void AddUserConfig(UserConfig userConfig)
        {
            using (var sqlConn = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    sqlConn.Open();
                    var cmd = sqlConn.CreateCommand();
                    cmd.CommandText = string.Format("insert into TB_Config([Name],[Config]) values('UserConfig',@Config);");
                    cmd.Parameters.Add(new SQLiteParameter("@Config", ObjectEx.ToBinary(userConfig)));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    sqlConn.Close();
                }
            }
        }

        public static void ModifyUserConfig(UserConfig userConfig)
        {
            using (var sqlConn = new SQLiteConnection(ConnectionString))
            {
                try
                {
                    sqlConn.Open();
                    var cmd = sqlConn.CreateCommand();
                    cmd.CommandText = string.Format("update TB_Config set Config=@Config where [Name]='UserConfig'");
                    cmd.Parameters.Add(new SQLiteParameter("@Config", ObjectEx.ToBinary(userConfig)));
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    sqlConn.Close();
                }
            }
        }
    }
}
