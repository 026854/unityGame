using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_click_end : MonoBehaviour {
	public Ray ray;
	public RaycastHit hitInfo;

	// Use this for initialization
	void Start(){ 
	}

	// Update is called once per frame
	void Update () {
		ray=Camera.main.ScreenPointToRay(Input.mousePosition );

		if(Input.GetMouseButtonDown(0)){
			if(Physics.Raycast(ray, out hitInfo)){  
				switch (hitInfo.transform.gameObject.name) {
				case "Go_To_Home":
					easy_notes.score = 0;
					hard_notes.score = 0;
					veryhard_notes.score = 0;
					test_notes.score = 0;
					SceneManager.LoadScene ("mainscene",LoadSceneMode.Single);
					break;
				}//gameObject name
			}
		}
	}
}