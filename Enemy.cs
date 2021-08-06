using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
    }
    void enemyMovement()
    {
        //move enemy down at 4 meters per second
        //if hit bottom of screen, respawn at top
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if(transform.position.y <= -5f)
        {
            transform.position = new Vector3(Random.Range(-7.11f, 7.11f), 5.7f, 0);
        }
    }
    //collision check
    private void OnTriggerEnter(Collider other)
    { 
        if(other.tag == "Player"){
            Player player = other.transform.GetComponent<Player>();
            if(player != null){
            player.damage();
            }
            Destroy(this.gameObject);
        }
        if(other.tag == "Lazer"){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
  
}
