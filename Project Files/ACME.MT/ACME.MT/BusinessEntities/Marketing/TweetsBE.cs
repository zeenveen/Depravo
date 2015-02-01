using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.MT.BusinessEntities.Marketing
{
    public class TweetsBE
    {
        //Attributes
        public int KeyId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Tweet { get; set; }
        public string Location { get; set; }

        //Constructor
        public TweetsBE()
        {
            UserId = "000000000";
            UserName = string.Empty;
            Date = DateTime.Now;
            Tweet = string.Empty;
        }

    }
}
