using UnityEngine;

public class exercicio2R : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int ataque = 1;
        for (int i = 0; i < 5; i++) {
            
            print( ataque );
           ataque  = ataque * 2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
