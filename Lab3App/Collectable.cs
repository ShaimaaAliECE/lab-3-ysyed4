using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Collectable
    {
        public abstract string Description { get; set; }
        public CollectionBoard board { get; set; }

        public virtual void AddMe(List<Collectable> collectables)
        {
            collectables.Add(this);
            collectables.Remove(this);

        }

        public abstract void Display();
        public abstract void UpdateTotalScore();
        
    }
}
