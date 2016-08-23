using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GraphController : MonoBehaviour {

	public void LoadPreviousScene(){
		SceneManager.LoadScene ("MainScene");
	}
}
