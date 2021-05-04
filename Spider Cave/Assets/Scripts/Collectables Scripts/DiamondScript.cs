using UnityEngine;
using System.Collections;

public class DiamondScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (Door.instance != null) {
			Door.instance.collectablesCount++;
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			Destroy(gameObject);

			if(Door.instance != null){
				Door.instance.DecrementCollectables();
			}
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
