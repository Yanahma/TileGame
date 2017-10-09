namespace TileGame
{
   partial class Main
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.pbGrid = new System.Windows.Forms.PictureBox();
         this.btnScramble = new System.Windows.Forms.Button();
         this.nudGridSize = new System.Windows.Forms.NumericUpDown();
         this.lblGridSize = new System.Windows.Forms.Label();
         this.lblMoves = new System.Windows.Forms.Label();
         this.lblTotalMovesCount = new System.Windows.Forms.Label();
         this.lblCongratulations = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).BeginInit();
         this.SuspendLayout();
         // 
         // pbGrid
         // 
         this.pbGrid.Location = new System.Drawing.Point(80, 40);
         this.pbGrid.Margin = new System.Windows.Forms.Padding(0);
         this.pbGrid.Name = "pbGrid";
         this.pbGrid.Padding = new System.Windows.Forms.Padding(5);
         this.pbGrid.Size = new System.Drawing.Size(480, 480);
         this.pbGrid.TabIndex = 0;
         this.pbGrid.TabStop = false;
         this.pbGrid.Click += new System.EventHandler(this.pbGrid_Click);
         // 
         // btnScramble
         // 
         this.btnScramble.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnScramble.Location = new System.Drawing.Point(12, 543);
         this.btnScramble.Name = "btnScramble";
         this.btnScramble.Size = new System.Drawing.Size(152, 38);
         this.btnScramble.TabIndex = 1;
         this.btnScramble.Text = "Scramble";
         this.btnScramble.UseVisualStyleBackColor = true;
         this.btnScramble.Click += new System.EventHandler(this.btnScramble_Click);
         // 
         // nudGridSize
         // 
         this.nudGridSize.Location = new System.Drawing.Point(265, 556);
         this.nudGridSize.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
         this.nudGridSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
         this.nudGridSize.Name = "nudGridSize";
         this.nudGridSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
         this.nudGridSize.Size = new System.Drawing.Size(36, 22);
         this.nudGridSize.TabIndex = 1;
         this.nudGridSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
         // 
         // lblGridSize
         // 
         this.lblGridSize.AutoSize = true;
         this.lblGridSize.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblGridSize.Location = new System.Drawing.Point(170, 554);
         this.lblGridSize.Name = "lblGridSize";
         this.lblGridSize.Size = new System.Drawing.Size(94, 24);
         this.lblGridSize.TabIndex = 3;
         this.lblGridSize.Text = "Grid Size: ";
         // 
         // lblMoves
         // 
         this.lblMoves.AutoSize = true;
         this.lblMoves.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMoves.Location = new System.Drawing.Point(386, 554);
         this.lblMoves.Name = "lblMoves";
         this.lblMoves.Size = new System.Drawing.Size(71, 24);
         this.lblMoves.TabIndex = 4;
         this.lblMoves.Text = "Moves:";
         // 
         // lblTotalMovesCount
         // 
         this.lblTotalMovesCount.AutoSize = true;
         this.lblTotalMovesCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotalMovesCount.Location = new System.Drawing.Point(451, 554);
         this.lblTotalMovesCount.Name = "lblTotalMovesCount";
         this.lblTotalMovesCount.Size = new System.Drawing.Size(20, 24);
         this.lblTotalMovesCount.TabIndex = 5;
         this.lblTotalMovesCount.Text = "0";
         // 
         // lblCongratulations
         // 
         this.lblCongratulations.AutoSize = true;
         this.lblCongratulations.BackColor = System.Drawing.Color.Transparent;
         this.lblCongratulations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.lblCongratulations.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblCongratulations.ForeColor = System.Drawing.Color.Red;
         this.lblCongratulations.Location = new System.Drawing.Point(42, 235);
         this.lblCongratulations.Name = "lblCongratulations";
         this.lblCongratulations.Size = new System.Drawing.Size(568, 97);
         this.lblCongratulations.TabIndex = 6;
         this.lblCongratulations.Text = "Congratulations";
         this.lblCongratulations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         this.lblCongratulations.Visible = false;
         // 
         // Main
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(622, 593);
         this.Controls.Add(this.lblCongratulations);
         this.Controls.Add(this.lblTotalMovesCount);
         this.Controls.Add(this.lblMoves);
         this.Controls.Add(this.lblGridSize);
         this.Controls.Add(this.nudGridSize);
         this.Controls.Add(this.btnScramble);
         this.Controls.Add(this.pbGrid);
         this.Name = "Main";
         this.Text = "Tile Game";
         ((System.ComponentModel.ISupportInitialize)(this.pbGrid)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.nudGridSize)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pbGrid;
      private System.Windows.Forms.Button btnScramble;
      private System.Windows.Forms.NumericUpDown nudGridSize;
      private System.Windows.Forms.Label lblGridSize;
      private System.Windows.Forms.Label lblMoves;
      private System.Windows.Forms.Label lblTotalMovesCount;
      private System.Windows.Forms.Label lblCongratulations;
   }
}

