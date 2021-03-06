using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServerlessNewsPipeline
{
    public static class NewsFetcher
    {
        [FunctionName("Fetch")]
        public static void Run([TimerTrigger("0 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            // Retrieve fresh news from Google API (using the News library in our solution)
            // ...

            // Run sentiment analysis on the news articles (using our Sentiment library in our solution) and filter out the unhappy ones
            // ...

            // If we successfully retrieved fresh news, delete the old news from the database
            // ...

            // Update SQL database with fresh (happy) news
            // ...
        }
    }
}
