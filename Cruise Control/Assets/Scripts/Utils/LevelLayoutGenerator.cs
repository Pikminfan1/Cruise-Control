using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//THis is where the logic lives for building a 2D tiled grid.
//The chunks are picked based on the entry and exit vectors and are placed acordingly
public class LevelLayoutGenerator : MonoBehaviour
{
    public LevelChunkData[] levelChunkData;
    //public GameObject player;
    public LevelChunkData firstChunk;
    public GameObject removewall;
    private LevelChunkData previousChunk;

    public Vector3 spawnOrigin;

    private Vector3 spawnPosition;
    public int chunksToSpawn = 10;

    public int sizeofPool = 10;

    public static List<PoolEntry> pool = new List<PoolEntry>();

    void OnEnable()
    {
        TriggerExit.OnChunkExited += PickAndSpawnChunk;
    }

    private void OnDisable()
    {
        
        TriggerExit.OnChunkExited -= PickAndSpawnChunk;
    }

    //Debug Function, Press T to spawn Chunks
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            PickAndSpawnChunk();
        }

    }

    private void Start()
    {
        previousChunk = firstChunk;

        for(int i = 0; i < chunksToSpawn; i++)
        {
            PickAndSpawnChunk();

        }
        safetyBool = true;
    }
    //Hacked this to add a wall at the start
    private bool safetyBool = false;
    LevelChunkData PickNextChunk()
    {
        if (safetyBool)
        {
            removewall.SetActive(false);
        }
        List<LevelChunkData> allowedChunkList = new List<LevelChunkData>();
        LevelChunkData nextChunk = null;

        LevelChunkData.Direction nextRequiredDirection = LevelChunkData.Direction.North;

        switch (previousChunk.exitDirection)
        {
            case LevelChunkData.Direction.North:
                nextRequiredDirection = LevelChunkData.Direction.South;
                spawnPosition = spawnPosition + new Vector3(0, 0, previousChunk.chunkSize.y);
                break;
            case LevelChunkData.Direction.East:
                nextRequiredDirection = LevelChunkData.Direction.West;
                spawnPosition = spawnPosition + new Vector3(previousChunk.chunkSize.x, 0, 0);
                break;
            case LevelChunkData.Direction.South:
                nextRequiredDirection = LevelChunkData.Direction.North;
                spawnPosition = spawnPosition + new Vector3(0, 0, -previousChunk.chunkSize.y);
                break;
            case LevelChunkData.Direction.West:
                nextRequiredDirection = LevelChunkData.Direction.East;
                spawnPosition = spawnPosition + new Vector3(-previousChunk.chunkSize.x, 0, 0);
                break;
            default:
                break;
        }
        //Debug.Log("Next: "+nextRequiredDirection);

        for(int i = 0; i < levelChunkData.Length; i++)
        {
            if (levelChunkData[i].entryDirection == nextRequiredDirection)
            {
                //Debug.Log("True - " + i);
                allowedChunkList.Add(levelChunkData[i]);
            }
            else;// Debug.Log("False");
            
        }

        nextChunk = allowedChunkList[Random.Range(0, allowedChunkList.Count)];
       // Debug.Log(nextChunk);
        return nextChunk;
    }

    void PickAndSpawnChunk()
    {
        // Debug.Log("Spawning Chunk");
        LevelChunkData chunkToSpawn = PickNextChunk();
        GameObject objectFromChunk = chunkToSpawn.levelChunks[Random.Range(0, chunkToSpawn.levelChunks.Length)];
        previousChunk = chunkToSpawn;
        int index = ObjectPoolIndex(objectFromChunk);
        if (index >= 0) //Object is in pool
        {
            //If it's in the pool, grab it out, move it where it needs to be, and then reactivate it.
            GameObject reactivateObject = TakeFromPool(index);
            reactivateObject.transform.position = spawnPosition + spawnOrigin;
            reactivateObject.SetActive(true);
        }
        else
        {
            Instantiate(objectFromChunk, spawnPosition + spawnOrigin, Quaternion.identity);
        }

    }

    public void UpdateSpawnOrigin(Vector3 orginDelta)
    {
        spawnOrigin = spawnOrigin + orginDelta;
    }

    //Creates a new PoolEntry and adds it to the pool
    //TODO: Add a length cap on the object pool
    //TODO: Add pool sorting so that searches can be more efficient
    public static void AddToPool(GameObject go)
    {
        PoolEntry newEntry;
        newEntry.go = go;
        newEntry.tag = go.GetComponent<TileTag>();
        pool.Add(newEntry);
    }

    private static GameObject TakeFromPool(int index)
    {
        PoolEntry e = pool[index];
        pool.RemoveAt(index);
        return e.go;
    }

    //Searches through pool. If it finds a game object that matches go, returns its index. Otherwise returns -1.
    private int ObjectPoolIndex(GameObject go)
    {
        TileTag tag = go.GetComponent<TileTag>();
        int index = 0;
        foreach(PoolEntry e in pool)
        {
            if (e == tag) return index;
            index++;
        }
        return -1;
    }

    /*  Wrapper class for GameObject/TileTag pairs. This is because I have to assume GetComponent is pretty costly
        so I dont want to have us constantly calling it. So, it just needs to get called once or twice per tile.
        Also has == operators for Entry==TileTag and vice versa just to make things a bit easier.
    */
    public struct PoolEntry
    {
        public GameObject go;
        public TileTag tag;

        public static bool operator==(PoolEntry e, TileTag t)
        {
            if (e.tag == t) return true;
            return false;
        }
        public static bool operator !=(PoolEntry e, TileTag t) { return !(e == t); }

        public static bool operator ==(TileTag t, PoolEntry e)
        {
            if (e.tag == t) return true;
            return false;
        }
        public static bool operator !=(TileTag t, PoolEntry e) { return !(t == e);  }

        public static bool operator ==(PoolEntry e, PoolEntry e2)
        {
            if (e.tag == e2.tag) return true;
            return false;
        }
        public static bool operator !=(PoolEntry e, PoolEntry e2) { return !(e == e2);  }
    };
}
