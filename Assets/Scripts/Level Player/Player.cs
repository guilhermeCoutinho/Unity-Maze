using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    LevelData levelData;

    void Start ()
    {
        levelData = LevelLoader.Instance.LoadedLevelData;
    }

}
