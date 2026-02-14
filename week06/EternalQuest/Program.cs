/*To earn full credit, I added functionality to save the data 
in a JSON file that is automatically loaded on start (if available) 
and saved on the exit function. I also added a delete function to 
remove un-needed goals.*/
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        if (System.IO.File.Exists("SaveData.json"))
            {
            goalManager.LoadGoals(); 
            }
        goalManager.Start();
    }
}