using System.Collections.Generic;


namespace unit04_greed.Game.Casting
{
    /// <summary>
    /// <para>A color.</para>
    /// <para>The responsibility of Color is to hold and provide information about itself. Color has 
    /// a few convenience methods for comparing and converting them.
    /// </para>
    /// </summary>
    public class Color
    {
        private int red = 0;
        private int green = 0;
        private int blue = 0;
        private int alpha = 255;

       
        /// <param name="red">The given red value (0-255).</param>
        /// <param name="green">The given green value (0-255).</param>
        /// <param name="blue">The given blue value (0-255).</param>
        public Color(int red, int green, int blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
        }

        /// <returns>The alpha value.</returns>
        public int GetAlpha()
        {
            return alpha;
        }

        /// <returns>The blue value.</returns>
        public int GetBlue()
        {
            return blue;
        }

        /// <returns>The green value.</returns>
        public int GetGreen()
        {
            return green;
        }

        
        /// <returns>The red value.</returns>
        public int GetRed()
        {
            return red;
        }

    }
}