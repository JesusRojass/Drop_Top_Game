using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDEKLEL : MonoBehaviour {
	void Start () {
		
	}
	void Update () {
		
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			ControlObj.Instance.SpawnStuff ();
			Score.Instance.addScore ();
		}
	}
}
