using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms;
using GooglePlayGames;
using GooglePlayGames.BasicApi;

public class fpsmeme : MonoBehaviour {

	private static fpsmeme instance; 
	public static fpsmeme Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<fpsmeme> ();
			}
			return fpsmeme.instance; 
		}
	}
	void Awake(){
		if (Application.platform == RuntimePlatform.IPhonePlayer){
			Application.targetFrameRate = 60;
		}
		Movimiento.Instance.renderBall ();
	}
	// Use this for initialization
	void Start () {
		Movimiento.Instance.renderBall ();
	}
	
	// Update is called once per frame
	void Update () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
}
