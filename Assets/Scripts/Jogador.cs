using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 10.0f;
    public float horizontalAxis;
    public Rigidbody2D rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        
    }
    void Update()
    {
        horizontalAxis = Input.GetAxis("Horizontal");
        rigidbody.velocity = new Vector2(horizontalAxis * velocidade,0);

    }
}
