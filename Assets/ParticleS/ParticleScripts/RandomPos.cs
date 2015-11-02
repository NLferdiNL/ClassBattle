using UnityEngine;
using System.Collections;

public class RandomPos : MonoBehaviour {
	[SerializeField]
	private GameObject _parent;
	private float _xpos = 0;
	private float _ypos = 3.5f;
	private float _zpos = 0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		RandomisePos ();
	}

	void RandomisePos(){
		float newXpos = _xpos + Random.Range (-.1f, .1f);;
		float newYpos = _ypos + Random.Range (-.1f, .1f);;
		float newZpos = _zpos + Random.Range (-.1f, .1f);;
		transform.position = new Vector3 (_parent.transform.position.x + newXpos,_parent.transform.position.y +  newYpos,_parent.transform.position.z +  newZpos);
	}
}
