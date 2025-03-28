using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PontuacaoMaior : MonoBehaviour
{
    public TextMeshProUGUI TextoHighScore;
    // Start is called before the first frame update
    void Start()
    {
       TextoHighScore.text = "Pontuacao Maior" + PlayerPrefs.GetInt("HighScore") + "Pontos anterior: " + PlayerPrefs.GetInt("PontosPrefs"); 
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
