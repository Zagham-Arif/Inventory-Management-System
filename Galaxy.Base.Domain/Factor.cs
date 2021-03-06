﻿namespace Galaxy.Base.Domain
{
    public enum Operation
    {
        Percentage,
        Amount,
        Unit
    }

    public class Factor : BaseClass
    {
        public virtual string Name { get; set; }
        public virtual int Priority { get; set; }
        public virtual bool Increasing { get; set; }
        public virtual Operation Operation { get; set; }
        public virtual decimal Quantity { get; set; }
    }
}