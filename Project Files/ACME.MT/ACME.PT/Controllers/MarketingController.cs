using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ACME.MT.BusinessEntities.Marketing;
using ACME.MT.ServiceContracts;
using ACME.MT.Services;
using ACME.PT.Models;
using Microsoft.Web;

namespace ACME.PT.Controllers
{
    public class MarketingController : Controller
    {

        #region Heirarical Grid

        public ActionResult _TweetDetails(int keyId)
        {
            MarketingService _attSvc = new MarketingService();
            TweetsModel model = new TweetsModel();

            model.TweetsList = _attSvc.GetAllTweets().Where(m => m.KeyId == keyId).ToList();

            return View(model);
        }

        #endregion

        #region ManageTweets

        [HttpGet]
        public ActionResult ManageTweets(int? AttendanceID, string Mode)
        {
            MarketingService _attSvc = new MarketingService();
            TweetsModel model = new TweetsModel();

            model.TweetsList = _attSvc.GetAllTweets();

            return View(model);

        }

        [HttpPost]
        public ActionResult ManageTweets(TweetsModel model)
        {
            MarketingService _attSvc = new MarketingService();

            TweetsBE tweet = new TweetsBE();

            tweet.UserId = model.UserId;
            tweet.UserName = model.UserName;
            tweet.Tweet = model.Tweet;
            tweet.Date = model.Date;
            tweet.Location = "Riyadh, KSA";

            if (_attSvc.AddTweet(tweet))
            {
                ModelState.AddModelError("", "Tweet Saved Successfully");
            }
            else
            {
                ModelState.AddModelError("", "Unable to Save Tweet");
            }

            model.TweetsList = _attSvc.GetAllTweets();

            return View(model);
        }

        #endregion

    } 
}

