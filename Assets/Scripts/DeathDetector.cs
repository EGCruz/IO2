using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathDetector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject IO;
    void Start()
    {
        IO = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "Enemy"){
            //SceneManager.LoadScene("Level 1");
            IO.GetComponent<Movement>().dead = true;
        }
    }
}
