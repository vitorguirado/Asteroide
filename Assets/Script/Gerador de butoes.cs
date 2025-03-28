using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Geradordebutoes : MonoBehaviour
{


    public void ApertarIniciar()
    {
        SceneManager.LoadScene("SampleScene");

    }

    public void ApertouSair()
    {
        Application.Quit();
    }
    public void ApertouVoltarMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
