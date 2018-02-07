using UnityEngine.SceneManagement;
using UnityEngine;

public class HelpPane : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void ShowHelp () {
		SceneManager.LoadScene ("help_screen");
	}
}
