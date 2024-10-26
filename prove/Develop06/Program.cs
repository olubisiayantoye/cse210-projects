
using System;
/*
 * Program Exceeded Requirements:
 *
 * 1. Negative Goals allow users to set goals with negative points to discourage bad habits.
 * 2. Leveling System rewards users by leveling up every 100 points earned, adding gamification.
 * 3. Milestone Tracking in Checklist Goals for long-term accomplishments.
 */

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Run();
    }
}
