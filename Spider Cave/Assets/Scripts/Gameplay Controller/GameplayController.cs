using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour {

	public gamemaster gm;
	[SerializeField]
	private GameObject pausePanel;

	[SerializeField]
	private Button resumeGame;
	public void Start()
	{
		gm = GameObject.FindGameObjectWithTag("gamemaster").GetComponent<gamemaster>();
	}
	public void PauseGame(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener(()=>ResumeGame());
	}

	public void ResumeGame(){
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void GoToMenu(){
		Time.timeScale = 1f;
		PlayerPrefs.SetInt ("points", 0);
		Application.LoadLevel ("MainMenu");
	}

	public void RestartGame(){
		Time.timeScale = 1f;
		PlayerPrefs.SetInt ("points", 0);
		Application.LoadLevel ("LevelMenu");
	}

	public void PlayerDied(){
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener(()=>RestartGame());
		if (PlayerPrefs.GetInt ("highscore") < gm.points)
			PlayerPrefs.SetInt ("highscore", gm.points);
		PlayerPrefs.SetInt ("points", 0);
	}

}





















