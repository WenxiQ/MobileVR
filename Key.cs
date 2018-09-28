using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject door;

	//public int keyCollected = 0;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		Object.Instantiate(keyPoof, transform.position, Quaternion.Euler(-90f, 0, 0f));
        // Make sure the poof animates vertically

        // Call the Unlock() method on the Door
		//GameObject.Find("Door").SendMessage ("Unlock()");
		door.GetComponent<Door>().Unlock();  // Marked!! Took me some time to get it right!

        // Set the Key Collected Variable to true
		//keyCollected  = true;
        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
