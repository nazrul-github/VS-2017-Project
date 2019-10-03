using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The uniqu identifier for the prize
        /// </summary>
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PricePercentage { get; set; }

        public PrizeModel()
        {
        }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string pricePercentage)
        {
            int placenumberValue = 0;
            int.TryParse(placeNumber, out placenumberValue);
            PlaceName = placeName;
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            double pricePercentageValue = 0;
            double.TryParse(pricePercentage, out pricePercentageValue);
            PricePercentage = pricePercentageValue;

        }
    }
}
