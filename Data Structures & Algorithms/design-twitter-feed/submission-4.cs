public class Twitter
{
    public Dictionary<int, HashSet<int>> follower;
    private Dictionary<int, List<(int tweetId, int time)>> tweets;
    public int amountMostRecentTweets;
    public int time;


    public Twitter()
    {
        follower = new Dictionary<int, HashSet<int>>();
        tweets = new Dictionary<int, List<(int tweetId, int time)>>();
        amountMostRecentTweets = 10;
        time = 0;
    }

    public void PostTweet(int userId, int tweetId)
    {
        if (!tweets.ContainsKey(userId))
            tweets[userId] = new List<(int tweetId, int time)>();

        tweets[userId].Add((tweetId, time++));
    }

    public List<int> GetNewsFeed(int userId)
    {
        var queue = new PriorityQueue<int, int>();
        var list = new List<int>();

        // check each follower of user
        if (follower.ContainsKey(userId))
        {
            foreach (var followeeId in follower[userId])
            {
                if (!tweets.ContainsKey(followeeId))
                    continue;
                // check each tweet of followers
                foreach (var i in tweets[followeeId])
                {
                    queue.Enqueue(i.tweetId, -i.time);
                }
            }
        }

        if (tweets.ContainsKey(userId))
        {
            foreach (var i in tweets[userId])
            {
                queue.Enqueue(i.tweetId, -i.time);
            }
        }

        while (queue.Count > 0 && list.Count < 10)
        {
            list.Add(queue.Dequeue());
        }

        return list;
    }

    public void Follow(int followerId, int followeeId)
{
    if (followeeId == followerId)
        return;

    if (!follower.ContainsKey(followerId))
        follower[followerId] = new HashSet<int>();

    follower[followerId].Add(followeeId);
}

    public void Unfollow(int followerId, int followeeId)
    {
        if (!follower.ContainsKey(followerId))
            return;

        follower[followerId].Remove(followeeId);
    }
}