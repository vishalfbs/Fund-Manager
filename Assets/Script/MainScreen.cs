using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainScreen : MonoBehaviour {

	void Start(){
		Debug.Log ("This is main scene");
	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}

	public void LoadScene(){
		SceneManager.LoadScene ("GraphScene");
	}
}
