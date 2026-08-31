using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class kuskontrol : MonoBehaviour
{
    public float ziplama = 5f;
    private int skor=0;
    private Rigidbody2D fizikMotoru;

    void Start()
    {
        fizikMotoru = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fizikMotoru.linearVelocity = Vector2.up * ziplama;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("engel"))
        {
            Time.timeScale = 0f;
            Debug.Log("kuþ öldü...");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="skoralani")
        {
            skor++;
            Debug.Log("Skor: " + skor);
        }
    }
}

