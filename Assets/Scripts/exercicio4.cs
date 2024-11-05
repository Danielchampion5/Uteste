using UnityEngine;

public class exercicio4 : MonoBehaviour
{
    [SerializeField] bool pocuipotion;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pocuipotion == true)
        {
            print("Usando Poção de Vida");
        }
        else {
            print("Poção indisponível");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
