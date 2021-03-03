using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_capsule : MonoBehaviour
{
    public GameObject object1;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("spawnfn", 5, 2);
        //Destroy(object1);
    }

    void spawnfn()
    {
        x = Random.Range(-10, 10);
        y = Random.Range(0, 10);
        z = Random.Range(-10, 10);
        Instantiate(object1, new Vector3(x, y, z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
