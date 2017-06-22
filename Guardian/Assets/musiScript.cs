using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class musiScript : MonoBehaviour
{
	void Start()
	{
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		DontDestroyOnLoad (gameObject);
		audio.Play(44100);
	}
}
