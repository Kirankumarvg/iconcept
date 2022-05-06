using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiran.Library.shapes
{
    public class Circle
    {
        #region "Member Fields  "
        /// <summary>
        /// it is a radius of the circle in cm.
        /// </summary> 
        int _radius;

        /// <summary>
        /// it is a fill the color of the circle 
        /// </summary>
        KiranColors FillColor;

        /// <summary>
        /// provided the color to be used forecolor
        /// </summary>
        KiranColors ForeColor;

        #endregion

        #region "Constructor Members"
        //one parameter constructor
        //* constructor doen't have returntype
        public Circle(int radius)
        {
            _radius = radius;

        }

        #endregion

        #region " It is a Member Functions Region"

        /// <summary>
        /// it claculate the area of the value prisent in the circle
        /// </summary>
        /// <returns>returns the calclated area </returns>
        public float GetArea()
        {
            return (22 / 7) * _radius * _radius;
        }

        /// <summary>
        /// it draws the circle 
        /// </summary>
        public void DrawCircle()
        {
            //it utilzees the fillcolor and forecolor
            //tobe implmented 
        }

        /// <summary>
        /// it claculat the circumforance of the value in prisent in the circle 
        /// </summary>
        /// <returns></returns>
          public int GetCircumfornce()
         {
            return 2 * (22 / 7) * _radius;
        }
        #endregion
    }
}
