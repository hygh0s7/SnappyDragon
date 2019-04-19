using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-4, 0);
    public Vector2 downForce = new Vector2(0, -300);
    public float range = 4;


    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
        
       
    }
       void OnCollisionEnter2D(Collision2D other)
    {
           if (other.gameObject.CompareTag("Fireball"))
        {
            print("destroyed");
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(downForce);
             Destroy(gameObject);

        }
}

 }