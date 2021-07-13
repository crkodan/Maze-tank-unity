using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peluru : MonoBehaviour
{
    public Vector3 velocity;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, 3f);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.darah -= 1;
            getDarah.drh -= 1;
            if (player.darah <= 0)
            {
                Application.LoadLevel("Level 1");
            }
        }
    }
}
