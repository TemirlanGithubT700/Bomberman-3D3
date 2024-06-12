using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkObjectSpawner : MonoBehaviour
{
    public void SpawnChildNetworkObjects()
    {
        NetworkObject[] childNetworkObjects = GetComponentsInChildren<NetworkObject>(true);

        foreach (var childNetworkObject in childNetworkObjects)
        {
            if (!childNetworkObject.IsSpawned)
            {
                childNetworkObject.Spawn(true);
                Debug.Log("Spawned NetworkObject: " + childNetworkObject.name);
            }
        }
    }
}
