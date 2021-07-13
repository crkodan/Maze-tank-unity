using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float movementSpeed = 20.0f;
    public float turningSpeed = 50.0f;
    public float speed = 50.0f;
    public float force = 100.0f;
    public GameObject proj;
    public Transform moncongPucuk;
    bool hasKey = false;
    public static int darah = 5;
    //public AudioSource audio;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
       
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
            
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            
            //audio.Play();
        }
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, vertical);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Key")
        {
            Destroy(other.gameObject);
            hasKey = true;
            getScore.value += 10;
        }
        
      
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "LockedDoor" && hasKey == true)
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "win")
        {
            Application.LoadLevel("level2");
            //Debug.Log("akhir");
        }
        if (other.gameObject.tag == "instruksi")
        {
            Destroy(other.gameObject);
        }
    }
    void Fire()
    {
        GameObject p = Instantiate(proj, moncongPucuk.transform.position, Quaternion.identity) as GameObject;
        p.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        Destroy(p, 5.0f);
    }
}
