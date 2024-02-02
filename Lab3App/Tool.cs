using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Tool:Collectable
    {
        public override string  Description { get; set; }
        public Tool(String name)
        {
            Description = name;
        }
        public abstract void DoAction();
        
        public override void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            Console.WriteLine($"{this.Description} Collected, Congrats!!!!");
            collectables.Remove(this);
        }
    }
}
