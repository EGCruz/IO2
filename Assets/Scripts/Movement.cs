using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    public bool isGrounded = false;
    public bool secondJump = false;
    // Start is called before the first frame update
    public bool dead = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dead == true){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        Jump();
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f );
        transform.position += move * Time.deltaTime * moveSpeed;

    }

    void Jump()
    {
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            secondJump = true;
        } else if(Input.GetButtonDown("Jump") && isGrounded == false && secondJump == true)  
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            secondJump = false;
        }  
    }
}
