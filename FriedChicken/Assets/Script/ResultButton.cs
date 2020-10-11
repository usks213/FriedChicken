using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultButton : MonoBehaviour
{
    //ボタンが押された時に実行される関数
    public void GotoTitle()
    {
        //ゲーム画面に移動する
        SceneManager.LoadScene("TitleScene");
    }
}