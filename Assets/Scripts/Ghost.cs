using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;

    private GameObject player;

    private Vector2 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerController>().gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        // where is the player
        playerPos = player.transform.position;


//        

    }

    private void FixedUpdate()
    {
        // turn and go towards player
        
        //rb.MovePosition(rb.position + playerPos * moveSpeed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, playerPos, moveSpeed * Time.deltaTime);
            

        Vector2 aimDirection = playerPos - rb.position;
        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg + 90f;

        rb.rotation = angle;
    }
}
