using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float vel;
    public GameObject player;
    public int Pontuacao;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Destroy(this.gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * vel);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.transform.CompareTag("Meteoro"))
        {
            player.GetComponent<Jogador>().AtualizaPonto();
            Pontuacao = Pontuacao + 100;
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }

    }
}
