using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    Rigidbody2D rb;

    public int yPos = 12;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }
        
    // Update is called once per frame
    void Update() {
        if(transform.position.y < -1) { 
            float rv = Random.Range(-20,20);

            Vector3 positionChange = transform.localPosition;
            
            positionChange.x = rv;
            positionChange.y = yPos;
            transform.localPosition = positionChange;
        }
        
        int speed = -5 / (1 + (int)Time.deltaTime);

        rb.velocity = new Vector2(0,speed);
    }
}