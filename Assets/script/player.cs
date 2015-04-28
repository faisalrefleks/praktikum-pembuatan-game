using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	Vector3 position;
	bool jump;
	float speedmove=60;
	float speedjump=300;
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			position= transform.position+Vector3.left;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			position= transform.position+Vector3.right;
			this.gameObject.transform.position = Vector3.MoveTowards (transform.position, position, speedmove * Time.deltaTime);
		}
		if (!jump) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				GetComponent<Rigidbody> ().velocity = Vector3.zero;
				GetComponent<Rigidbody> ().AddForce (Vector3.up * speedjump);		
			}
		}
	}
}