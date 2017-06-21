using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryScript : MonoBehaviour {

	void OnTriggerEnter (Collider other){
		if (other.tag == "yes") {
			SceneManager.LoadScene (2);
		} else if (other.tag == "no") {
			//MENU laden
			SceneManager.LoadScene (1);
		}
	}
}
