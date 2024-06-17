using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rb;
    public float ballSpeed;
    public Vector2 [] startVector;
    public AudioSource ballSound;

    // Start is called before the first frame update
    void Start()
    {
        int startDirection = Random.Range(0, 3);
        rb.velocity = startVector[startDirection] * ballSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Left") && !collision.gameObject.CompareTag("Right"))
        {
            ballSound.Play();
        }

        if (collision.gameObject.CompareTag("Left"))
        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(false);
            Debug.Log("Ponto para o jogador 2");
        }
        
        if (collision.gameObject.CompareTag("Right"))
        {
            GameObject.FindAnyObjectByType<GameController>().AddScore(true);
            Debug.Log("Ponto para o jogador 1");
        }  
    }

}
