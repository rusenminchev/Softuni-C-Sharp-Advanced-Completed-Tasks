using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<firstItem,secondItem, thirdItem>
    {
        public Threeuple(firstItem firstItem, secondItem secondItem, thirdItem thirdItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
            this.ThirdItem = thirdItem;
        }

        public firstItem FirstItem { get; set; }

        public secondItem SecondItem { get; set; }

        public thirdItem ThirdItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem} -> {this.ThirdItem}";
        }
    }
}
