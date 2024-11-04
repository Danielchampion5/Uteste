using UnityEngine;

public class exercicio2 : MonoBehaviour
{
    [SerializeField] bool powerup = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (powerup == true)
        {
            print("Power-up coletado");
        }
        else {
            print("Nenhum power-up encontrado");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
