using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject player;
    int thrust = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            Debug.Log("Pressed");
            rb.AddForce(0, 0, thrust, ForceMode.Impulse);
            player.GetComponent<Animator>().Play("Kick");

        }
       
    }
}
