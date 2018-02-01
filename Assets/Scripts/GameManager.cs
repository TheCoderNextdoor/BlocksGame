using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool GameEnded= false;

	//game ending function
	public void EndGame ()
	{
		if (GameEnded == false) 
		{
			Debug.Log ("Game over");
			GameEnded = true;
			Invoke("Restart", 3f);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void LevelUp()
	{
		if (SceneManager.GetActiveScene ().buildIndex != 3) 
		{
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
		}
	}
}
