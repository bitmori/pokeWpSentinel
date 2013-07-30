using System;
using System.Collections.Generic;
using System.Text;


namespace pokeTools
{
    public class WP
    {
        public string Path { get; set; }
        public int hr { get; set; }
        public int min { get; set; }
        public bool Equals(WP that)
        {
            return (Path.Equals(that.Path) && hr == that.hr && min == that.min);
        }

        public override bool Equals(object that)
        {
            if (that is WP) return Equals((WP)that);
            return base.Equals(that);
        }
    }

    public class WPCollection
    {
        public List<WP> wp { get; set; }
    }
}
