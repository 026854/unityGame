using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow))
		{
			this.transform.position = new Vector3 (0, 0, -10);
			anim.Play ("POSE12",-1,0f);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			this.transform.position = new Vector3 (0, 0, -10);
			anim.Play ("POSE22",-1,0f);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow))
		{
			this.transform.position = new Vector3 (0, 0, -10);
			anim.Play ("POSE25",-1,0f);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			this.transform.position = new Vector3 (0, 0, -10);
			anim.Play ("POSE11",-1,0f);
		}
	}
}
 