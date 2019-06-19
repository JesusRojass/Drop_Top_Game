using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{
	public int score = 0;
	private static Score instance; 
	public static Score Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<Score> ();
			}
			return Score.instance; 
		}
	}
	Text text;
	void Awake (){
		text = GetComponent <Text> ();
	}
	void Start (){
	}
	void Update (){
	}
	public void addScore(){
		score += 1;
		text.text = "Score: " + score;
	}
}