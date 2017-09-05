using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyT4Dome
{
    class Program
    {
        static void Main(string[] args)
        {
            var tables = DbHelper.GetDbTables(config.ConnectionString, config.DbDatabase);
            foreach (var table in tables)
            {
                var tablename = table.TableName.Substring(0, table.TableName.Length - 1);
                if (table.TableName.Contains("Map"))
                {
                    tablename = table.TableName;
                }
            }
        }
    }
    public class config
    {
        public static readonly string ConnectionString = "server=sinoauto.database.chinacloudapi.cn;database=hqchain;user=sinoauto;pwd=Huaqi@2016";
        public static readonly string DbDatabase = "hqchain";
    }
}
