using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleButton : MonoBehaviour
{

    //ボタンが押された時に実行される関数
    public void GotoTutorial()
    {
        //ゲーム画面に移動する
        SceneManager.LoadScene("TutorialScene");
    }
}