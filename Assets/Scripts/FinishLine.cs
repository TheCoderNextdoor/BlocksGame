using UnityEngine;

public class FinishLine : MonoBehaviour {

	public GameManager g1;
	public PlayerMovement p1;

	// Update is called once per frame
	void OnTriggerEnter ()
	{
		p1.StopPlayer ();
		g1.LevelUp ();
	}
}
