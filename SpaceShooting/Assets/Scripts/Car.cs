using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

	public GameObject bulletObject;
	private float bulletOffset = 2.0f;

	CharacterController characterController;
	public float moveSpeed = 5.0f;
	public GameObject hitEffectObject;
	private MeshRenderer mRender;

	// Use this for initialization
	void Start () 
	{
		characterController = GetComponent<CharacterController> ();
		mRender = GetComponentInChildren<MeshRenderer> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 direction = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
		if((transform.position.x<3 && direction.x>0) || (transform.position.x>-3 && direction.x<0))
		characterController.Move (direction * moveSpeed * Time.deltaTime);

		if (Input.GetButtonDown ("Fire1")) {
			Vector3 vecBulletPos = new Vector3(transform.position.x,transform.position.y,transform.position.z+bulletOffset);
			vecBulletPos += (transform.rotation * Vector3.forward);
			Instantiate(bulletObject,vecBulletPos,transform.rotation);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemey" || other.tag == "EnemeyBullet") {
			if(hitEffectObject != null)
			{
				Instantiate( hitEffectObject, transform.position, transform.rotation);
			}
			mRender.enabled= false;
			GameControl.control.Save();
			Application.LoadLevel("GameOver");
			Destroy( this.gameObject);
		}
	}
}
