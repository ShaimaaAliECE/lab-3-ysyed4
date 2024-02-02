using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class MagicWand : Collectable, Displayable
    {
        
        public override void Display()
        { 
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
        public override string Description { get; set; }
        public MagicWand(string name)
        {
            Description = name;
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }

        public void DoAction()
        {
            Console.WriteLine($"MagicWand is used");
        }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }
    }
}
