using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Vector3 spawnValues;
    public GameObject prefabSphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        if (gameObject.transform.position.y <= -3)
        {
            Destroy(gameObject);
            InstantiateSphere();
        }
    }
    void InstantiateSphere()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
        Instantiate(gameObject, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
    }
}
