using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Sling : MonoBehaviour {
	public int scaling;
	public Transform t;
	public Rigidbody2D body;
	public Texture arrow;
	private Vector3 start;
	private Vector3 end;
	private Vector3 sling;
	private bool active;
	public Image image; 
	public float imgScale;
	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown(){
		if(!active){
			//start= Camera.main.ScreenToWorldPoint(Input.mousePosition);
			start= (Input.mousePosition);
			print(start);
			active=true;
		}
	}
	void OnMouseDrag(){
		print (start);
		end = (Input.mousePosition);
		sling = (end - start);
		print (image == null);
		image.transform.position = body.position;
		//image.transform.localScale.Set (Vector2.Distance (start, end), 1, 1);
		Vector3 spec = Camera.main.ScreenToWorldPoint (end);
		spec.z = 0;
		/*Quaternion rotation = Quaternion.LookRotation(Input.mousePosition-start,image.transform.TransformDirection(Vector3.up));
	 image.transform.rotation = new Quaternion(0,0,rotation.z,rotation.w);*/
		image.transform.localScale = new Vector3(Vector3.Distance (end, start)*imgScale,.2f/(1+(Vector3.Distance (end, start)*imgScale)),1);
		Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - image.transform.position;
		diff.Normalize();
	
		float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
		image.transform.rotation = Quaternion.Euler(0f, 0f, rot_z);
	}
	void OnMouseUp(){
		if (active) {
			end = (Input.mousePosition);
			sling = (end - start);
			body.velocity=body.velocity/6;
			body.AddForce (scaling*sling);
			active = false;
			image.transform.rotation = Quaternion.Euler(0f, 90f, 0f);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

