using UnityEngine;

public class exercicio5 : MonoBehaviour
{
    [SerializeField] int pontosganhos = 50;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pontosganhos >= 50)
        {
            print("Missão bem-sucedida!");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
