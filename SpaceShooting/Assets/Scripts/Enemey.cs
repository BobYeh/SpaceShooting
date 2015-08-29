using UnityEngine;
using System.Collections;

public class Enemey : MonoBehaviour {

	public GameObject bulletObject;
	public float waitTime=-1f;
	public float intervalTime = 2.5f;
	public GameObject hitEffectObject;


	// Use this for initialization
	void Start () 
	{
		Destroy (this.gameObject, 5);
	}
	
	// Update is called once per frame
	void Update () 
	{
		waitTime += Time.deltaTime;
		if (waitTime >= intervalTime) 
		{
			Vector3 vecBulletPos = new Vector3(transform.position.x,transform.position.y,transform.position.z-2);
			vecBulletPos += (transform.rotation * Vector3.back);
			Instantiate (bulletObject, vecBulletPos, transform.rotation);
			waitTime = 0.0f;
		}
	}

	private		void	OnTriggerEnter( Collider other) 
	{
		if (other.tag == "Bullet") 
		{
			GameControl.control.Add(30);
			if( null!=hitEffectObject) 
			{
				Instantiate( hitEffectObject, transform.position, transform.rotation);
			}
			Destroy( this.gameObject);
		}
	}
}
