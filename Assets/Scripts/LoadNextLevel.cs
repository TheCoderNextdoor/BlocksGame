using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour 
{
	//attached to animation panel, loads next level when animation ends
	void NextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
