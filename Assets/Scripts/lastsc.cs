using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lastsc : MonoBehaviour {

	Text text;
	void Awake (){
		text = GetComponent <Text> ();
	}

	// Use this for initialization
	void Start () {
		text.text = "Score: " + Score.Instance.score;
	}

	// Update is called once per frame
	void Update () {

	}
}
