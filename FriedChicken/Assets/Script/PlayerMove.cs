using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu( menuName = "CharacterMove/PlayerMove", fileName = "PlayerMove")]
public class PlayerMove : CharacterMoveBase
{
    public override void Jump()
    {
        rb.velocity = new Vector3(0, rb.velocity.y, 0);
        rb.AddForce(transform.up * moveSpeed);
    }

    public override void Rotate()
    {
        Quaternion q = Quaternion.Euler(0, 0, rotateSpeed * Time.deltaTime);
        transform.rotation *= q;
    }
}
