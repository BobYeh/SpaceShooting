using UnityEngine;
using System.Collections;

public class CameraScripts : MonoBehaviour {

	public float speed = 20.0f;

	// Update is called once per frame
	void Update () 
	{
		Vector3 speedDirect = new Vector3 (0, 0, speed);
		transform.Translate(Vector3.forward*Time.deltaTime*speed,Space.World);
	}
}
