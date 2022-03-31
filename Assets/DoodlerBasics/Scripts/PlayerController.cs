using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public Rigidbody2D rb;
    public string coinTag="Coin";

    private float moveX;

    // Start is called before the first frame update
    void Awake()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") * moveSpeed;
        if (Application.platform == RuntimePlatform.Android)
        {
            moveX=  Input.acceleration.x *moveSpeed;
        }
    }
     private void OnCollisionEnter2D(Collision2D other)
    { 
                
                  if(other.gameObject.CompareTag(coinTag)){
                      Destroy(other.gameObject);
                       PlayerPrefs.SetInt( "coinCount",PlayerPrefs.GetInt("coinCount")+1);

                  }

    }

     private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = moveX;
        rb.velocity=velocity;
    }
}
