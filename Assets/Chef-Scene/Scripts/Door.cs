using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {
	private Rigidbody rb;
	private float _forceAmount = 6f;
	private bool _doorIsOpen = false;
	
	void Awake()
	{
		//Get the rigidbody
		rb = GetComponent<Rigidbody> ();

	}

	void Update()
	{
		//Check if the player hits the door
		if (GameObject.Find("Player").GetComponent<PlayerMovement>().hittingDoor)
		{
			//Check if player presses E, and updates the door status
			if (Input.GetKeyDown (KeyCode.E)) 
			{
				if (_doorIsOpen) 
				{
					CloseDoor ();
					_doorIsOpen = false;
				} else if (!_doorIsOpen) 
				{
					OpenDoor ();
					_doorIsOpen = true;
				}
			}
		}
	}

	//Opens the door
	private void OpenDoor()
	{
		rb.AddForce (-transform.forward * _forceAmount, ForceMode.Impulse);
	}

	//Closes the door
	private void CloseDoor()
	{
		rb.AddForce (transform.forward * _forceAmount, ForceMode.Impulse);
	}
}
