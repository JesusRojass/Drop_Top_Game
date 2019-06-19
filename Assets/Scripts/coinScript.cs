using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinScript : MonoBehaviour {
	private static coinScript instance; 
	public static coinScript Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<coinScript> ();
			}
			return coinScript.instance; 
		}
	}
	public int coins;
	int savings;
	public string coinsKey = "COINS";
	Text text;
	void Awake (){
		text = GetComponent <Text> ();
	}
	// Use this for initialization
	void Start () {
		coins = PlayerPrefs.GetInt(coinsKey,0);
		text.text = "Coins: " + coins;
		savings += coins;
	}
	// Update is called once per frame
	void Update () {
		addCoins ();
		lessThanZero ();
		updateCoins ();
	}
	public void addCoins(){
		if (Score.Instance.score > 0) {
			coins = Score.Instance.score / 7;
			coins += savings;
			PlayerPrefs.SetInt ("COINS", coins);
			PlayerPrefs.Save ();
			updateCoins ();
		}
	}
	public void updateCoins(){
		coins = PlayerPrefs.GetInt (coinsKey, 0);
		text.text = "Coins: " + coins;
	}
	public void lessThanZero(){
		if (coins < 0) {
			coins = 0;
			PlayerPrefs.SetInt ("COINS", coins);
			PlayerPrefs.Save ();
			coins = PlayerPrefs.GetInt (coinsKey, 0);
		}
	}
	public void buyItem(){
		coins -= 120;
		PlayerPrefs.SetInt ("COINS", coins);
		PlayerPrefs.Save ();
		coins = PlayerPrefs.GetInt (coinsKey, 0);
	}
}
