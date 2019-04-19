using UnityEngine;

public class Player : MonoBehaviour
{
    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 300);
    public bool hasPowerUp = false;

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyUp("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        if(Input.GetKeyDown("left ctrl") && hasPowerUp){
            GetComponent<Weapon>().Shoot();
            hasPowerUp = false;
        }
       

        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }


    }

    void OnTriggerEnter2D(Collider2D other){
        
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
           if (other.gameObject.CompareTag("PowerUp"))
        {
            print("Powered");
            hasPowerUp = true;
            Destroy(other.gameObject);
        }
            else{
            Die();
        }
    }

    void Die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}