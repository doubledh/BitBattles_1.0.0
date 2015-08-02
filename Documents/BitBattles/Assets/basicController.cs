using UnityEngine;
using System.Collections;

public class basicController : MonoBehaviour {
	public Rigidbody2D R2D;
	public int intensity;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown("right"))
			R2D.AddForce (new Vector2(intensity,0));
	if (Input.GetKeyDown("up"))
			R2D.AddForce (new Vector2(0,intensity));
	if (Input.GetKeyDown("left"))
			R2D.AddForce (new Vector2(-intensity,0));
	if (Input.GetKeyDown("down"))
			R2D.AddForce (new Vector2(0,-intensity));
	}
}
