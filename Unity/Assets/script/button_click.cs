using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class button_click : MonoBehaviour {
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
				case "easy_button":
					SceneManager.LoadScene ("main_easy", LoadSceneMode.Single);
					break;
				case "hard_button":
					SceneManager.LoadScene ("main_hard", LoadSceneMode.Single);
					break;
				case "veryhard_button":
					SceneManager.LoadScene ("main_veryhard", LoadSceneMode.Single);
					break;
				case "main_button":
					SceneManager.LoadScene ("mainscene", LoadSceneMode.Single);
					break;
				case "test_button":
					SceneManager.LoadScene ("main_test", LoadSceneMode.Single);
					break;
				}//gameObject name
			}
		}
	}
}
