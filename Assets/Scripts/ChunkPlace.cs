using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChunkPlace : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Chunk[] chunkPrefab;
    [SerializeField] private Chunk firstChunkPrefab;
    [SerializeField] private int maxNumberOfChunks = 3;
    [SerializeField] private List<Chunk> chunkList = new List<Chunk>();

    private void Start()
    {
        Chunk firstChunk = Instantiate(firstChunkPrefab);
        chunkList.Add(firstChunk);
    }

    private void Update()
    {
        if (player.position.x > chunkList.Last().End.position.x - 17)
        {
            ChunkSpawner();
        }
        RemoveUnnecessaryChunks();
    }

    private void ChunkSpawner()
    {
        Chunk new—hunk = Instantiate(RandomChunk());
        NewChunkPosition(new—hunk);
        chunkList.Add(new—hunk);
    }

    private Chunk RandomChunk()
    {
        return chunkPrefab[Random.Range(0, chunkPrefab.Length)];
    }

    private void NewChunkPosition(Chunk new—hunk)
    {
        new—hunk.transform.position = chunkList.Last().End.position - new—hunk.Begin.localPosition;
    }

    private void RemoveUnnecessaryChunks()
    {
        if (chunkList.Count == maxNumberOfChunks)
        {
            Destroy(chunkList[0]);
            chunkList.RemoveAt(0);
        }
    }

}
