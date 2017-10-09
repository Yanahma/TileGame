using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileGame.Grid
{
   /// <summary>
   /// Struct to hold the value of the
   /// </summary>
   public struct TileCell
   {
      public CellType type;
      public int value;

      public bool IsEmpty
      {
         get { return type == CellType.Empty; }
      }

      public TileCell(CellType type, int value)
      {
         this.type = type;
         this.value = value;
      }
   }
}
