using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour {

    // Setup movement x and y
    public float movement;
    public float movement2;

    // Setup rigid
    public Rigidbody2D rigid;
    // Setup speed
    public float speed = 30.0f;

    // Start is called before the first frame update
    void Start() {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        movement = Input.GetAxis("Horizontal");
        movement2 = Input.GetAxis("Vertical"); 
    }

    // Called multiple times per frame, best for physics for smooth behavior
    void FixedUpdate() {
        // Have movement vector/ speed changed for rigid
        rigid.velocity = new Vector2(movement2 * speed, rigid.velocity.y);
        rigid.velocity = new Vector2(movement * speed, rigid.velocity.x);
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.name == "Shark") {
            SceneManager.LoadScene("GameOverScene");
        } else if (other.name == "Tiger Shark") {
            SceneManager.LoadScene("GameOverScene");
        } else {
            SceneManager.LoadScene("FunnyGameOverScene");
        }
    }
}