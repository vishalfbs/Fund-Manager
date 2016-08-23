using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InvestmentController : MonoBehaviour {

	public TextMesh TotalAvailFundText;
	public Text FundText;

	private int TotalAvailFund = 100000;
	private int incrementedFundRatio = 5000;
	private int investedFund;

	void Start(){

	}

	public void IncreaseFund(){
		if (TotalAvailFund >= incrementedFundRatio) {
			TotalAvailFund -= incrementedFundRatio;
			investedFund = investedFund + incrementedFundRatio;
			FundText.text += investedFund;
		}
	}

	public void DecreaseFund(){

	}

	public void LoadGraphScene(){
		SceneManager.LoadScene ("Graph");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			SceneManager.LoadScene ("MainScene");
		}
	}
}
