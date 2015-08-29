using UnityEngine;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {
 
	public static GameControl control;
	private ArrayList scoreList;

	// Use this for initialization
	void Start () 
	{
		if (control == null) 
		{
			DontDestroyOnLoad (gameObject);
			control = this;
			Load();
		} 
		else if (control != this) 
		{
			Destroy(gameObject);
		}
	}

	public int score {
		get;
		private set;
	}
	
	public void Add(int addScore)
	{
		score += addScore;
	}
	
	public void Reset()
	{
		score = 0;
	}

	public ArrayList GetScores()
	{
		return scoreList;
	}

	public void Save()
	{
			scoreList.Add(score);
			scoreList.Sort();
			scoreList.Reverse();
			if(scoreList.Count == 11)
				scoreList.RemoveAt(10);
			BinaryFormatter bf = new BinaryFormatter();
			using (var stream = File.Open (Application.persistentDataPath + "/playerInfo.dat",FileMode.OpenOrCreate)) 
			{
				bf.Serialize (stream, scoreList);
			}
			Reset ();
	}

	public void Load()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		using (var stream = File.Open (Application.persistentDataPath + "/playerInfo.dat",FileMode.OpenOrCreate)) {
			if(stream.Length != 0)
			{
				scoreList = (ArrayList)bf.Deserialize (stream);
			}
			else if (scoreList == null)
				scoreList = new ArrayList ();
		}
	}
}