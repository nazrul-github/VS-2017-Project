using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
  public static  class GlobalConfig
    {
        public static List<IDataConncetion> Conncetions { get; private set; } = new List<IDataConncetion>();
        public static object ConfigarationManager { get; private set; }

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - create the sql connection
                SqlConnector sql = new SqlConnector();
                Conncetions.Add(sql);
            }
            if (textFiles)
            {
                //TODO - create the Test connection
                TextConnector text = new TextConnector();
                Conncetions.Add(text);
            }
        }
    }
}
