using UnityEngine;
using System.Collections;

public class SpiderJumper : MonoBehaviour {

	public float forceY = 300f;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake(){
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}



	// Use this for initialization
	void Start () {
		StartCoroutine (Attack ());
	}

	IEnumerator Attack(){
		yield return new WaitForSeconds (Random.Range (2, 7));

		forceY = Random.Range (250f, 500f);

		myBody.AddForce (new Vector2 (0, forceY));

		anim.SetBool ("Attack", true);

		yield return new WaitForSeconds (.7f);

		StartCoroutine (Attack ());

	}

	void OnTriggerEnter2D(Collider2D target){
		if (target.tag == "Player") {
			GameObject.Find("Gameplay Controller").GetComponent<GameplayController>().PlayerDied();
			Destroy(target.gameObject);
		}

		if (target.tag == "Ground") {
			anim.SetBool("Attack",false);
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
