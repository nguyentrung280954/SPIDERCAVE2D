using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {

	private PlayerScript player;

	void Awake(){
		player = GameObject.Find ("Player").GetComponent<PlayerScript> ();
	}

	public void OnPointerDown(PointerEventData data){
		if (gameObject.name == "Left") {
			player.SetMoveLeft(true);
			//Debug.Log ("Left");
		} else {
			player.SetMoveLeft(false);
			//Debug.Log("Right");
		}
	}

	public void OnPointerUp(PointerEventData data){
		player.StopMoving ();
	}
}




































