using System;
using System.Drawing;
using System.Windows.Forms;

namespace TileGame
{
   using Grid;
   public partial class Main : Form
   {
      private TileGrid mainGrid;

      public Main()
      {
         InitializeComponent();

         // Display a blank grid
         mainGrid = new TileGrid(pbGrid, 1);
         mainGrid.Draw();
      }

      // When the grid (pictureboard) is clicked, update the board
      private void pbGrid_Click(object sender, EventArgs e)
      {
         MouseEventArgs a = (MouseEventArgs)e;
         mainGrid.Update(new Point(a.X, a.Y));

         // Update Total Moves Counter, draw the grid
         lblTotalMovesCount.Text = mainGrid.TotalMoves.ToString();
         mainGrid.Draw();

         // If solved, display congratulations banner
         if (mainGrid.Solved)
            lblCongratulations.Visible = true;
      }

      // When the scramble button is clicked, create a new board of selected size
      private void btnScramble_Click(object sender, EventArgs e)
      {
         mainGrid = new TileGrid(pbGrid, (int)nudGridSize.Value);

         // Reset Total Moves Counter, hide congratulations, draw the grid
         lblTotalMovesCount.Text = "0";
         lblCongratulations.Visible = false;
         mainGrid.Draw();
      }
   }
}
