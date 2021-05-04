using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelTimer : MonoBehaviour {

	private Slider slider;
	
	private GameObject player;
	
	public float timer = 10f;
	
	private float timerBurn = 1f;
	
	
	void Awake(){
		GetPrefereces ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!player)
			return;
		
		if (timer > 0) {
			timer -= timerBurn * Time.deltaTime;
			slider.value = timer;
		} else {
			GetComponent<GameplayController>().PlayerDied();
			Destroy(player);
		}
	}
	
	void GetPrefereces(){
		player = GameObject.Find ("Player");
		slider = GameObject.Find ("Time Slider").GetComponent<Slider> ();
		
		slider.minValue = 0f;
		slider.maxValue = timer;
		slider.value = slider.maxValue;
	}
}
