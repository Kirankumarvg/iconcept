using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiran.Library.shapes
{
    public class Square
    {
        int Area;
        int _side;

        public Square(int side)
        {
            this._side = side;
        }

        public int GetSquareArea()
        {
            Area = _side* _side;  
            return Area;
        }

}
}
