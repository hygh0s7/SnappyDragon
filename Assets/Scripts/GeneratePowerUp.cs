using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePowerUp : MonoBehaviour {
	public GameObject powerUp;

	// Use this for initialization
	void Start () {
		 InvokeRepeating("CreatePowerUp", 2f*Random.value*5, 1.5f*Random.value*15);

	}
	
  void CreatePowerUp()
    {
        Instantiate(powerUp);
    }

}
