using UnityEngine;

public class exercicio6 : MonoBehaviour
{
    [SerializeField] bool magoescolhido;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (magoescolhido == true) {
            print("Mago escolhido");
        }
        else {
            print("Guerreiro escolhido");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
