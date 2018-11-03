namespace Grids
{
    partial class GridApp
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddObstacle = new System.Windows.Forms.Button();
            this.buttonSetStartCell = new System.Windows.Forms.Button();
            this.SetFinish = new System.Windows.Forms.Button();
            this.labelGridSizeX = new System.Windows.Forms.Label();
            this.labelGridSizeY = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.buttonDrawGrid = new System.Windows.Forms.Button();
            this.buttonFindPath = new System.Windows.Forms.Button();
            this.cbGridType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 600);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // buttonAddObstacle
            // 
            this.buttonAddObstacle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddObstacle.Location = new System.Drawing.Point(616, 9);
            this.buttonAddObstacle.Name = "buttonAddObstacle";
            this.buttonAddObstacle.Size = new System.Drawing.Size(129, 23);
            this.buttonAddObstacle.TabIndex = 1;
            this.buttonAddObstacle.Text = "Add obstacle";
            this.buttonAddObstacle.UseVisualStyleBackColor = true;
            this.buttonAddObstacle.Click += new System.EventHandler(this.buttonAddObstacle_Click);
            // 
            // buttonSetStartCell
            // 
            this.buttonSetStartCell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetStartCell.Location = new System.Drawing.Point(616, 38);
            this.buttonSetStartCell.Name = "buttonSetStartCell";
            this.buttonSetStartCell.Size = new System.Drawing.Size(129, 23);
            this.buttonSetStartCell.TabIndex = 2;
            this.buttonSetStartCell.Text = "Set start cell";
            this.buttonSetStartCell.UseVisualStyleBackColor = true;
            this.buttonSetStartCell.Click += new System.EventHandler(this.buttonSetStartCell_Click);
            // 
            // SetFinish
            // 
            this.SetFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SetFinish.Location = new System.Drawing.Point(616, 67);
            this.SetFinish.Name = "SetFinish";
            this.SetFinish.Size = new System.Drawing.Size(129, 23);
            this.SetFinish.TabIndex = 3;
            this.SetFinish.Text = "Set finish cell";
            this.SetFinish.UseVisualStyleBackColor = true;
            this.SetFinish.Click += new System.EventHandler(this.SetFinish_Click);
            // 
            // labelGridSizeX
            // 
            this.labelGridSizeX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGridSizeX.AutoSize = true;
            this.labelGridSizeX.Location = new System.Drawing.Point(616, 100);
            this.labelGridSizeX.Name = "labelGridSizeX";
            this.labelGridSizeX.Size = new System.Drawing.Size(60, 13);
            this.labelGridSizeX.TabIndex = 4;
            this.labelGridSizeX.Text = "Grid size X:";
            // 
            // labelGridSizeY
            // 
            this.labelGridSizeY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGridSizeY.AutoSize = true;
            this.labelGridSizeY.Location = new System.Drawing.Point(616, 126);
            this.labelGridSizeY.Name = "labelGridSizeY";
            this.labelGridSizeY.Size = new System.Drawing.Size(60, 13);
            this.labelGridSizeY.TabIndex = 5;
            this.labelGridSizeY.Text = "Grid size Y:";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownX.Location = new System.Drawing.Point(682, 98);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownX.TabIndex = 6;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownY.Location = new System.Drawing.Point(682, 124);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownY.TabIndex = 7;
            // 
            // buttonDrawGrid
            // 
            this.buttonDrawGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDrawGrid.Location = new System.Drawing.Point(619, 150);
            this.buttonDrawGrid.Name = "buttonDrawGrid";
            this.buttonDrawGrid.Size = new System.Drawing.Size(129, 23);
            this.buttonDrawGrid.TabIndex = 8;
            this.buttonDrawGrid.Text = "Draw grid";
            this.buttonDrawGrid.UseVisualStyleBackColor = true;
            this.buttonDrawGrid.Click += new System.EventHandler(this.buttonDrawGrid_Click);
            // 
            // buttonFindPath
            // 
            this.buttonFindPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindPath.Location = new System.Drawing.Point(619, 179);
            this.buttonFindPath.Name = "buttonFindPath";
            this.buttonFindPath.Size = new System.Drawing.Size(129, 23);
            this.buttonFindPath.TabIndex = 9;
            this.buttonFindPath.Text = "Find path";
            this.buttonFindPath.UseVisualStyleBackColor = true;
            this.buttonFindPath.Click += new System.EventHandler(this.buttonFindPath_Click);
            // 
            // cbGridType
            // 
            this.cbGridType.FormattingEnabled = true;
            this.cbGridType.Items.AddRange(new object[] {
            "Hexagonal",
            "Square"});
            this.cbGridType.Location = new System.Drawing.Point(619, 208);
            this.cbGridType.Name = "cbGridType";
            this.cbGridType.Size = new System.Drawing.Size(129, 21);
            this.cbGridType.TabIndex = 10;
            // 
            // GridApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 616);
            this.Controls.Add(this.cbGridType);
            this.Controls.Add(this.buttonFindPath);
            this.Controls.Add(this.buttonDrawGrid);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.labelGridSizeY);
            this.Controls.Add(this.labelGridSizeX);
            this.Controls.Add(this.SetFinish);
            this.Controls.Add(this.buttonSetStartCell);
            this.Controls.Add(this.buttonAddObstacle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GridApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddObstacle;
        private System.Windows.Forms.Button buttonSetStartCell;
        private System.Windows.Forms.Button SetFinish;
        private System.Windows.Forms.Label labelGridSizeX;
        private System.Windows.Forms.Label labelGridSizeY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Button buttonDrawGrid;
        private System.Windows.Forms.Button buttonFindPath;
        private System.Windows.Forms.ComboBox cbGridType;
    }
}

