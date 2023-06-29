using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour {

    Rigidbody2D rb;
    //public int enemySpeed = -3;
    public int xPos = -25;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.x > 10) {
            float rv = Random.Range(-11,11);
            
            Vector3 positionChange = transform.localPosition;

            positionChange.y = rv;
            positionChange.x = xPos;

            transform.localPosition = positionChange;
        }

        int speed = 3 / (1 + (int)Time.deltaTime);

       // Debug.Log(Time.deltaTime);

        rb.velocity = new Vector2(speed,0);
    }   
}
