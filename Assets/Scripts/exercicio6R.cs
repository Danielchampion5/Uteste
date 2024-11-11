using UnityEngine;

public class exercicio6R : MonoBehaviour
{
    int numero = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10000; i++) {
            int resultado3 = numero % 3;
            int resultado5 = numero % 5;

            if (resultado3 == 0)
            {
                print("fizz");
            }
            else if (resultado5 == 0)
            {
                print("buzz");
            }
            else if (resultado3 == 0 && resultado5 == 0)
            {
                print("fizz buzz");
            }

            else {
                print(numero);
            }

            numero++;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
