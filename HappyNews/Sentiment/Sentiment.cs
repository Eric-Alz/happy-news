using System;
using System.Collections.Generic;
using News;

namespace Sentiment
{
    public class Sentiment
    {
        public List<Article> FilterOutUnhappyNews(List<Article> articles)
        {
            return null;
        }

        private double GetSentiment(string s)
        {
            // Use Azure's SA service to evaluate a string's sentiment
            // ...

            return -1;
        }
    }
}
