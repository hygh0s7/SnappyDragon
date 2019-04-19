using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {
	 public Vector2 velocity = new Vector2(5, 0);

	// Use this for initialization
 void Start()
    {
        GetComponent<Rigidbody2D>().velocity = velocity;
       
    }
	
	// Update is called once per frame
	void Update () {
	}
		  void OnCollisionEnter2D(Collision2D other)
    {
           if (other.gameObject.CompareTag("RockPair"))
        {
            print("destroyed fireball");
            Destroy(gameObject);
            
        }
	}

	

}
