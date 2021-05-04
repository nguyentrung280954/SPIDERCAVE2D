using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuController : MonoBehaviour {

	public GameplayController gc;
	public void playgame()
	{
		Application.LoadLevel("levelMenu");
		PlayerPrefs.SetInt ("points", 0);
	}
	public void playgame1()
	{
		Application.LoadLevel("GamePlay");
	}

	public void playgame2()
	{
		Application.LoadLevel("GamePlay 1");
	}
	public void playgame3()
	{
		Application.LoadLevel("GamePlay 2");

	}

	public void backGame()
	{
		Application.LoadLevel("MainMenu");
	}

	public void resetGame()
	{
		Application.LoadLevel("MainMenu");
		PlayerPrefs.DeleteAll ();
	}

	public void quitGame()
	{
		Application.Quit ();
		Debug.Log ("quit");
	}

}
