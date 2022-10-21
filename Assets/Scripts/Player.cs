using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody playerRb;
    public float bounceForce = 6;
    public AudioSource bounceSound;

    private void OnCollisionEnter(Collision collision)
    {
        FindObjectOfType<AudioManager>().Play("bounce");
        playerRb.velocity = new Vector3(playerRb.velocity.x, bounceForce, playerRb.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;

        if (materialName == "Safe (Instance)")
        {
            // game on
        }
        else if (materialName == "Unsafe (Instance)")
        {
            GameManager.gameOver = true;
            FindObjectOfType<AudioManager>().Play("gameover");
        }
        else if (materialName == "Lit (Instance)" && !GameManager.levelCompleted)
        {
            GameManager.levelCompleted = true;
            FindObjectOfType<AudioManager>().Play("win");
        }
    }
}