using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	public void show_main_menu()
	{
		SceneManager.LoadScene ("start");
	}
}
