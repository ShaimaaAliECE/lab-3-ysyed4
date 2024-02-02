using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Diamond: Collectable, Displayable
    {
        public Diamond(string description, int score)
        {
            Description = description;
            Score = score;
        }

        public override string Description { get; set; }
        public  int Score { get; set; }

        
        public override void Display()
        {
        
            Console.WriteLine($"Diamond{Description} is displayed");
        }
        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += Score;
        }
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            UpdateTotalScore();
            Console.WriteLine($"{this.Description} Collected, Congrats!!!!");
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotalScore}");
            collectables.Remove(this);
            
        }
    }
}
