using UnityEngine;

public class exercicio4R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int pontos =0;
        for (int i = 0; i < 7; i++)
        {
            pontos+= 10;
        }
        print(pontos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
