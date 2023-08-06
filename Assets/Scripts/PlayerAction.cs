using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{ 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Y"))
        {
            gameObject.GetComponent<Heroine>().enabled = true;
            gameObject.GetComponent<Animator>().enabled = true;
        }
        else if (Input.GetButtonDown("T"))
        {
            gameObject.GetComponent<Heroine>().enabled = false;
            gameObject.GetComponent<Animator>().enabled = false;
        }
    }
}
