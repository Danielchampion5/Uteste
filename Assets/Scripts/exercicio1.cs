using System;
using System.Globalization;
using System.Threading;
using UnityEngine;

public class NewMonoBehaviourScript1 : MonoBehaviour
{
    [SerializeField] int vida = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        combate();
    }

    void combate()
    {
        print("Voce estava em uma ardua batalha e se feriu muito");
        Thread.Sleep(2000);
        if (vida >= 1)
        {
            print("voce está vivo.");
        }
        else
        {
            print("voce morreu." +
                "\nreiniciar?");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
