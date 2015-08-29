using UnityEngine;
using System.Collections;

public class SceneChange : MonoBehaviour {

	public string nextSceneName;

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("Submit")){
			Application.LoadLevel(nextSceneName);
		}
	}
}
