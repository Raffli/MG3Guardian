using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour {

	Animator anim;
	public bool walk;
    public float speed;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		walk = true;
	}
	
	// Update is called once per frame
	void Update () {

		if (walk == true) {



			anim.SetBool ("isWalking", true);
			anim.SetBool ("isIdle", false);
			transform.Translate(0, 0, speed/100 );

		} else if (walk == false) {

			anim.SetBool ("isWalking", false);
			anim.SetBool ("isIdle", true);

		}
			
		
		}

	void OnTriggerEnter (Collider other){
		if (other.tag == "MoveStopper") {
			walk = false;
		} else if (other.tag == "enemy") {
			walk = false;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		} else if (other.tag == "MoveStarter") {
			
			walk = true;
		} else if (other.tag == "FinishField") {

			walk = false;
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex+1);
		} else if (other.tag == "DeadField") {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			walk = false;
		} else if (other.tag == "Mushroom") {
			print ("Mushroom");
			print (transform.rotation.y);
			transform.Rotate (new Vector3 (0, 180, 0));
			Collider col = other.gameObject.GetComponent<Collider> ();
			col.enabled = false;
			//col.isTrigger = false;
		} else if (other.tag == "LightHand") {
			walk = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "LightHand") {
			walk = false;
		}
	}
		
}
