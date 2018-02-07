using UnityEngine.SceneManagement;
using UnityEngine;

public class ShowCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void ShowCredit () {
		SceneManager.LoadScene ("credits");
	}
}
