using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mira : MonoBehaviour
{
    public float temporizador, tempoParaApagarFogo;
    public SpriteRenderer fire;
    public float VelocidadeDaLuz;
    public Transform pontoDeTiro;
    public GameObject Municao;
    public Camera cam;
    public Vector2 posParaOlhar;
    public Rigidbody2D rb2d;
     
    // Start is called before the first frame update
    void Start()    
    {
       
     
        rb2d.GetComponent<Rigidbody2D>();        
    
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(Municao, pontoDeTiro.position, this.transform.rotation);
            fire.enabled = true;
        }
        if(fire.enabled == true)
        {
            temporizador += Time.deltaTime;
            if(temporizador >= tempoParaApagarFogo)
            {
                fire.enabled = false;
                temporizador = 0f;
            }
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {   

        posParaOlhar = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 pos = posParaOlhar - rb2d.position;

        float angoloParaOlhar = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - 90f;
        
        rb2d.rotation = angoloParaOlhar;
    
    }   
}
