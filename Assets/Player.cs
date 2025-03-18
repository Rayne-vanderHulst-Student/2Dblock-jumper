using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]


public class Player : MonoBehaviour
{
    Rigidbody2D rigidbody;
    public float JumpeForce = 10.0f;


    public bool isFalling = true;
    // Start is called before the first frame update
    public void Start()
    {

        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void Update()
    {
        if(!isFalling)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidbody.AddForce(Vector3.up * JumpeForce, ForceMode2D.Impulse);
            }
        }
        
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        print("on collision enter");
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isFalling = true;
        }

    }
}

