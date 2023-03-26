using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // the speed at which the player moves

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // get the horizontal input (left/right or A/D keys)
        float verticalInput = Input.GetAxis("Vertical"); // get the vertical input (forward/backward or W/S keys)

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput); // create a vector to represent the movement direction
        transform.Translate(movement * speed * Time.deltaTime); // move the player based on the input direction and the speed
    }
}
