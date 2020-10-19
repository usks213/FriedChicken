using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NCMB;

public class Test : MonoBehaviour
{
    [SerializeField] ScoreUI scoreUI;

    // Start is called before the first frame update
    void Start()
    {
        NCMBObject testClass = new NCMBObject("TestClass");

        for (int i = 0; i < 10; i++)
        {
            testClass["Score"] = Random.Range(0, 1000);
            testClass.SaveAsync();
        }

        //QueryTestを検索するクラスを作成
        int nObjCnt = 0;
        NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject>("TestClass");
        //Scoreの値が7と一致するオブジェクト検索
        //query.OrderByAscending("Score");   //Scoreを昇順で並べ替え
        query.OrderByDescending("Score");  //Scoreを降順で並べ替え
        //query.WhereLessThanOrEqualTo("Score", 5);
        query.FindAsync((List<NCMBObject> objList, NCMBException e) => {
            if (e != null)
            {
                //検索失敗時の処理
            }
            else
            {
                //Scoreが7のオブジェクトを出力
                foreach (NCMBObject obj in objList)
                {
                    // 消去処理
                    if (nObjCnt > 20)
                    {
                        // サーバーデータを消去
                        obj.DeleteAsync();
                        continue;
                    }

                    // スコア表示
                    //scoreUI.SetScore(System.Convert.ToInt32(obj["Score"]));

                    // デバッグ
                    Debug.Log("objectId:" + obj.ObjectId + "Score" + System.Convert.ToInt32(obj["Score"]));

                    // カウンター更新
                    nObjCnt++;
                }
            }
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
