using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TitleButton : MonoBehaviour
{
	[SerializeField] GameObject TitleObj;
	[SerializeField] GameObject TutorialObj;
	[SerializeField] GameObject StartButton;
	[SerializeField] AudioClip buttonSE;
	AudioSource source;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}

	//ボタンが押された時に実行される関数
	public void GotoTutorial()
    {
		GetComponent<AudioSource>().PlayOneShot(buttonSE);
		TitleObj.SetActive(false);
		TutorialObj.SetActive(true);
		EventSystem.current.SetSelectedGameObject(StartButton);
	}
}