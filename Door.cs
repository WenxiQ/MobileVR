using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
	bool opening = false;
	//public GameObject key;
	public AudioClip[] soundFiles;  // door lock and open sound clips
	public AudioSource soundSource; 

	void Start () {
		soundSource.clip = soundFiles [0]; // give a locked hint sound to the player  
		soundSource.Play();
	}

	void Update() {        
		// If the door is opening and it is not fully raised
			// Animate the door raising up
		if (opening == true && transform.position.y < 7.6f)  {
			transform.Translate (0f, 1f*Time.deltaTime, 0f, Space.World);
		
		}
	}
		
    public void OnDoorClicked() 
	{
		// If the door is clicked and unlocked
		// Set the "opening" boolean to true
		// (optionally) Else
		// Play a sound to indicate the door is locked 
		if (locked == true) {
			soundSource.Play (); // add door lock sound
		} else { 
			soundSource.clip = soundFiles [1]; // door opening sound
			soundSource.Play();
			opening = true;
		}

		Debug.Log ("is door lock? "+ locked);
		Debug.Log ("is door opening? "+ opening);

    }
    

	public void Unlock()
    {
		locked = false; // You'll need to set "locked" to false here
		//Debug.Log("Unlock with key. locked is :"+ locked);
		opening = false;
		//Debug.Log("Unlock with key. opening is :"+ opening);
    }
}
