using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement3 : MonoBehaviour {
    public Transform target;
    public float enemySpeed = 0.5f;

    // Start is called before the first frame update
    void Start() {}
    
    // Update is called once per frame
    void FixedUpdate() {
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0,-90,0),Space.Self);
       
        if( Vector3.Distance(transform.position,target.position) > 1f) {
            transform.Translate(new Vector3(enemySpeed * Time.deltaTime,0,0) );
        }
    }
}