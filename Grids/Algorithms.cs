using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grids
{
    public static class Algorithms
    {
        public static Cell[,] AStar(Grid grid)
        {
            Queue<Cell> watched = new Queue<Cell>();
            int[,] currentCost = new int[grid.CountN, grid.CountM];
            Cell[,] parent = new Cell[grid.CountN, grid.CountM];
            Dictionary<Cell, int> currentCostWatched = new Dictionary<Cell, int>();
            currentCostWatched[grid.Start] = 0;
            int[,] costWatched = new int[grid.CountN, grid.CountM];
            costWatched[grid.Start.Coordinates.X, grid.Start.Coordinates.Y] = 0;
            

            while (currentCostWatched.Count > 0)
            {
                Cell current = currentCostWatched.First().Key;
                int currentValue = currentCostWatched[current];
                currentCostWatched.Remove(current);
                watched.Enqueue(current);

                if (current == grid.Finish)
                    return parent;

                for (int i = Math.Max(0, current.Coordinates.X - 1); i <= Math.Min(grid.CountN - 1, current.Coordinates.X + 1); i++)
                {
                    for (int j = Math.Max(0, current.Coordinates.Y - 1); j <= Math.Min(grid.CountM - 1, current.Coordinates.Y + 1); j++)
                    {
                        if (current.Coordinates.X == i && current.Coordinates.Y == j)
                            continue;
                        if (current.Coordinates.X % 2 == 0 && i % 2 != 0 && j == current.Coordinates.Y + 1)
                            continue;
                        if (current.Coordinates.X % 2 != 0 && i % 2 == 0 && j == current.Coordinates.Y - 1)
                            continue;
                        bool isObs = false;
                        foreach (var obs in grid.Obstacles)
                            if (obs.Coordinates == current.Coordinates)
                                isObs = true;
                        if (isObs)
                            continue;

                        int newCost = currentValue + 1;
                        

                        if (watched.Contains(grid.Cells[i, j]) && newCost >= costWatched[i, j])
                            continue;
                        parent[i, j] = current;
                        currentCostWatched[grid.Cells[i, j]] = newCost;
                        costWatched[i, j] = newCost;
                        if (!currentCostWatched.ContainsKey(grid.Cells[i, j]))
                            currentCostWatched[grid.Cells[i, j]] = 0;
                        currentCostWatched = currentCostWatched.ToList().OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    }
                }
            }
            return null;
        }
    }
}
