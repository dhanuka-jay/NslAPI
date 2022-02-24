using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace NslAPI
{
    public class AuthClass
    {
        public static string GetConnectionString(IConfiguration _configuration)
        {
            try
            {
                string dbp = _configuration.GetSection("ConnectionStrings").GetValue<string>("Kripton_Key");
                string ConStuff = Kripta.Decrypt(dbp, "Sud@#$%-=.Pas").ToString().Trim();

                string conString = _configuration.GetSection("ConnectionStrings").GetValue<string>("sqlConnection");
                string con_ = Kripta.Decrypt(conString, "Sud@#$%-=.Con").ToString().Trim().Replace("pass", ConStuff);

                //string c = Kripta.Encrypt("Data Source=127.0.0.1;User ID=sa;Password=pass;Initial Catalog=NSL_DB; Connection Timeout=320;pooling=true;Max Pool Size=400", "Sud@#$%-=.Con").ToString();
                //string v = Kripta.Encrypt("myowndbpassword", "Sud@#$%-=.Pas").ToString();
                //return c;

                return con_;
            }
            catch //(Exception ex)
            {

                return "Error retrieving ConnectionString";
            }
        }
    }
}
