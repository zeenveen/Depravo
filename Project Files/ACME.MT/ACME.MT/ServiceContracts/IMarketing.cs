using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ACME.MT.BusinessEntities.Marketing;

namespace ACME.MT.ServiceContracts
{
    public interface IMarketing
    {

        #region Tweets

        bool AddTweet(TweetsBE tweet);
        bool ModifyTweet(TweetsBE tweet);
        bool DeleteTweet(int keyId);
        TweetsBE GetTweetById(int keyId);
        List<TweetsBE> GetAllTweets();

        #endregion

    }
}
    