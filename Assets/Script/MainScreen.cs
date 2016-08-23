using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour {

	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void LoadScene(){
		SceneManager.LoadScene ("GraphScene");
	}
}
