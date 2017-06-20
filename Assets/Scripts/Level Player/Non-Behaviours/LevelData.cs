using UnityEngine;
using System.Collections.Generic;
public class LevelData
{
    int[,] grid;
    int[,] Grid { get { return grid; } }

    public Vector2 playerPositionInGrid;
    public Vector2 endPositionInGrid;
    public List<Vector2> enemiesPositionInGrid;

    public LevelData(int rowCount, int colCount)
    {
        grid = new int[rowCount, colCount];
        enemiesPositionInGrid = new List<Vector2>();
    }

    public void setCell(int x, int y, int v)
    {
        if (v != (int)CellElement.Type.EMPTY)
            grid[x, y] = (int)CellElement.Type.FLOOR;
        else
            grid[x, y] = v;
        switch (v)
        {
            case (int)CellElement.Type.INITIAL_POSITION:
                playerPositionInGrid = new Vector2(x,y);
                break;
            case (int)CellElement.Type.ENEMY_POSITION:
                enemiesPositionInGrid.Add(new Vector2(x, y));
                break;
            case (int)CellElement.Type.END_POSITION:
                endPositionInGrid = new Vector2(x, y);
                break;
        }
    }

    public void printGrid()
    {
        string debug = "";
        for (int i = 0; i < grid.GetLength(0); i++)
        {
            for (int j = 0; j < grid.GetLength(1); j++)
            {
                debug += grid[i, j];
            }
            debug += "\n";
        }
        Debug.Log(debug);

    }

}