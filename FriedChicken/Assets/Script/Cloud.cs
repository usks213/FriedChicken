using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [SerializeField] float maxSpeed;
    [SerializeField] Sprite[] cloud = new Sprite[3];

    SpriteRenderer renderer;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        renderer = transform.GetComponent<SpriteRenderer>();
        renderer.sprite = cloud[Random.Range(0, 2)];

        speed = Random.Range(-maxSpeed, maxSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0);

        if(transform.position.x > 12 || transform.position.x < -12)
        {

            speed *= -1;
        }
    }
}
