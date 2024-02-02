using System;
using System.Collections.Generic;

namespace Lab3App
{
    public class Axe:Collectable,Displayable
    {
        public override string Description { get; set; }
        public Axe(String name)
        {
            Description = name;
        }
        public void DoAction()
        {
            Console.WriteLine("Axe is used");
        }
        public override void Display()
        {
            Console.WriteLine($"Axe {Description} is displayed");
        }
        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }

        public override void UpdateTotalScore()
        {
            throw new NotImplementedException();
        }
    }
}
