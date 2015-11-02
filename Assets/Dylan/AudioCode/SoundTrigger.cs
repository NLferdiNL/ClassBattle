using UnityEngine;
using System.Collections;

public class SoundTrigger : MonoBehaviour {

	public AudioSource source;
	public AudioClip clip;

	public void Awake(){
		source = GetComponent<AudioSource> ();
	}
	public void OnTriggerEnter(Collider other){

	}
}
