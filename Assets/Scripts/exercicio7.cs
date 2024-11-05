using UnityEngine;

public class exercicio7 : MonoBehaviour
{
    [SerializeField] int dados = 12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int resultado = Random.Range(1, dados);
        print(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
