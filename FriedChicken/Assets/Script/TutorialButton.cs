using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
	[SerializeField] AudioClip buttonSE;
	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	//ボタンが押された時に実行される関数
	public void GotoGame()
    {
		source.PlayOneShot(buttonSE);
		//ゲーム画面に移動する
		SceneManager.LoadScene("GameScene");
    }
}