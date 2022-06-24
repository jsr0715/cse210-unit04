namespace unit04_greed.Game.Casting
{
    public class Point
    {
        private int x = 0;
        private int y = 0;


        /// <param name="x">The given x value.</param>
        /// <param name="y">The given y value.</param>
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <param name="other">The point to add.</param>
        /// <returns>The sum as a new Point.</returns>
        public Point Add(Point other)
        {
            int x = this.x + other.GetX();
            int y = this.y + other.GetY();
            return new Point(x, y);
        }

        /// <param name="other">The point to compare.</param>
        /// <returns>True if both x and y are equal; false if otherwise.</returns>
        public bool Equals(Point other)
        {
            return this.x == other.GetX() && this.y == other.GetY();
        }

    
        /// <returns>The x coordinate.</returns>
        public int GetX()
        {
            return x;
        }
        /// <returns>The y coordinate.</returns>
        public int GetY()
        {
            return y;
        }
        
        /// <param name="factor">The scaling factor.</param>
        /// <returns>A scaled instance of Point.</returns>
        public Point Scale(int factor)
        {
            int x = this.x * factor;
            int y = this.y * factor;
            return new Point(x, y);
        }
    }
}