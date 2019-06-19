using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;


public class BESTSCOREEVER : MonoBehaviour {
	

	Text text;
	public int highScore;
	string highScoreKey = "HighScore";
	private static BESTSCOREEVER instance; 
	public static BESTSCOREEVER Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<BESTSCOREEVER> ();
			}
			return BESTSCOREEVER.instance; 
		}
	}
	void Awake (){
		text = GetComponent <Text> ();
	}

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt(highScoreKey,0);
		text.text = "BEST " + highScore;
	}

	// Update is called once per frame
	void Update () {
		high ();
	}
	public void high(){
		if (Score.Instance.score > highScore){
			highScore = Score.Instance.score;
			PlayerPrefs.SetInt ("HighScore", highScore);
			PlayerPrefs.Save ();
			highScore = PlayerPrefs.GetInt(highScoreKey,0);
			text.text = "NEW BEST " + highScore;

		}
	}
	/*void ReportScore(long score, string leaderboardID)
	{
		Debug.Log("Reporting score " + score + " on leaderboard " + leaderboardID);
		Social.ReportScore(highScore, "BESTDROPTOPSCORE", success => {
			Debug.Log(success ? "Reported score successfully" : "Failed to report score");
		});
		Social.ShowLeaderboardUI();
	}*/
}
