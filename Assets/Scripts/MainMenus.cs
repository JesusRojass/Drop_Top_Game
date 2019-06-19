using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenus : MonoBehaviour {	
	private static MainMenus instance; 
	public static MainMenus Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<MainMenus> ();
			}
			return MainMenus.instance; 
		}
	}
	int total;
	int itemOwnership;
	public Transform canvas;
	public Transform alreadyOwn;
	public Transform settings;
	public Transform store;
	public Transform uBroke;
	public Slider volumen;
	void Start(){
		coinScript.Instance.lessThanZero ();
		volumen.value = PlayerPrefs.GetFloat ("SVOL");
	}
	void Update () {
		
	}
	public void tiendaBalls(){
		if (canvas.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			store.gameObject.SetActive (true);
		}
	}
	public void back(){
		if (this.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (true);
			settings.gameObject.SetActive (false);
			store.gameObject.SetActive (false);
		}
	}
	public void config(){
		if (canvas.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			settings.gameObject.SetActive (true);
		}
	}
	public void TUTO(){
		SceneManager.LoadScene ("TUTO");
	}

	public void Ajuego(){
		SceneManager.LoadScene ("Main");
	}
	public void checcMaxScore(){
		
	}
	public void OnValueChanged(){
		AudioListener.volume = volumen.value;
		PlayerPrefs.SetFloat ("SVOL", volumen.value);
		PlayerPrefs.Save ();
	}
}
