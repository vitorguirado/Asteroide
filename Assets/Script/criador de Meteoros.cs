using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class criadordeMeteoros : MonoBehaviour
{
    public GameObject MeteoroPrefab;
    public float temporizador, tempoParaCriarMeteoro;
    public Transform posParaCriar;
    // Start is called before the first frame update
    void Start()
    {
        
        tempoParaCriarMeteoro = Random.Range(2, 5);
    }

    // Update is called once per frame
    void Update()
    {
        temporizador = temporizador + Time.deltaTime;

        if (temporizador >= 2)
        {
            temporizador = 0;
            GameObject ObjInstanciado = Instantiate(MeteoroPrefab, posParaCriar.transform.position, Quaternion.identity);
            ObjInstanciado.GetComponent<Meteoros>().MoveMeteoro();
            tempoParaCriarMeteoro = Random.Range(1, 3);
        }
    }
}
