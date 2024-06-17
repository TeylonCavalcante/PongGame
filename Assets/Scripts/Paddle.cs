using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed;
    public bool _isPlayer1;
    public bool _isPlayer2;
    public Animator _animator;
    private bool _isPressingUp;

    private bool _isPressingDown;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Objeto criado");
    }

    // Update is called once per frame
    void Update()
    {
        if (_isPlayer1)
        {
            _isPressingUp = Input.GetKey(KeyCode.W);
            _isPressingDown = Input.GetKey(KeyCode.S);
        }
        else
        {
            _isPressingUp = Input.GetKey(KeyCode.UpArrow);
            _isPressingDown = Input.GetKey(KeyCode.DownArrow);
        }
        
        if (_isPressingUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (_isPressingDown)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _animator.SetTrigger("Hit");
        }
    }
}
