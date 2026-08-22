using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace Twiteer.test
{
    public class Class10
    {
        public void Run()
        {
            Tweet likeableTweet = new Tweet("This is another tweet");
            Console.WriteLine(likeableTweet.CanBeLiked());
            var maxContentLength = Tweet.MaxContentLength;
            Console.WriteLine(maxContentLength);
        }
    }
}
