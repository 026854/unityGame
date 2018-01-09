using UnityEngine;
using System.Collections;

public class test_notes : MonoBehaviour {

	public Texture2D up = null;
	public Texture2D down = null;
	public Texture2D left = null;
	public Texture2D right = null;
	public Animator anim;
	public float sec = 1.0f;
	public int FontSize = 14;

	bool L;
	bool tf = true;
	int num = 0;
	int Line_Clear_Combo = 0;

	public static int score = 0;
	public int[] notes = new int[] {0,0,0,0};
	public bool[] check = new bool[] {true, true, true, true};

	int time = 4;

	void make_Obj() {
		if (tf == true) {
			for (int i = 0; i < 4; i++) {
				notes [i] = Random.Range (0, 4);
			}
			tf = false;
		}
	}

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
	}

	void Update() {
		L = doorEvent.LOOK;
		if (time == 0) {
			make_Obj ();
			while (true) {
				note_play (num);
				break;
			}
		}
	}

	void OnGUI() {
		GUI.skin.label.fontSize = FontSize;

		anim = GetComponent<Animator> ();

		GUI.Label (new Rect (100, 100, 150, 64), "Score : " + score);
		GUI.Label (new Rect (100, 150, 150, 64), "Combo : " + Line_Clear_Combo);

		if (time == 0) {
			for (int i = 0; i < 4; i++) {
				switch (notes [i]) {
				case 0:
					if(check[i])
						GUI.DrawTexture (new Rect ((Screen.width / 10 * (i + 3)), (Screen.height / 4) * 3, 64, 64), up);
					break;
				case 1:
					if(check[i])
						GUI.DrawTexture (new Rect ((Screen.width / 10 * (i + 3)), (Screen.height / 4) * 3, 64, 64), down);
					break;
				case 2:
					if(check[i])
						GUI.DrawTexture (new Rect ((Screen.width / 10 * (i + 3)), (Screen.height / 4) * 3, 64, 64), left);
					break;
				case 3:
					if(check[i])
						GUI.DrawTexture (new Rect ((Screen.width / 10 * (i + 3)), (Screen.height / 4) * 3, 64, 64), right);
					break;
				}
			}
		}
	}

	void note_play(int i) {
		if (notes [i] == 0 && L == false) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				score += 10;
				check [num] = false;
				num++;
			} else if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
				score -= 20;
				tf = true;
				num = 0;
				Line_Clear_Combo = 0;
				for (int t = 0; t < 4; t++)
					check [t] = true;
			}
		} else if (notes [i] == 1 && L == false) {
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				score += 10;
				check [num] = false;
				num++;
			} else if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
				score -= 20;
				tf = true;
				num = 0;
				Line_Clear_Combo = 0;
				for (int t = 0; t < 4; t++)
					check [t] = true;
			}
		} else if (notes [i] == 2 && L == false) {
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				score += 10;
				check [num] = false;
				num++;
			} else if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyDown (KeyCode.RightArrow)) {
				score -= 20;
				tf = true;
				num = 0;
				Line_Clear_Combo = 0;
				for (int t = 0; t < 4; t++)
					check [t] = true;
			}
		} else if (notes [i] == 3 && L == false) {
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				score += 10;
				check [num] = false;
				num++;
			} else if (Input.GetKeyDown (KeyCode.DownArrow) || Input.GetKeyDown (KeyCode.LeftArrow) || Input.GetKeyDown (KeyCode.UpArrow)) {
				score -= 20;
				tf = true;
				num = 0;
				Line_Clear_Combo = 0;
				for (int t = 0; t < 4; t++)
					check [t] = true;
			}
		} else if (L == true){
			if (Input.GetKeyDown (KeyCode.UpArrow)||Input.GetKeyDown (KeyCode.DownArrow)||Input.GetKeyDown (KeyCode.LeftArrow)||Input.GetKeyDown (KeyCode.RightArrow)) {
				score -= 40;
				tf = true;
				num = 0;
				Line_Clear_Combo = 0;
				for (int t = 0; t < 4; t++)
					check [t] = true;
			}
		} if (num == 4) {
			score += (10 + Line_Clear_Combo * 10);
			num = 0;
			Line_Clear_Combo++;
			tf = true;
			for (int t = 0; t < 4; t++)
				check [t] = true;
		} 
	}
}
