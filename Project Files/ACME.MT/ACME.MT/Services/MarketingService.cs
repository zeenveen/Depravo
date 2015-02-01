using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ACME.MT.ServiceContracts;
using ACME.MT.BusinessEntities.Marketing;
using System.Data.SqlClient;
using System.Configuration;

namespace ACME.MT.Services
{
    public class MarketingService : IMarketing
    {

        #region Tweets

        public bool AddTweet(TweetsBE tweet)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost\sqlexpress; Initial Catalog=ERP; Integrated Security=true;";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "Insert into tTweets (UserId, UserName, Date, Tweet, Location) values(@UserId, @UserName, @Date, @Tweet, @Location)";
                cmd.Parameters.AddWithValue("@UserId", tweet.UserId);
                cmd.Parameters.AddWithValue("@UserName", tweet.UserName);
                cmd.Parameters.AddWithValue("@Date", tweet.Date);
                cmd.Parameters.AddWithValue("@Tweet", tweet.Tweet);
                cmd.Parameters.AddWithValue("@Location", tweet.Location);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool ModifyTweet(TweetsBE tweet)
        {
            //Not yet Defined
            throw new NotImplementedException();
        }

        public bool DeleteTweet(int keyId)
        {
            //Not yet Defined
            throw new NotImplementedException();
        }

        public TweetsBE GetTweetById(int keyId)
        {
            //Not yet Defined
            throw new NotImplementedException();
        }

        public List<TweetsBE> GetAllTweets()
        {
            List<TweetsBE> tweetsList = new List<TweetsBE>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost\sqlexpress; Initial Catalog=ERP; Integrated Security=true;";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from tTweets";

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        TweetsBE twt = new TweetsBE();
                        twt.KeyId = (int)rdr["KeyId"];
                        twt.UserId = (string)rdr["UserId"];
                        twt.Date= (DateTime)rdr["Date"];
                        twt.Tweet = (string)rdr["Tweet"];
                        twt.UserName = (string)rdr["UserName"];
                        twt.Location = (string)rdr["Location"];

                        tweetsList.Add(twt);
                    }
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }

            return tweetsList;
        }

        #endregion

    }
}
