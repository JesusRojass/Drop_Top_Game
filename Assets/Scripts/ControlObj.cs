using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ControlObj : MonoBehaviour {
	public GameObject currentTile;
	private Stack<GameObject> tiles = new Stack<GameObject>();
	private Stack<GameObject> tiles1 = new Stack<GameObject>();
	private Stack<GameObject> tiles2 = new Stack<GameObject>();
	private Stack<GameObject> tiles3 = new Stack<GameObject>();
	private Stack<GameObject> tiles4 = new Stack<GameObject>();
	private Stack<GameObject> tiles5 = new Stack<GameObject>();
	private Stack<GameObject> tiles6 = new Stack<GameObject>();
	private Stack<GameObject> tiles7 = new Stack<GameObject>();
	public GameObject[] objetosPrefabs;
	private static ControlObj instance; 
	public static ControlObj Instance{
		get { 
			if(instance == null){
				instance = GameObject.FindObjectOfType<ControlObj>();
			}
			return ControlObj.instance; 
		}
	}
	void Start () {
		createStuff (20);
		for(int i = 0; i < 20; i++){
			SpawnStuff ();
		}
	}
	void Update () {

	}
	public void createStuff(int amount){
		for (int i = 0; i < amount; i++) {
			tiles.Push (Instantiate(objetosPrefabs[0]));
			tiles.Peek().name = "memeys";
			tiles.Peek().SetActive(false);
			tiles1.Push (Instantiate(objetosPrefabs[1]));
			tiles1.Peek().name = "memeys1";
			tiles1.Peek().SetActive(false);
			tiles2.Push (Instantiate(objetosPrefabs[2]));
			tiles2.Peek().name = "memeys2";
			tiles2.Peek().SetActive(false);
			tiles3.Push (Instantiate(objetosPrefabs[3]));
			tiles3.Peek().name = "memeys3";
			tiles3.Peek().SetActive(false);
			tiles4.Push (Instantiate(objetosPrefabs[4]));
			tiles4.Peek().name = "memeys4";
			tiles4.Peek().SetActive(false);
			tiles5.Push (Instantiate(objetosPrefabs[5]));
			tiles5.Peek().name = "memeys5";
			tiles5.Peek().SetActive(false);
			tiles6.Push (Instantiate(objetosPrefabs[6]));
			tiles6.Peek().name = "memeys6";
			tiles6.Peek().SetActive(false);
			tiles7.Push (Instantiate(objetosPrefabs[7]));
			tiles7.Peek().name = "memeys7";
			tiles7.Peek().SetActive(false);
		}
	}
	public void SpawnStuff(){
		if (tiles.Count == 0 || tiles1.Count == 0 || tiles2.Count == 0 || tiles3.Count == 0 || tiles4.Count == 0 || tiles5.Count == 0 || tiles6.Count == 0 || tiles7.Count == 0) {
			createStuff (10);
		}
		int randomIndex = Random.Range (0,8);
		if (randomIndex == 0) {
			GameObject tmp = tiles.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 1) {
			GameObject tmp = tiles1.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 2) {
			GameObject tmp = tiles2.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 3) {
			GameObject tmp = tiles3.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 4) {
			GameObject tmp = tiles4.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 5) {
			GameObject tmp = tiles5.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 6) {
			GameObject tmp = tiles6.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		if (randomIndex == 7) {
			GameObject tmp = tiles7.Pop ();
			tmp.SetActive (true);
			tmp.transform.position = currentTile.transform.GetChild(0).transform.GetChild(0).position;
			currentTile = tmp;
		}
		currentTile = (GameObject)Instantiate (objetosPrefabs[randomIndex],currentTile.transform.GetChild(0).transform.GetChild(0).position,Quaternion.identity);
	}
}
