using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CharacterMove/CharacterMoveBase", fileName = "CharacterMoveBase")]
public class CharacterMoveBase : ScriptableObject
{
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected float rotateSpeed;
    [SerializeField] protected Transform transform;
    [SerializeField] protected Rigidbody rb;

    public void SetTrans(Transform trans)
    {
        transform = trans;
        rb = trans.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    virtual public void Jump() {}
    virtual public void Rotate() {}

    // Update is called once per frame
    void Update()
    {
        
    }
}
