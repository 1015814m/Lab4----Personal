using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 
/// </summary>
public class Posts
{
    private int postID;
    private string post;
    private DateTime postTime;
    private int likes;
    private int employeeID;
    private int achievementID;
    /// <summary>
    /// For creating a post
    /// </summary>
    /// <param name="postID"></param>
    /// <param name="post"></param>
    /// <param name="postTime"></param>
    /// <param name="likes"></param>
    /// <param name="employeeID"></param>
    /// <param name="achievementID"></param>
    public Posts(int postID, string post, DateTime postTime, int likes, int employeeID, int achievementID)
    {
        PostID = postID;
        Post = post;
        PostTime = postTime;
        Likes = likes;
        EmployeeID = employeeID;
        AchievementID = achievementID;
    }

    public int PostID
    {
        get
        {
            return postID;
        }
        private set
        {
            postID = value;
        }
    }

    public string Post
    {
        get
        {
            return post;
        }
        private set
        {
            post = value;
        }
    }

    public DateTime PostTime
    {
        get
        {
            return postTime;
        }
        private set
        {
            postTime = value;
        }
    }

    public int Likes
    {
        get
        {
            return likes;
        }
        private set
        {
            likes = value;
        }
    }

    public int EmployeeID
    {
        get
        {
            return employeeID;
        }
        private set
        {
            employeeID = value;
        }
    }

    public int AchievementID
    {
        get
        {
            return achievementID;
        }
        private set
        {
            achievementID = value;
        }
    }
}