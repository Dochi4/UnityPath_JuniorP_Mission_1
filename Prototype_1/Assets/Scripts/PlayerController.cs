using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; // inital vehicle speed 
    private float turnSpeed = 80.0f; // inital turn speed 
    private float horizontalInput; // initial horizontal input 
    private float forwardInput; // initial forward input 

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal"); // used basic horizontal movment input controls arrow keys and A,D move between -1 and 1 
        forwardInput = Input.GetAxis("Vertical");

        // Move The Vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Move the Vehicel negative left postive right - Rotates the object changeing the forward angel
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
