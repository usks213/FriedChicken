using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class ResultButton : MonoBehaviour
{
    private void Start()
    {
		EventSystem.current.SetSelectedGameObject(gameObject);
    }

    //ボタンが押された時に実行される関数
    public void GotoTitle()
    {
        //ゲーム画面に移動する
        SceneManager.LoadScene("TitleScene");
    }
}