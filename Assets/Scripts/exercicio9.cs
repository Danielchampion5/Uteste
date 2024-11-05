using UnityEngine;

public class exercicio9 : MonoBehaviour
{
    [SerializeField] int timea = 1;
    [SerializeField] int timeb = 2;
    [SerializeField] int partida = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timea > timeb) {
            print("Vitória do time A");
        }
        else if (timea < timeb) {
            print("Vitória do time B");
        }
        else if (timea == timeb) {
            print("Empate");
        } 
        else if(timea == timeb && partida >= 6) {
            print("Um Empate emocionante");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
