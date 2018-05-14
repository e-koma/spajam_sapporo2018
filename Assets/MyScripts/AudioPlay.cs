using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

public class AudioPlay : MonoBehaviour {

	public AudioSource audioSource;

	// Use this for initialization
	void Start () {
		Invoke("PlayAudio", 3.83f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void PlayAudio ()
	{
		audioSource.Play();
	}
}
