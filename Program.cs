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
    class Program
    {
        
        static void Main(string[] args)
        {
            DbWriter db = new DbWriter();
            TestResult tr1, tr2;

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now;
            
             tr1 = new TestResult("true","passed",start,end,"exception");
            tr2 = new TestResult("false", "failed", start, end, "error");

            db.writeToDb(tr1);
            Console.WriteLine("***");
            db.writeToDb(tr2);
            Console.ReadKey();
        }
    }
}
             
            
        
    

