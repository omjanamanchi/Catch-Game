using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaddleMovement : MonoBehaviour
{
    float velocity = 25f;
    int xBound = 35;
    int otherXBound = 80;
    int zBound = -125;
    int otherZBound = -150;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Paddle Movement
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(velocity * Vector3.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(velocity * Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(velocity * Vector3.forward * Time.deltaTime);
        }   
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))    
        {
            transform.Translate(velocity * Vector3.back * Time.deltaTime);
        }
        

      // Boundaries
        if(transform.position.x < xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
        if(transform.position.x > otherXBound)
        {
            transform.position = new Vector3(otherXBound, transform.position.y, transform.position.z);
        }
        if(transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        if(transform.position.z < otherZBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, otherZBound);
        }

    }

}
