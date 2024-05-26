using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _compRigidBody2D;
    private SpriteRenderer _compSpriteRenderer;
    public float Speed;
    public int xDirection;
    public int yDirection;
    
    void Awake()
    {
        _compRigidBody2D = GetComponent<Rigidbody2D>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(Speed *xDirection , Speed * yDirection );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            xDirection = xDirection *  -1;
            _compSpriteRenderer.flipX = !_compSpriteRenderer.flipX;
            yDirection = yDirection * -1;
            _compSpriteRenderer.flipY = !_compSpriteRenderer.flipY;
        }
    }
}
