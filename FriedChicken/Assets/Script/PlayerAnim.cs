using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    Animator anim = null;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SetHitAnim()
    {
        anim.SetTrigger("Hit");
    }

    public void SetRun(float speed)
    {
        anim.SetFloat("Speed", speed);
    }
}
