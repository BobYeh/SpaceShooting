using UnityEngine;
using System.Collections;

public class Bullet	: MonoBehaviour {

	private	static readonly	float bulletMoveSpeed= 30.0f;

	public	GameObject	hitEffectPrefab= null;						

	private	void Update() 
	{
		{
			Vector3	vecAddPos = (Vector3.forward*bulletMoveSpeed);
			transform.position += ((transform.rotation*vecAddPos)*Time.deltaTime);
		}
	}

	private	void OnTriggerEnter(Collider hitCollider) 
	{
		if (hitCollider.tag != "Enemey") 
		{
			return;
		}
		if( null!=hitEffectPrefab) 
		{
			Instantiate( hitEffectPrefab, transform.position, transform.rotation);
		}
		Destroy( gameObject);
	}
	
	
	
	
}
