using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Attacker_Spawner : MonoBehaviour {

    bool spawn = true;

    [SerializeField] Attacker[] attackerPrefabs;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;

    // Use this for initialization
    IEnumerator Start ()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
	}
    private void SpawnAttacker()
    {
        Spawn(attackerPrefabs[Random.Range(0, attackerPrefabs.Length)]);
    }

    private void Spawn(Attacker attackerToSpawn)
    {
        Attacker newAttacker = Instantiate
            (attackerToSpawn, transform.position, transform.rotation) 
            as Attacker;
        newAttacker.transform.parent = transform;
    }

    public void StopSpawning()
    {
        spawn = false;
    }

}
