using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DbOperator
{
    class DbWriter
    {
        private static readonly log4net.ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void writeToDb(TestResult tr)
        {
            Console.WriteLine(tr.actualResult);
            Console.WriteLine(tr.endTime);
            Console.WriteLine(tr.executionStatus);
            Console.WriteLine(tr.failureReason);
         
            XmlConfigurator.Configure();

            string str = "Data Source=DESKTOP-FL8HUKR\\SQLEXPRESS;Initial Catalog=CompanyDb;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            using (con)
            {  
                try
                {

                    SqlCommand command2 = new SqlCommand("Insert into TestResult values('"+tr.actualResult+"','"+tr.executionStatus+"','"+tr.startTime+"','"+tr.endTime+"','"+tr.failureReason+"')", con);
               
                    command2.ExecuteNonQuery();
                   
                }

                catch (Exception ex)
                {
                    _log.Error(ex);
                }
            }

            Console.ReadKey();
        }
       
    }
   


    }

