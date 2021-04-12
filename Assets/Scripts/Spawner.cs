using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spheres;
    public Vector3 spawnValues;
    public float spawnWait;
    public int startWait;
    public bool stop;

    int randSphere;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while(!stop)
        {
            randSphere = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            Instantiate(spheres[randSphere], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);

            yield return new WaitForSeconds(spawnWait);
        }
    }
}
