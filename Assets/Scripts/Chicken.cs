using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public GameObject eggPrefab;
    public Transform spawnPoint;
    public float dropTime = 2f;

    void Start()
    {
        InvokeRepeating("DropEgg", dropTime, dropTime);
    }

    void DropEgg()
    {
        Instantiate(eggPrefab, spawnPoint.position, Quaternion.identity);
    }
}
