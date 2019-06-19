using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Movimiento : MonoBehaviour {
	private static Movimiento instance; 
	public static Movimiento Instance {
		get { 
			if (instance == null) {
				instance = GameObject.FindObjectOfType<Movimiento> ();
			}
			return Movimiento.instance; 
		}
	}
	public float speed = 30.0F;
	public Renderer mater;
	public float vel;
	public float mem;
	public float velo = 25.0f;
	public float accel;
	private Vector3 fo;
	private Vector3 meme;
	float xatstart = 0;
	private Rigidbody rb;
	public int startGame = 0;
	float yatstart = 0;
	Vector3 dir = Vector3.zero;
	void Start () {
		fo = Vector3.zero;
		xatstart = Input.acceleration.x;
		yatstart = Input.acceleration.y;
		rb = GetComponent<Rigidbody>();
		renderBall ();
	}
	void Update () {
		if (Menus.Instance.lmaoooo != 1) {
			accel = 10;
		}
		dir.z = (Input.acceleration.y - yatstart);
		dir.x = (Input.acceleration.x - xatstart);

		if (dir.sqrMagnitude > 1)
			dir.Normalize ();
		dir *= Time.deltaTime;

		rb.AddForce (fo * accel);

		Vector3 dow = Vector3.down;
		dow *= Time.deltaTime;
		transform.Translate (dow * velo);

		float howMuch = vel * Time.deltaTime;
		transform.Translate (meme * howMuch);
		transform.Translate (dir * speed);

		float cuantoMover = mem * Time.deltaTime;
		cuantoMover += cuantoMover * accel * 2;
		transform.Translate (fo * cuantoMover);
	}
	public void renderBall(){
		mater = GetComponent<Renderer>();
		mater.enabled = true;
	}
	public void OnCollisionEnter(Collision exampleCol) {
		if(exampleCol.collider.tag != "MemeLord")
		{
			Destroy(this);
			Time.timeScale = 0;
			Menus.Instance.rip ();
		}
	}
}
