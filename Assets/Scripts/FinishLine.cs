using UnityEngine;

public class FinishLine : MonoBehaviour {

	public GameManager g1;

	// Update is called once per frame
	void OnTriggerEnter ()
	{
			g1.LevelUp ();
	}
}
