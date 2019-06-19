using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//using UnityEngine.Advertisements;

public class Menus : MonoBehaviour {	
	private static Menus instance; 
	public static Menus Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<Menus> ();
			}
			return Menus.instance; 
		}
	}
	public float CountdownFrom;
	public Text textbox;
	public string ADVERTISEMENTORNAH = "ADS";
	public Transform canvas;
	public Transform bckgrnd;
	public Transform settings;
	public Transform main;
	public Transform count;
	public Transform riperino;
	public int lmaoooo = 0;
	public Slider volumen;
	public string VOLUMENKEY = "SVOL";
	void Start () {
		volumen.value = PlayerPrefs.GetFloat ("SVOL");
	}
	void Update () {
		countDownAfter ();
	}
	public void pausa(){
		if (canvas.gameObject.activeInHierarchy == false && bckgrnd.gameObject.activeInHierarchy == false) {
			canvas.gameObject.SetActive (true);
			bckgrnd.gameObject.SetActive (true);
			main.gameObject.SetActive (false);
			Time.timeScale = 0;
			AudioListener.volume = 0.25f;
		}
	}
	public void reanudar(){
		if (canvas.gameObject.activeInHierarchy == true && bckgrnd.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			bckgrnd.gameObject.SetActive (false);
			main.gameObject.SetActive (true);
			Time.timeScale = 1;
			PlayerPrefs.GetFloat ("SVOL");	
		}
	}
	public void reiniciar(){
		if (canvas.gameObject.activeInHierarchy == true || riperino.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			SceneManager.LoadScene ("Main");
			PlayerPrefs.GetFloat ("SVOL");	
		}
	}
	public void rageQuit(){
		if (canvas.gameObject.activeInHierarchy == true || riperino.gameObject.activeInHierarchy == true) {
			canvas.gameObject.SetActive (false);
			Time.timeScale = 1;
			SceneManager.LoadScene ("meme");
			PlayerPrefs.GetFloat ("SVOL");		
		}
	}
	public void opt(){
		if (settings.gameObject.activeInHierarchy == false) {
			settings.gameObject.SetActive (true);
			canvas.gameObject.SetActive (false);
			OnValueChanged ();
			PlayerPrefs.SetFloat ("SVOL", volumen.value);
			PlayerPrefs.Save ();
		}
	}
	public void OnValueChanged(){
		AudioListener.volume = volumen.value;
		PlayerPrefs.SetFloat ("SVOL", volumen.value);
		PlayerPrefs.Save ();
    }
	public void bacc (){
		if (settings.gameObject.activeInHierarchy == true) {
			settings.gameObject.SetActive (false);
			canvas.gameObject.SetActive (true);
		}
	}
	public void rip ()
	{
		riperino.gameObject.SetActive (true);
		Time.timeScale = 1;
		AudioListener.volume = 0.25f;
	}
		
	public void ShowAd()
	{
		/*if (PlayerPrefs.HasKey ("ADS")) {
			return;
		}
		int siTocaONel = Random.Range (0, 5);
		if (siTocaONel == 1 || siTocaONel == 3) {
			if (Advertisement.IsReady ()) {
				Advertisement.Show ();
			} else {
				return;
			}
		}*/
		return;
	}
	public void checcMaxScore(){
		Social.ShowLeaderboardUI();
	}
	public void returnToMenu(){
		SceneManager.LoadScene ("meme");
	}
	public void countDownAfter(){
		float time = CountdownFrom - Time.timeSinceLevelLoad;
		textbox.text = time.ToString("0.00");

		if(time<=0f) {
			lmaoooo += 1;
			count.gameObject.SetActive (false);
		}
	}
}
