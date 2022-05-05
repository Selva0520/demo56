using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDataAccessLayer
{
    public class BookDAL
    {
        SqlConnection sqlConObj;

        string sqlString = @"Server=(localdb)\MSSQLLocalDB;Database=BookRecommendation;Trusted_Connection=True;";

        public BookDAL()
        {
            sqlConObj = new SqlConnection(sqlString);
        }
        public int ConnectToDB()
        {
            try
            {
                if (sqlConObj.State.ToString() == "open")
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                sqlConObj.Close();
                return 0;

            }
            finally
            {
                sqlConObj.Close();
            }



        }

        public int getBookCount()
        {
            throw new NotImplementedException();
        }
    }
}
//end
