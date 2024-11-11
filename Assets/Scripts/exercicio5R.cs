using UnityEngine;

public class exercicio5R : MonoBehaviour
{
    [SerializeField]int dificuldade = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 6; i++)
        {
            dificuldade+= 5;
            print(dificuldade);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
