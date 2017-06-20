using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour {

    const string FILE_NAME = "Level ";
    public int level;
    public ObjectPool pool;

    void Start ()
    {
        LoadLevel();
    }

    void LoadLevel ()
    {
        int colCount= 0;
        List<int> data;
        data = CSVParser.ParseCSV(FILE_NAME + level + ".csv", out colCount);

       
        int width = colCount;
        int height = data.Count / colCount;

        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
               if (data[i * width + j] > 0)
                {
                    GameObject go = pool.getObject();
                    go.transform.name = "" + data[i*width+j];
                    go.transform.position = new Vector3( j -width/2, (height-1- i) -height/2 , 0);
                }
            }
        }

    }


}
