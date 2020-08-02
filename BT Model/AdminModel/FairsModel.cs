using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Model
{
    public class FairsModel
    {
        public Guid FairId { get; set; }
        public decimal? Amount { get; set; }
        public Guid CityId { get; set; }
        public Guid DistrictId { get; set; }
        public decimal? Killometers { get; set; }
        public int? NumberOfStops { get; set; }
        public Guid? StopId { get; set; }
    }
}
