using UnityEngine;
using System.Collections;

public class exit: MonoBehaviour {
	void Update ()
	{
		if (Input.GetKey ("escape"))
			Application.Quit ();

	}
}
