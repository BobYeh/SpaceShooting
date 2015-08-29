using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject enemeyPrefab;
	public float interval=1.5f;
	public float offsetX = 5.0f;

	// Use this for initialization
	IEnumerator Start () 
	{
		while (true) 
		{
			Instantiate(enemeyPrefab,
			            new Vector3(Random.Range(-offsetX,offsetX),transform.position.y,transform.position.z)
			            ,transform.rotation);
			yield return new WaitForSeconds(interval);
		}
	}
}
