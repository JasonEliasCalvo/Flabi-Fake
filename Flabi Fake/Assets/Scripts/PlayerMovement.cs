using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rB2;
    [SerializeField] float jumpForfe;

    void Start()
    {
        rB2 = GetComponent<Rigidbody2D>();
    }

    public void Jump() 
    {
        rB2.velocity = new Vector2(0,jumpForfe);
    }

}
