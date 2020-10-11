using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needl : MonoBehaviour
{
    [SerializeField] float colForce;
    [SerializeField] AudioClip kokee;
    AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        source = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            // ノックバック
            Rigidbody2D rb2d = collision.transform.GetComponent<Rigidbody2D>();
            Vector3 vec = collision.transform.position - transform.position;
            vec = vec.normalized;
            rb2d.AddForce(vec * colForce);

            // ダメージ処理
            collision.transform.GetComponent<PlayerLife>().DamageLife();

            source.PlayOneShot(kokee);

            // カメラの揺れ
            Camera.main.GetComponent<CameraMove>().SetShake(10);
        }
    }

}
