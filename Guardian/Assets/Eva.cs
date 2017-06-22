using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eva : MonoBehaviour {

	public GameObject cow;
	public GameObject eva;
	public GameObject text;
    public GameObject exitButton;
    public GameObject rig;

	void OnTriggerEnter (Collider other){
		if (other.tag == "Adam") {
			eva.SetActive (false);
			cow.SetActive (true);
			text.SetActive (true);
            exitButton.SetActive(true);
            rig.SetActive(true);
		}
	}
}
