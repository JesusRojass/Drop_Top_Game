using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAMPLEIAPMANAGER : MonoBehaviour {

	public Transform rip;
	int addedCoins;
	public void failed(){
		rip.gameObject.SetActive (true);
	}
	public void noAdsYAY(){
		if (PlayerPrefs.HasKey ("ADS")) {
			failed ();
		} else {
			PlayerPrefs.SetInt ("ADS", 1);
			PlayerPrefs.Save ();
		}
	}
	public void yay100(){
		coinScript.Instance.coins += 100;
		PlayerPrefs.SetInt ("COINS", coinScript.Instance.coins);
		PlayerPrefs.Save ();
		coinScript.Instance.updateCoins ();
		//disable ads on every purchase
		if (PlayerPrefs.HasKey ("ADS")) {
			failed ();
		} else {
			PlayerPrefs.SetInt ("ADS", 1);
			PlayerPrefs.Save ();
		}
	}
}
