using System.Collections;
using System.Collections.Generic;

using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ScrollObject : MonoBehaviour
{
    private GameManager gameManager;
    private Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(-gameManager.ScrollSpeed, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
