using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] int Life;
    int MaxLife;

    // Start is called before the first frame update
    void Start()
    {
        MaxLife = Life;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLife()
    {
        Life++;
        // 最大補正
        if(Life > MaxLife)
        {
            Life = MaxLife;
        }
    }

    public void DamageLife()
    {
        Life--;
        if(Life <= 0)
        {
            // 死亡処理
            
        }
    }

    public int GetLife()
    {
        return Life;
    }
    public int GetMaxLife()
    {
        return MaxLife;
    }
   
    private void OnCollisionEnter(Collision collision)
    {
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Heart")
        {
            AddLife();
            Destroy(collision.gameObject);
        }
    }
}
