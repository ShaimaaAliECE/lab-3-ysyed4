using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Coin : Collectable,Displayable
    { public int Value { get; set; }
        public int Score { get; set; }
        public string Name { get; set; }
        public override string Description { get; set; }


        public Coin(String description, int score, int value)
        {
            Value = value;
            Description = description;
            Score = score;
        }


        public override void UpdateTotalScore()
        {
            CollectionBoard.TotalScore += Score;
        }
        public void UpdateTotalValue()
        {
            CollectionBoard.TotalValue += Value;
            
        }

        public override void Display()
        {
            Console.WriteLine($"Coin {this.Description} is displayed");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            UpdateTotalValue();
            UpdateTotalScore();
            Console.WriteLine($"{this.Description} Collected, Congrats!!!!");
            Console.WriteLine($"Total Score is updated to: {CollectionBoard.TotalScore}");
            Console.WriteLine($"Total Value is updated to: {CollectionBoard.TotalValue}");
            collectables.Remove(this);
            
            
        }

    }
}
