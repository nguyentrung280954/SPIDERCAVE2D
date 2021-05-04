using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
	public AudioClip coins, jump;
	public AudioSource adirsc;
	// Use this for initialization
	void Start () {
		coins = Resources.Load<AudioClip> ("coin");
		jump = Resources.Load<AudioClip> ("jump");
		adirsc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	public void playsound(string clip)
	{
		switch (clip) {
		case "coins":
			adirsc.clip = coins;
			adirsc.PlayOneShot (coins, 0.6f);
			break;
		case "jump":
			adirsc.clip = jump;
			adirsc.PlayOneShot (jump, 0.6f);
			break;
		}
	}
}
