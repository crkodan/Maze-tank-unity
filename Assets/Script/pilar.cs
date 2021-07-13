using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pilar : MonoBehaviour
{
    GameObject player;
    public GameObject key;
    public int health = 5;
    private Rigidbody rigidbody;
    public GameObject partsis;
    public GameObject moncong;
    public GameObject bola;
    public float force;
    public float vz = 5;
    public float vy = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = moncong.transform.position;
        
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) <= 100.0f)
        {
            var bolalempar = Instantiate(bola, position, Quaternion.identity) as GameObject;
            bolalempar.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(0, vy, vz) * force, ForceMode.Impulse);
            Destroy(bolalempar, 5.0f);
        }
    }
}
