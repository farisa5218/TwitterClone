using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace TwitterClone.Application.Interfaces
{
    public interface ITweetRepository
    {
        Tweet AddTweet(Tweet tweet);
        Tweet UpdateTweet(Tweet tweet);
        bool DeleteTweet(Tweet tweet);
        int DeleteTweetsByUserId(Guid userId);
        Tweet? GetTweetById(Guid id);
        List<Tweet> GetTweets();
        List<Tweet> GetTweetsByUserId(Guid userId);
    }
}
