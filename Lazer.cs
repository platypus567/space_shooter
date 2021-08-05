using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 8;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        laserMovement();
        //if laser leaves screen, delete.
        if(transform.position.y > 5.7f){
            Destroy(gameObject);
        }
    }
    void laserMovement()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
