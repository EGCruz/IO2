using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject IO;
    
    // Start is called before the first frame update
    void Start()
    {
        IO = gameObject.transform.parent.gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Floor")
            IO.GetComponent<Movement>().isGrounded = true;
            IO.GetComponent<Movement>().secondJump = false;
    }

    private void OnCollisionExit2D(Collision2D collision) 
    {
        if (collision.collider.tag == "Floor")
            IO.GetComponent<Movement>().isGrounded = false;    
    }
}
