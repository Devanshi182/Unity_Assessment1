using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsule_colour_change : MonoBehaviour
{
    public Material[] materials1;
    public GameObject object1;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("change_colour", 5);
    }

    void change_colour()
    {
        //object1.GetComponent<Renderer>().material.color = materials1[Random.Range(0, materials1.Length)];
        MeshRenderer meshrend = GetComponent<MeshRenderer>();
        meshrend.material = materials1[Random.Range(0, materials1.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
