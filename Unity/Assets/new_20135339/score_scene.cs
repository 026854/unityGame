using UnityEngine;
using System.Collections;

public class score_scene : MonoBehaviour {
	int FontSize = 50;
	int score1 = easy_notes.score;
	int score2 = hard_notes.score;
	int score3 = veryhard_notes.score;
	int score4 = test_notes.score;

	void OnGUI() {
		GUI.skin.label.fontSize = FontSize;
		//GUI.Label (new Rect (300, Screen.height / 2, 800, 800), "SCORE : " + score);
		if(score2 == 0 && score3 == 0 && score4 == 0)
			GUI.Label (new Rect (300, Screen.height / 2, 800, 800), "SCORE : " + score1);
		else if(score1 == 0 && score3 == 0 && score4 == 0)
			GUI.Label (new Rect (300, Screen.height / 2, 800, 800), "SCORE : " + score2);
		else if(score2 == 0 && score1 == 0 && score4 == 0)
			GUI.Label (new Rect (300, Screen.height / 2, 800, 800), "SCORE : " + score3);
		else if(score1 == 0 && score2 == 0 && score3 == 0)
			GUI.Label (new Rect (300, Screen.height / 2, 800, 800), "SCORE : " + score4);
	}
}