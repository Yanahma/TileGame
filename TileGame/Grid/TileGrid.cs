namespace TileGame.Grid
{
   using System;
   using System.Drawing;
   using System.Windows.Forms;

   /// <summary>
   /// Class to hold the contents of the game grid
   /// </summary>
   public class TileGrid
   {
      //
      // Private members
      //
      private PictureBox pb;
      private int cellWidth, cellHeight, size;
      private TileCell[,] grid;

      //
      // Public members
      //
      public int TotalMoves;
      public bool Solved = false;

      //
      // Constructor
      //
      public TileGrid (PictureBox pb, int size)
      {
         this.pb = pb;
         this.size = size;

         // Generate a new grid of desired size
         grid = new TileCell[size, size];
         for (var x = 0; x < grid.GetLength(0); x++)
         {
            for (var y = 0; y < grid.GetLength(0); y++)
            {
               var thisValue = (y*size) + (x+1);
               grid[x, y] = new TileCell(CellType.Tile, thisValue);
            }
         }
         // Bottom right is always empty square
         grid[size - 1, size - 1] = new TileCell(CellType.Empty, 0);

         // Scramble the grid
         ScrambleGrid(new Point(size - 1, size - 1));

         // The -6 is there so that borders display correctly (it is dirty though)
         cellWidth = (pb.Width - 6) / size;
         cellHeight = (pb.Height - 6) / size;
      }

      // Update method
      public void Update(Point mouseClickPosition)
      {
         if (!(Solved)) // Only update if we aren't already solved
         {
            // Figure out actual array positions for area clicked
            int xPosClicked = (int)Math.Floor((double)(mouseClickPosition.X / (pb.Width / size)));
            int yPosClicked = (int)Math.Floor((double)(mouseClickPosition.Y / (pb.Height / size)));

            // Attempt to move this square
            if (AttemptMove(xPosClicked, yPosClicked))
               TotalMoves++;

            // Check if this grid is now solved
            Solved = CheckSolved();
         }
      }

      // Draw method
      public void Draw()
      {
         // Create an image that fits the picturebox
         var image = new Bitmap(pb.Width, pb.Height);
         using (var g = Graphics.FromImage(image))
         {
            // First, fill the entire background with white
            var background = new Rectangle(0, 0, image.Width, image.Height);
            g.FillRectangle(new SolidBrush(Color.White), background);
            
            // Next, loop through every square
            for(var x = 0; x < size; x++)
            {
               for(var y = 0; y < size; y++)
               {
                  // If this square isn't empty, draw the value of the cell
                  if (!(grid[x, y].IsEmpty))
                  {
                     g.DrawString(grid[x, y].value.ToString(), GetFont(), Brushes.Black, GetPoint(x, y));
                  }

                  // Otherwise, fill it with a grey/silver color to show it is empty
                  else
                  {
                     g.FillRectangle(Brushes.Silver, GetRectangle(x, y));
                  }

                  // Draw square outline
                  g.DrawRectangle(Pens.Black, GetRectangle(x, y));
               }
            }
         }

         // Finally, populate picturebox with this image
         pb.Image = image;
      }

      // Scamble the grid
      private void ScrambleGrid(Point emptyPos)
      {
         var rand = new Random((int)DateTime.Now.Ticks);
         for(var loop = 0; loop < 1000; loop++)
         {
            int next = rand.Next(0,4);
            switch (next)
            {
               case 0: // Attempt to move the block to the left
                  if (AttemptMove(emptyPos.X - 1, emptyPos.Y))
                     emptyPos.X -= 1;
                  break;
               case 1: // Attempt to move the block to the right
                  if (AttemptMove(emptyPos.X + 1, emptyPos.Y))
                     emptyPos.X += 1;
                  break;
               case 2: // Attempt to move the block above
                  if (AttemptMove(emptyPos.X, emptyPos.Y - 1))
                     emptyPos.Y -= 1;
                  break;
               case 3: // Attempt to move the block below
                  if (AttemptMove(emptyPos.X, emptyPos.Y + 1))
                     emptyPos.Y += 1;
                  break;   
            }
         }
      }

      // Used to make a move on the clicked square
      private bool AttemptMove(int xPos, int yPos)
      {
         // Check that positions are in bounds (Lazy, only applicable from ShuffleGrid)
         if (yPos > size - 1
            || yPos < 0
            || xPos > size - 1
            || xPos < 0)
            return false;

         // Check above
         if(yPos > 0)
         {
            if (grid[xPos, yPos - 1].IsEmpty)
            {
               SwapCells(new Point(xPos, yPos), new Point(xPos, yPos - 1));
               return true;
            }
         }

         // Check Below
         if (yPos < size - 1)
         {
            if (grid[xPos, yPos + 1].IsEmpty)
            {
               SwapCells(new Point(xPos, yPos), new Point(xPos, yPos + 1));
               return true;
            }
         }

         // Check Left
         if (xPos > 0)
         {
            if (grid[xPos - 1, yPos].IsEmpty)
            {
               SwapCells(new Point(xPos, yPos), new Point(xPos - 1, yPos));
               return true;
            }
         }

         // Check Right
         if (xPos < size - 1)
         {
            if (grid[xPos + 1, yPos].IsEmpty)
            {
               SwapCells(new Point(xPos, yPos), new Point(xPos + 1, yPos));
               return true;
            }
         }

         // No move found, return false
         return false;
      }

      // Check if this puzzle is solved (all numbers in correct place)
      private bool CheckSolved()
      {
         for (var x = 0; x < grid.GetLength(0); x++)
         {
            for (var y = 0; y < grid.GetLength(0); y++)
            {
               var thisValue = (y*size) + (x+1);
               if (!(grid[x, y].value == thisValue || grid[x, y].IsEmpty))
                  return false;
            }
         }
         return true;
      }

      // Swap the contents of two cells on the grid
      private void SwapCells(Point firstPos, Point secondPos)
      {
         var save = grid[firstPos.X,firstPos.Y];
         grid[firstPos.X, firstPos.Y] = grid[secondPos.X, secondPos.Y];
         grid[secondPos.X, secondPos.Y] = save;
      }

      // Return a correctly sized/positioned rectangle from a set of coordinates
      private Rectangle GetRectangle(int x, int y)
      {
         return new Rectangle(x * cellWidth, y * cellHeight, cellWidth, cellHeight);
      }

      // Return a point in a rectangle from a set of coordinates
      private PointF GetPoint(int x, int y)
      {
         return new PointF(x * cellWidth, y * cellHeight);
      }

      // Return the font
      private Font GetFont()
      {
         return new Font(FontFamily.GenericSansSerif, Math.Min(cellWidth, cellHeight) / 2.5f, FontStyle.Regular);
      }
   }
}
