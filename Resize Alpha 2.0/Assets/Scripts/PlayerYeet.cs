using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerYeet : MonoBehaviour
{
    public Rigidbody rb;
    //public BoxCollider bx;
    public float yeet = 1200f;
    public float tangiza = 5f;
    public float Movespeed = 5;
    public float X;
    public GameObject Win;
    public TrailRenderer trail;

    private void Start()
    {
        transform.position = new Vector3(0, 1.6f, 0);
        Win.SetActive(false);

    }

    private void Update()
    { 
      float  DirectX = Input.GetAxis("Horizontal");
        //rb.velocity = new Vector2(DirectX *  Movespeed, rb.velocity.y);
        rb.velocity = new Vector3(X * Movespeed, rb.velocity.y , yeet);

       // rb.velocity=new Vector3(rb.velocity.x, rb.velocity.y, yeet );

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < 1.75f && transform.localScale.y != 0.5f)
        {

            rb.AddForce(0, tangiza, 0, ForceMode.Impulse);

        }

        if (Input.GetKeyDown(KeyCode.S))
        {

            //bx.size = new Vector3(1, 0.5f, 1); 
            //bx.center = new Vector3(0, -0.25f, 0);
            transform.localScale = Vector3.one * 0.5f;
            trail.widthMultiplier = 0.5f;
            rb.AddForce(0, -7.5f, 0, ForceMode.Impulse);

        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            //bx.size = new Vector3(1, 1f, 1); 
            //bx.center = new Vector3(0, 0f, 0);
            transform.localScale = Vector3.one;
            trail.widthMultiplier = 1f;

        }


    }

    public void ResizePress() 
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        trail.widthMultiplier = 0.5f;
        rb.AddForce(0, -7.5f, 0, ForceMode.Impulse);
    }

    public void ResizeRelease()
    {
        transform.localScale = new Vector3(1, 1, 1);
        trail.widthMultiplier = 1f;
    }

    public void Jump()
    {
        if (transform.position.y < 1.75 && transform.localScale.y != 0.5f)
        {

            rb.AddForce(0, tangiza, 0, ForceMode.Impulse);

        }
    }

    public void Rightenter()
    {
        X = 1;
    }

    public void Rightexit()
    {
        X = 0;
    }

    public void Leftenter()
    {
        X = -1;
    }

    public void Leftexit()
    {
        X = 0;
    }
}



