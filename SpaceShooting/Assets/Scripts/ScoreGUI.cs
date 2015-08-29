using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGUI : MonoBehaviour {

	private Text mText;

	// Use this for initialization
	void Start () 
	{
		mText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		int score = GameControl.control.score;
		string scoreAddZero = score.ToString("000");
		mText.text = "Score:" + scoreAddZero;
	}
}
