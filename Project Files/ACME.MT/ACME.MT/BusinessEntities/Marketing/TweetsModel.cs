using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.MT.BusinessEntities.Marketing
{
    public class TweetsModel
    {
        //Attributes
        public int KeyId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public string Tweet { get; set; }
        public string Location { get; set; }
        public List<TweetsBE> TweetsList { get; set; }

        //Constructor

        public TweetsModel()
        {
            TweetsList = new List<TweetsBE>();
            Date = DateTime.Now;
        }

    }
}
