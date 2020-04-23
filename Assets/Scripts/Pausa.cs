﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pausa: MonoBehaviour


{
    public GameObject emisorSonido;
    private AudioSource source;


    public void Start()
    {
        source = emisorSonido.GetComponent<AudioSource>();
       

    }

    public void Jugar()
    {
        Debug.Log("Continuar Jugando");
        SceneManager.LoadScene("Xim-Miners");
    }

    public void Salir()
    {
        Debug.Log("Ir al Menu");
        SceneManager.LoadScene("Menu");
    }




}
