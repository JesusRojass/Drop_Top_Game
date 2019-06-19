using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STORE : MonoBehaviour {

	public Material[] materials;
	public Renderer rend;
	public Transform uhoh;
	public Transform set;
	public Transform newitem;
	public float color;
	public string GREEN = "kush";
	public string CY = "cyan";
	public string OR = "orange";
	public string RED = "red";
	public string LEAN = "lean";
	public string PINK = "pink";
	public string YELL = "yellow";
	public string high = "high";
	public string BLACC = "blacc";
	public string SHINY = "shine";

	string ifown0 = "gy";
	string ifown1 = "cy";
	string ifown2 = "oy";
	string ifown3 = "ry";
	string ifown4 = "ly";
	string ifown5 = "py";
	string ifown6 = "yy";
	string ifown7 = "hy";
	string ifown8 = "by";
	string ifown9 = "sy";


	// Use this for initialization
	void Start () {
		/*rend = GetComponent<Renderer>();
		rend.enabled = true;*/
		Movimiento.Instance.renderBall ();
		PlayerPrefs.GetFloat ("kush");
		PlayerPrefs.GetFloat ("cyan");
		PlayerPrefs.GetFloat ("orange");
		PlayerPrefs.GetFloat ("red");
		PlayerPrefs.GetFloat ("lean");
		PlayerPrefs.GetFloat ("pink");
		PlayerPrefs.GetFloat ("yellow");
		PlayerPrefs.GetFloat ("high");
		PlayerPrefs.GetFloat ("blacc");
		PlayerPrefs.GetFloat ("shine");

		if (PlayerPrefs.HasKey ("kush")) {
			Movimiento.Instance.mater.sharedMaterial = materials [0];
		} else if (PlayerPrefs.HasKey ("cyan")){
			Movimiento.Instance.mater.sharedMaterial = materials [1];
		} else if (PlayerPrefs.HasKey ("orange")){
			Movimiento.Instance.mater.sharedMaterial = materials [2];
		} else if (PlayerPrefs.HasKey ("red")){
			Movimiento.Instance.mater.sharedMaterial = materials [3];
		} else if (PlayerPrefs.HasKey ("lean")){
			Movimiento.Instance.mater.sharedMaterial = materials [4];
		} else if (PlayerPrefs.HasKey ("pink")){
			Movimiento.Instance.mater.sharedMaterial = materials [5];
		} else if (PlayerPrefs.HasKey ("yellow")){
			Movimiento.Instance.mater.sharedMaterial = materials [6];
		} else if (PlayerPrefs.HasKey ("high")){
			Movimiento.Instance.mater.sharedMaterial = materials [7];
		} else if (PlayerPrefs.HasKey ("blacc")){
			Movimiento.Instance.mater.sharedMaterial = materials [8];
		} else if (PlayerPrefs.HasKey ("shine")){
			Movimiento.Instance.mater.sharedMaterial = materials [9];
		} 
	}
	
	// Update is called once per frame
	void Update () {
		if (materials.Length == 0)
			return;

		// assign it to the renderer

	}
	public void green(){
		if (PlayerPrefs.HasKey ("gy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[0];
			PlayerPrefs.SetInt ("kush", 1);
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [0];
			PlayerPrefs.SetInt ("kush", 1);
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("gy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void cyan(){
		if (PlayerPrefs.HasKey ("cy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[1];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.SetInt ("cyan", 1);
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [1];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.SetInt ("cyan", 1);
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("cy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void orange(){
		if (PlayerPrefs.HasKey ("oy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[2];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.SetInt ("orange", 1);
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [2];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.SetInt ("orange", 1);
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("oy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void red(){
		if (PlayerPrefs.HasKey ("ry")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[3];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.SetInt ("red", 1);
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [3];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.SetInt ("red", 1);
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("ry", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void lean(){
		if (PlayerPrefs.HasKey ("ly")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[4];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.SetInt ("lean", 1);
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [4];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.SetInt ("lean", 1);
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("ly", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void pink(){
		if (PlayerPrefs.HasKey ("py")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[5];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.SetInt ("pink", 1);
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [5];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.SetInt ("pink", 1);
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("py", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void yellow(){
		if (PlayerPrefs.HasKey ("yy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[6];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.SetInt ("yellow", 1);
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [6];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.SetInt ("yellow", 1);
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("yy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void highBlue(){
		if (PlayerPrefs.HasKey ("hy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[7];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.SetInt ("high", 1);
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [7];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.SetInt ("high", 1);
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("hy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void blacc(){
		if (PlayerPrefs.HasKey ("by")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[8];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.SetInt ("blacc", 1);
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [8];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.SetInt ("blacc", 1);
			PlayerPrefs.DeleteKey ("shine");
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("by", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
	public void shiny(){
		if (PlayerPrefs.HasKey ("sy")) {
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials[0];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.SetInt ("shine", 1);
			PlayerPrefs.Save ();
			set.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
		} else if (coinScript.Instance.coins >= 120) {
			coinScript.Instance.buyItem ();
			Movimiento.Instance.renderBall ();
			Movimiento.Instance.mater.sharedMaterial = materials [9];
			PlayerPrefs.DeleteKey ("kush");
			PlayerPrefs.DeleteKey ("cyan");
			PlayerPrefs.DeleteKey ("orange");
			PlayerPrefs.DeleteKey ("red");
			PlayerPrefs.DeleteKey ("lean");
			PlayerPrefs.DeleteKey ("pink");
			PlayerPrefs.DeleteKey ("yellow");
			PlayerPrefs.DeleteKey ("high");
			PlayerPrefs.DeleteKey ("blacc");
			PlayerPrefs.SetInt ("shine", 1);
			PlayerPrefs.Save ();
			newitem.gameObject.SetActive (true);
			Debug.Log ("color set!!!");
			PlayerPrefs.SetInt ("sy", 1);
			PlayerPrefs.Save ();
		} else if (coinScript.Instance.coins < 120) {
			uhoh.gameObject.SetActive (true);
		}
	}
}