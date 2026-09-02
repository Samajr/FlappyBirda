using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class kuskontrol : MonoBehaviour
{
    public float ziplama = 5f;
    public TextMeshProUGUI skorMetni;
    public TextMeshProUGUI MaxSkorMetni;
    public TextMeshProUGUI PanelGuncelSkor;
    public TextMeshProUGUI PanelEnYuksekSkor;
    public GameObject gameoverpanel;
    private int skor=0;
    private Rigidbody2D fizikMotoru;

    void Start()
    {
        fizikMotoru = GetComponent<Rigidbody2D>();
        int kayitlirekor = PlayerPrefs.GetInt("EnYuksekSkor", 0);
        MaxSkorMetni.text = "Rekor: " + kayitlirekor.ToString();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            fizikMotoru.linearVelocity = Vector2.up * ziplama;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("engel"))
        {
            
            Debug.Log("kuþ öldü...");
            gameoverpanel.SetActive(true);
            int eskirekor = PlayerPrefs.GetInt("EnYuksekSkor", 0);
            if (skor > eskirekor)
            {
                PlayerPrefs.SetInt("EnYuksekSkor", skor);
                PlayerPrefs.Save();
                Debug.Log("Tebrikler yeni rekor!--->"+skor);
            }
            PanelGuncelSkor.text = "Skor: " + skor.ToString();
            int enGuncelRekor = PlayerPrefs.GetInt("EnYuksekSkor", 0);
            PanelEnYuksekSkor.text = "En Yüksek Skor: " + enGuncelRekor.ToString();

            Time.timeScale = 0f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name=="skoralani")
        {
            skor++;
            Debug.Log("Skor: " + skor);
            skorMetni.text = skor.ToString();
        }
    }
    public void yenidenbaslat()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

