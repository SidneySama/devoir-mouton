using UnityEngine;
using System.Collections;

public class Mouton : MonoBehaviour {
	private Animator mouton;



	void Start () {

		mouton = gameObject.GetComponentInChildren<Animator>();
	}

	void Update ()
	{
		if (Input.GetKey ("up")) {
			mouton.SetBool ("up", true);
		} else {
			mouton.SetBool ("up", false);
		}
		if (Input.GetKey ("left")) {
			mouton.SetBool ("left", true);
		} else {
			mouton.SetBool ("left", false);
		}
		if (Input.GetKey ("right")) {
			mouton.SetBool ("right", true);
		} else {
			mouton.SetBool ("right", false);
		}
		if (Input.GetKey ("down")) {
			mouton.SetBool ("down", true);
		} else {
			mouton.SetBool ("down", false);
		}
	}
}