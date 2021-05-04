using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour {
	public int levelload = 1;
	public static Door instance;
	public Text pointtext;
	private Animator anim;
	private BoxCollider2D box;
	public gamemaster gm;
	[HideInInspector]
	public  int collectablesCount;
	// Use this for initialization

	void Awake()
	{
		MakeInstance ();
		anim = GetComponent<Animator> ();
		box = GetComponent<BoxCollider2D> ();
		gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
	}

	void MakeInstance ()
	{
		if (instance == null)
			instance = this;
	}

	IEnumerator OpenDoor()
	{
		anim.Play ("Open");
		yield return new  WaitForSeconds (.7f);
		box.isTrigger = true;
	}

    public void DecrementCollectables()
    {
        collectablesCount--;

        if (collectablesCount == 0)
        {
            StartCoroutine(OpenDoor());
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Player") 
		{
			savecore ();
			Debug.Log ("Finish");
			Time.timeScale = 1f;
			if (PlayerPrefs.GetInt ("highscore") < gm.points)
				PlayerPrefs.SetInt ("highscore", gm.points);
		}

	}

	private void OnTriggerStay2D (Collider2D target)
	{
		if (target.tag == "Player")
		{
			
			SceneManager.LoadScene(levelload);
			if (levelload == 1) {
			}

		}
	}
	void savecore()
	{
		PlayerPrefs.SetInt ("points", gm.points);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
