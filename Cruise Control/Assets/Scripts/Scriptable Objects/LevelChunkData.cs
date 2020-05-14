using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This Scriptable object allows you to create levelchunks in the AssetMenu
//Its mostly just a fancy wrapper for the tiles which allows them to be placed at their required intervals appart from each other
//Including the dimensions and entrance and exit directions
[CreateAssetMenu(menuName ="LevelChunkData")]
public class LevelChunkData : ScriptableObject
{
    public enum Direction
    {
        North,East, South, West
    }

    public Vector2 chunkSize = new Vector2(10f, 10f);

    public GameObject[] levelChunks;
    public Direction entryDirection;
    public Direction exitDirection;
    public static List<GameObject> pool = new List<GameObject>(10);

}
