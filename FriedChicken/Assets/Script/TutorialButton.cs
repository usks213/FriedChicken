using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialButton : MonoBehaviour
{
    //ボタンが押された時に実行される関数
    public void GotoGame()
    {
        //ゲーム画面に移動する
        SceneManager.LoadScene("GameScene");
    }
}