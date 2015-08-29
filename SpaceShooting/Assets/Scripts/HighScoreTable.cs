using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreTable : MonoBehaviour {

	private Text mText;

	void Start () 
	{
		mText = GetComponent<Text> ();
		ArrayList scores = GameControl.control.GetScores ();
		for(int i=0;i<=9;i++)
		{
			if(i<=scores.Count-1)
			{
				mText.text +=scores[i].ToString ()+"\r\n";
			}
			else
				mText.text +="0"+"\r\n";
		}
	}

	void Update () 
	{
	
	}
}
