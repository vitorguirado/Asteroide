using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour
{
    public TextMeshProUGUI textContador;
    public TextMeshProUGUI TextoHighScore;
    public TextMeshProUGUI TextoVida;
    public TextMeshProUGUI TextoPontos;
    public Camera mainCamera;
    public float screenWidth;
    public float screenHeight;
    public float vel;
    public int vida, pontos;
    public Rigidbody2D rb2d;
    [SerializeField]
    public Vector2 PosParaOlhar;
    [SerializeField]
    
    // Start is called before the first frame update
    void Start()
    {
        TextoHighScore.text = "pontos: " + PlayerPrefs.GetInt("HighScore");
        rb2d = GetComponent<Rigidbody2D>();
        vida = 10;
        TextoVida.text = "vida: " + vida;
        screenHeight = mainCamera.orthographicSize * 2;
        screenWidth = screenHeight * mainCamera.aspect;
       // TextoPontos.text = "pontos: " + pontos;
        pontos = 0;

    }


    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        if (position.x < mainCamera.transform.position.x - screenWidth / 2)
        {
            position.x = mainCamera.transform.position.x + screenWidth / 2;
        }
        else if (position.x > mainCamera.transform.position.x + screenWidth / 2)
        {
            position.x = mainCamera.transform.position.x - screenWidth / 2;
        }
        if (position.y < mainCamera.transform.position.y - screenHeight / 2)
        {
            position.y = mainCamera.transform.position.y + screenHeight / 2;
        }
        else if (position.y > mainCamera.transform.position.y + screenHeight / 2)
        {
            position.y = mainCamera.transform.position.y - screenHeight / 2;
        }

        // Atualize a posição do personagem
        transform.position = position;




        rb2d.velocity = new Vector2(vel * Input.GetAxisRaw("Horizontal"), vel * Input.GetAxisRaw("Vertical"));

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Meteoro"))
        {
            AtualizaVida();
        }
        if (vida == 0)
        {
            //SceneManager.LoadScene("SampleScene");
        }
    }
    public void AtualizaPonto()
    {
        pontos += 100;
        textContador.text = "Pontos: " + pontos;

    }
    public void AtualizaVida()
    { 
        vida = vida - 1;
        if (vida <= 0)
        {
            PlayerPrefs.SetInt("PontosPrefs", pontos);
            SceneManager.LoadScene("HighScore");
            //terminar jogo
        }
        TextoVida.text = "vidas: " + vida;
        {
         if (PlayerPrefs.GetInt("PontosPrefs") > PlayerPrefs.GetInt("HighScore"))
         {
                PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("PontosPrefs"));


            }

        
        } 
    }
}





