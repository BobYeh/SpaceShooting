using UnityEngine;
using System.Collections;

public class EnemeyBullect : MonoBehaviour {

	public float moveSpeed = 10.0f;

	public GameObject hitEffectPrefab = null;
	
	void Update () 
	{
		Vector3 vecAddPos = Vector3.back * moveSpeed;
		transform.position += transform.rotation * vecAddPos * Time.deltaTime;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Player") {
			return;
		}

		if (hitEffectPrefab != null) {
			Instantiate( hitEffectPrefab, transform.position, transform.rotation);
		}

		Destroy (gameObject);
	}
}
