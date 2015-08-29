using UnityEngine;
using System.Collections;

public class Bonus : MonoBehaviour {

	private AudioSource audioSource;
	private MeshRenderer mRender;

	// Use this for initialization
	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		mRender = GetComponentInChildren<MeshRenderer> ();
		Destroy (this.gameObject, 5);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			GameControl.control.Add(100);
			mRender.enabled = false;
			audioSource.Play();
		}
	}
}
