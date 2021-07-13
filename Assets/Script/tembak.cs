using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tembak : MonoBehaviour {

    public float force;
    public float vz = 5;
    public float vy = 5;
    public AudioSource fire;

    public GameObject moncong;
    public GameObject bola;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = moncong.transform.position;
        if (Input.GetButtonDown("Fire2"))
        {
            var bolalempar = Instantiate(bola, position, Quaternion.identity) as GameObject;
            bolalempar.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(0, vy, vz) * force, ForceMode.Impulse);
            Destroy(bolalempar, 5.0f);
            fire.PlayOneShot(fire.clip);
        }
	}
}
