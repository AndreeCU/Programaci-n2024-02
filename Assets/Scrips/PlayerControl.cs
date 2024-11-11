using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D _componentRigidbody2D;
    private BoxCollider2D _boxCollider2D;
    public float horizontal;
    public float vertical;
    public float speedX;
    public float speedY;


    private void Awake()
    {
        _componentRigidbody2D = GetComponent<Rigidbody2D>();
        _boxCollider2D = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        // Obtener entrada del jugador
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // Aplicar la velocidad al componente Rigidbody2D
        _componentRigidbody2D.velocity = new Vector2(horizontal * speedX, vertical * speedY);


    }

}