using System.Threading;
using UnityEngine;

public class exercicio8 : MonoBehaviour
{
    [SerializeField] int dias;
    [SerializeField] int horas;
    [SerializeField] int d;
    [SerializeField] int s = 0;
    /*(Contador de horas e dias) Crie um script que em que uma
vari�vel inteira hora seja incrementada de uma unidade a cada 10
segundos e volte a ser 0 quando alcan�ar o valor 24. Quando
completar um ciclo, incremente uma vari�vel dias e escreva o
n�mero de dias que se passaram no console. (Coloque o c�digo
dentro da fun��o-evento Update).
     */
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; d < dias;i++)
        {
            s+=1;
            if (s == 10)
            {
                horas += 1;
                if (horas == 24)
                {
                    d += 1;
                    print($"Se passaram {d}dias");
                    horas = 0;
                }
                s = 0;
            }
        }
    }
}
