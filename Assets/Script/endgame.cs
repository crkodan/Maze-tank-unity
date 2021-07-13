using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public int health = 10;
    public GameObject key;
    public GameObject parsis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Proj")
        {
            health -= 1;
            if (health <= 0)
            {
                Destroy(gameObject);
                Instantiate(key, gameObject.transform.position, Quaternion.identity);
                Instantiate(parsis, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
