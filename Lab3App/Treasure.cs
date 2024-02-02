using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure:Collectable
    {
        public int TotalScore { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        public override string Description { get; set; }

        public Treasure(String name, int score)
        {
            Description = name;
            Score = score;
        }
        public override void UpdateTotalScore() {
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
