using UnityEngine;
using System.Collections;

public class LevelMenuController : MonoBehaviour {

	public void PlayGame(){
		Application.LoadLevel("MainMenu");
	}

	public void BackToMenu(){
		Application.LoadLevel("MainMenu");
	}

}
