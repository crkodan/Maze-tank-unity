using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bedhil : MonoBehaviour
{
    public GameObject peluru;
    public GameObject moncong;
    public float fireRate;
    float timer;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnObject", 1, fireRate);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObject()
    {
        for (int i = 0; i < 2; i++)
        {
            Instantiate(peluru, moncong.transform.position, Quaternion.identity);
        }

    }
}
