using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    float moveHor, moveVer;
    public float speed;
    Vector3 movement;
    Rigidbody rigidbody1;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody1 = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Capsule"))
        {
            Destroy(collision.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        moveHor = Input.GetAxis("Horizontal");
        moveVer = Input.GetAxis("Vertical");
        movement = new Vector3(moveHor, 0.0f, moveVer);
        rigidbody1.AddForce(movement * speed);
    }
}
