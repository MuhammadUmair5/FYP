using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    Scene scene;

    private Rigidbody rb;
    private float spaceShipSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
        rb = GetComponent<Rigidbody>();
        Debug.Log("Active Scene is '" + scene.name + "'.");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            SceneManager.LoadScene(0);
            Debug.Log("Collided");
        }


    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 vel = rb.velocity;
        vel.x = h *4;
        vel.z = spaceShipSpeed;
        rb.velocity = vel;

    }
}
