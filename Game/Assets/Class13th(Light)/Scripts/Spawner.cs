using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    private void Start()
    {
        prefab = Instantiate(Resources.Load<GameObject>("Pier"));
    }
}
