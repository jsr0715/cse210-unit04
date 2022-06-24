using Raylib_cs;
using unit04_greed.Game.Casting;


namespace unit04_greed.Game.Services
{
        public class KeyboardService
    {
        private int cellSize = 15;

       
        /// <param name="cellSize">The cell size (in pixels).</param>
        public KeyboardService(int cellSize)
        {
            this.cellSize = cellSize;
        }

        
        /// <returns>The direction as an instance of Point.</returns>
        public Point GetDirection()
        {
            int dx = 0;
            int dy = 0;

            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
            {
                dx = -1;
            }

            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
            {
                dx = 1;
            }


            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }

        /// <returns>The direction as an instance of Point.</returns>
        public Point MoveArtifact()
        {
            int dx = 0;
            int dy = 1;

            Point direction = new Point(dx, dy);
            direction = direction.Scale(cellSize);

            return direction;
        }
    }
}