using UnityEngine;

public class exercicio3R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int moedas = 0;
        for (int i = 0; i < 10; i++) {
            moedas += 3;
        }

        print(moedas);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
