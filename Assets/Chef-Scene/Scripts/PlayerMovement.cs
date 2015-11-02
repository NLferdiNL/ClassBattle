using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private Vector3 _newPosition;
	public Transform rayCheck;
	public bool hittingDoor = false;
	
	void Update () {
		Raycasting ();
		Movement ();
	}

	//Check if the player hits the door
	private void Raycasting()
	{
		Debug.DrawLine (this.transform.position, rayCheck.position, Color.green);
		
		hittingDoor = Physics.Linecast(this.transform.position, rayCheck.position, 1 << LayerMask.NameToLayer("Door"));
	}

	//Movement
	private void Movement()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");
		_newPosition = new Vector3 (x, 0f, z);
		transform.Translate(-_newPosition * 10f * Time.deltaTime);
	}
}
