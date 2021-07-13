using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDarah : MonoBehaviour
{
    Text darah;
    public static int drh = 5;
    // Start is called before the first frame update
    void Start()
    {
        darah = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        darah.text = "Health: " + drh;
    }
}
