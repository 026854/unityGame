using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class clickEvent : MonoBehaviour {
	public Ray ray;
	public RaycastHit hit;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		 ray = Camera.main.ScreenPointToRay (Input.mousePosition);
	

		if (Input.GetMouseButtonDown(0)) {
			if (Physics.Raycast (ray, out hit)) {
				if (hit.collider.tag == "startbut") {
					SceneManager.LoadScene ("stage_select_scene", LoadSceneMode.Single);
				} else if (hit.collider.tag == "endbut") {
					SceneManager.LoadScene ("endscene", LoadSceneMode.Single);
				}

			}
		}
	
	}
}
