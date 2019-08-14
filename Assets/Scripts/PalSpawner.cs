using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mirror;

public class PalSpawner : NetworkBehaviour
{
    public GameObject palPrefab;
    public float spawnInterval = 1.0f;
    
    public override void OnStartServer()
    {
        InvokeRepeating("SpawnPal", this.spawnInterval, this.spawnInterval);
    }

    void SpawnPal()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-4.0f, 4.0f), this.transform.position.y, Random.Range(-4f, 4f));
        GameObject pal = Instantiate(palPrefab, spawnPosition, Quaternion.identity) as GameObject;
        NetworkServer.Spawn(pal);   
        Destroy(pal, 10);

    }
}
