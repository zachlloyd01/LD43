using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOne : MonoBehaviour
{

    public float thrust = 20;
    public Rigidbody2D rb;
    public Timer jumpTime = new Timer();
    public Sprite Player_Walk;
    public Sprite Player_Still;
    public Sprite Player_Jump;
    public bool canFly;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "LevelOne")
        {
            canFly = false;
        }
        else
        {
            canFly = true;
        }
    }
    void FixedUpdate()
    {
        var mySpriteRenderer = GetComponent<SpriteRenderer>();
        mySpriteRenderer.sprite = Player_Still;
        rb.freezeRotation = true;
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = transform.right * thrust;
            rb.gravityScale = 10;
            mySpriteRenderer.flipX = false;
            mySpriteRenderer.sprite = Player_Walk;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = transform.right * -thrust;
            rb.gravityScale = 10;
            mySpriteRenderer.flipX = true;
            mySpriteRenderer.sprite = Player_Walk;
        }
        if (canFly)
        {
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(transform.up * 3000);
                mySpriteRenderer.sprite = Player_Jump;
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(transform.up * -3000);
                mySpriteRenderer.sprite = Player_Jump;
            }
        }
    }
}
