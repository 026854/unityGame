using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class count_time : MonoBehaviour {
	int Fs = 70;
	public float sec=1.0f;
	public float play_music_start = 3.0f;
	public GameObject num1,num2,num3;
	public AudioClip music1;
	public AudioSource nowmusic;


	int i=3;
	 
	// Use this for initialization
	IEnumerator Start () {
		
		while (true) 
		{
			switch (i)
			{
				case 3:
					Instantiate (num3, transform.position, transform.rotation);
					break;
				case 2:
					Instantiate (num2, transform.position, transform.rotation);
					break;
				case 1:
					Instantiate (num1, transform.position, transform.rotation);
					break;

			}
			i--;
			if (i == 0) 
			{
				break;
			}
			yield return new WaitForSeconds (sec);

		}
		nowmusic = GetComponent<AudioSource> ();
		nowmusic.clip = music1;
		nowmusic.Play ();
	
	
	}

	// Update is called once per frame
	void Update () {
		if (i == 0) {
			nowmusic = GetComponent<AudioSource> ();
			nowmusic.clip = music1;	
			if (!nowmusic.isPlaying) {

				SceneManager.LoadScene ("End_scene");


			}

		}
	}


}
