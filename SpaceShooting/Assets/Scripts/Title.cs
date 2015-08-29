using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Title : MonoBehaviour {

	private Text mText;

	// Use this for initialization
	void Start () 
	{
		mText = GetComponent<Text> ();
		for(int i=1;i<=10;i++)
		{
			mText.text +=i.ToString()+"."+"\r\n";
		}
	}
}