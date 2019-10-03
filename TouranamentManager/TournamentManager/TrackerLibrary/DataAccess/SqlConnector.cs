using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class SqlConnector : IDataConncetion
    {
        //TODO - Make the createPrize method actually save to the databae. 
        /// <summary>
        /// Save a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including The unique identifier.</return>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }

        
    }
}
