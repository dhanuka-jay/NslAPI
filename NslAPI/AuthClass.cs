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

                //string k = Kripta.Encrypt("c3d740bc-ad70-48c1-9e56-1a18661b6e7e", "Sud@#$%-=.Con").ToString();

                //string encr_tk = _configuration.GetSection("Jwt").GetValue<string>("key");
                //string tokenKey = Kripta.Decrypt(encr_tk, "Sud@#$%-=.Con").ToString().Trim();

                return con_;
            }
            catch //(Exception ex)
            {

                return "Error retrieving ConnectionString";
            }
        }

        public static string GetTokenKey(IConfiguration _configuration)
        {
            string encr_tk = _configuration.GetSection("Jwt").GetValue<string>("key");
            string tokenKey = Kripta.Decrypt(encr_tk, "Sud@#$%-=.Con").ToString().Trim();

            return tokenKey;
        }
    }
}
