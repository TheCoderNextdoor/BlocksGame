using UnityEngine.SceneManagement;
using UnityEngine;

public class back : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public void go_back()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 1);
	}
}
