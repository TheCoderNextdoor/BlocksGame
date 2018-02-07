using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool GameEnded= false;
	public float restartDelay = 2.2f;
	public GameObject LevelUpSplash;

	//game ending function
	public void EndGame ()
	{
		if (GameEnded == false) 
		{
			GameEnded = true;
			Invoke("Restart", restartDelay);
		}
	}
		
	//restart the current level
	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	//load next level
	public void LevelUp()
	{
		LevelUpSplash.SetActive(true);
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Escape))
		{
			SceneManager.LoadScene("credits");
		}
	}
}
