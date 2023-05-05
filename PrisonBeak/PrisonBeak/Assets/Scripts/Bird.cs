using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public SpriteRenderer BirdSpriteRenderer;
    public Rigidbody BirdRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // KeepOnScreen(); change to 3d barrier objects
        Walk();
        Fly();

    }

    public void Walk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            BirdSpriteRenderer.transform.position +=Vector3.forward * GameParameters.walkSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            BirdSpriteRenderer.transform.position +=Vector3.left * GameParameters.walkSpeed * Time.deltaTime;
            BirdSpriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            BirdSpriteRenderer.transform.position +=Vector3.back * GameParameters.walkSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            BirdSpriteRenderer.transform.position +=Vector3.right * GameParameters.walkSpeed * Time.deltaTime;
            BirdSpriteRenderer.flipX = false;
        }
        
    }

    public void Fly()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            BirdRigidbody2D.AddForce(Vector2.up * GameParameters.jumpAmount, ForceMode.Impulse);
        }
    }
    private void KeepOnScreen()
    {
        BirdSpriteRenderer.transform.position = SpriteTools.ConstrainToScreenLame(BirdSpriteRenderer);
    }
}
