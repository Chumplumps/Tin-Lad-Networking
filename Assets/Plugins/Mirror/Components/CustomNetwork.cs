using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Mirror;
public class CustomNetwork : NetworkManager
{
    public override void OnServerConnect(NetworkConnection conn)
    {
        base.OnServerConnect(conn);

        // Spawn an instance of Pal onto client
        GameObject palPrefab = spawnPrefabs[0];
        GameObject pal = Instantiate(palPrefab, new Vector3(0, 2, 0), Quaternion.identity);
        NetworkServer.Spawn(pal);
    }
}
