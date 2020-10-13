using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TitleButtonSelect : MonoBehaviour
{
	[SerializeField] GameObject firstSelect;
	[SerializeField] AudioClip cursorMove;
	AudioSource source;

	// Start is called before the first frame update
	void Start()
    {
		source = GetComponent<AudioSource>();
		EventSystem.current.SetSelectedGameObject(firstSelect);
	}

	// Update is called once per frame
	void Update()
    {
		if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
		{
			source.PlayOneShot(cursorMove);
		}
	}
}
