using UnityEngine;
using System.Collections;

public class doorEvent : MonoBehaviour {
	public int per_speed = 70;
	public float sec = 1.0f;
	float seconds = 3.0f;

	float nosec = 0.0f;
	public static bool LOOK = false;

	int time = 4;

	bool stopstate = false;
	bool upd = true;
	bool closedoor = true;
	// Use this for initialization
	IEnumerator Start () {

		while (true) 
		{
			time--;
			if (time == 0) 
			{
				break;
			}
			yield return new WaitForSeconds (sec);

		}
			
		while (true) {
			if(upd==false) {
				rotadoor ();
			}
			if (upd == true&&closedoor==false) {
				float randomWait = Random.Range(3.0f,6.0f);
				LOOK = true;
				yield return new WaitForSeconds (randomWait);
				closedoor = true;
			}
			if (upd == true && closedoor == true&&stopstate==false) {
				doorclose ();
			}
			if (upd == true && closedoor == true&&stopstate == true) {
				float newrand = Random.Range (8.0f, 15.0f);
				yield return new WaitForSeconds (newrand);

				setre ();
			}
			yield return new WaitForSeconds (nosec);
		
		}

	}
	void rotadoor(){
		this.transform.Rotate (0.0f, -per_speed * Time.deltaTime, 0.0f);
		if (this.transform.rotation.y < -0.5f) {
			upd = true;
		}
	}
	void doorclose(){
		LOOK = false;
		this.transform.Rotate (0.0f,per_speed * Time.deltaTime, 0.0f);
		if (this.transform.rotation.y >= 0.0f) {
			stopstate = true;
		}

	}
	void setre()
	{
		stopstate = false;
		upd = false;
		closedoor = false;

	}
}
