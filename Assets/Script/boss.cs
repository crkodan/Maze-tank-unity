using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boss : MonoBehaviour {

    GameObject player;
    public GameObject key;
    public int health = 5;
    public float speed = 10.0f;
    private Rigidbody rigidbody;
    public GameObject partsis;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        rigidbody = GetComponent<Rigidbody>();
        //partsis.Stop();
	}
	
	// Update is called once per frame
	void Update () {
		if(Vector3.Distance(gameObject.transform.position, player.transform.position) <= 50.0f)
        {
            gameObject.transform.LookAt(player.transform);
            rigidbody.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
	}

    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Application.LoadLevel(Application.loadedLevel);
        }

        if(other.gameObject.tag == "Proj")
        {
            health -=1;
            Destroy(other.gameObject);
            

            if(health<= 0)
            {
                Destroy(gameObject);
                Instantiate(key,gameObject.transform.position, Quaternion.identity);
                Instantiate(partsis, gameObject.transform.position, Quaternion.identity);
            }
        }
    }
}
