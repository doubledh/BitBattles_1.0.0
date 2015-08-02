using UnityEngine;
using System.Collections;

public class mouseTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Vector2 v = new Vector2 (1, 2);
		Vector3 vi = v;
		print (vi);
		Vector3 vii= new Vector3(v.x,v.y,0);
		print (vii);
	}
	// Update is called once per frame
	void Update () {
		//print ("x:"+Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}
}
