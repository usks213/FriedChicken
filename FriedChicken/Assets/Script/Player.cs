using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float moveForce;
    [SerializeField] float rotateSpeed;
    Rigidbody rb2d;
    AudioSource source;
    [SerializeField] AudioClip jumpSE;
    [SerializeField] GoalUI goalUI;
    [SerializeField] PlayerAnim anim;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = transform.GetComponent<Rigidbody>();
        source = transform.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.velocity = new Vector3(0, rb2d.velocity.y, 0);
            rb2d.AddForce(transform.up * moveForce);
            source.PlayOneShot(jumpSE);
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion q = Quaternion.Euler(0, 0, rotateSpeed * Time.deltaTime);
            transform.rotation *= q;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion q = Quaternion.Euler(0, 0, -rotateSpeed * Time.deltaTime);
            transform.rotation *= q;
        }

        anim.SetRun(rb2d.velocity.y);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Goal")
        {
            //SceneManager.LoadScene("ResultScene");
            goalUI.StartGoal();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Needl")
        {
          //  anim.SetHitAnim();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Goal")
        {
            //SceneManager.LoadScene("ResultScene");
            goalUI.StartGoal();
        }
    }
}
