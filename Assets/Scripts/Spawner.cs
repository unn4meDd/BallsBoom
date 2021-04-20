using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject sphere;
    public Vector3 spawnValues;
    // Start is called before the first frame update
    void Start()
    {
        InstantiateSphere();
    }

    // Update is called once per frame
    void Update()
    {
        if (sphere.transform.position.y <= -3)
        {
            Destroy(sphere);
            InstantiateSphere();
        }
    }
    void InstantiateSphere()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
        Instantiate(sphere, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
    }
}
