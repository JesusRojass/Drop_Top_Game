using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MOVTUTO : MonoBehaviour {
	private static MOVTUTO instance; 
	public static MOVTUTO Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<MOVTUTO> ();
			}
			return MOVTUTO.instance; 
		}
	}
	public float speed = 30.0F;
	public float vel;
	public float mem;
	public float velo = 25.0f;
	public float accel;
	private Vector3 fo;
	private Vector3 meme;
	float xatstart = 0;
	private Rigidbody rb;
	float yatstart = 0;
	Vector3 dir = Vector3.zero;

	void Start () {
		fo = Vector3.zero;
		xatstart = Input.acceleration.x;
		yatstart = Input.acceleration.y;
		rb = GetComponent<Rigidbody>();
	}
	void Update () {
		dir.z = (Input.acceleration.y-yatstart);
		dir.x = (Input.acceleration.x-xatstart);
		if (dir.sqrMagnitude > 1)
			dir.Normalize();
		dir *= Time.deltaTime;
		Vector3 dow = Vector3.down;

		dow *= Time.deltaTime;
		transform.Translate(dow * velo);

		float howMuch = vel * Time.deltaTime;
		transform.Translate(meme*howMuch);
		transform.Translate(dir * speed);

		float cuantoMover = mem * Time.deltaTime;
		cuantoMover += cuantoMover * accel * 2;
		transform.Translate(fo*cuantoMover);

		rb.AddForce (fo * accel);
	}
	public void OnCollisionEnter(Collision exampleCol) {
		if(exampleCol.collider.tag != "MemeLord")
		{
			SceneManager.LoadScene ("TUTO");
		}
	}
}
