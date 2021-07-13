using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {

    public Transform door;
    bool doorOpen = false;
    public ParticleSystem ps;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && doorOpen == false)
        {
            door.position -= new Vector3(0, 0, 50);
            doorOpen = true;
            ps.Stop();
        }
    }
}
