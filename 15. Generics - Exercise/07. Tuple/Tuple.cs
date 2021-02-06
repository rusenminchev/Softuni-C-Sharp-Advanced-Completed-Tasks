using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Tuple<firstItem,secondItem>
    {

        public Tuple(firstItem firstItem, secondItem secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public firstItem FirstItem { get; set; }

        public secondItem SecondItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
}
