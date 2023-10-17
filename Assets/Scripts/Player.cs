using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private Animation thisAnimation;
    [SerializeField] private float jumpForce = 2f;
    public Rigidbody rb;
    void Start()
    {
        thisAnimation = GetComponent<Animation>();
        thisAnimation["Flap_Legacy"].speed = 3;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 3.5)
        {
            thisAnimation.Play();
            rb.velocity = Vector2.up * jumpForce;
        }
           
        if(transform.position.y < -4.5)
        {
            SceneManager.LoadScene("GameLose");
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
