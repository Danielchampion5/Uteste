using UnityEngine;

public class exercicio10 : MonoBehaviour
{
    [SerializeField] int item = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (item) { 
            case 1: print("Voce coletou a poc�o de cura que recupera 25% de sua vida.");
                break;
            case 2:
                print("Voce coletou as botas de velocidade que se equipadas d�o mais 15% de velocidade de corrida");
                break;
            case 3:
                print("Voce coletou uma espada enferrujada de ferro negro que possui:" +
                    "15/100 durabilidade  7,5 ataque  2,75s cadencia  20Kg");
                break;
            case 4:
                print("Voce coletou o elmo quebrado de Aron que d� a voce mais 5% de sorte");
                break;
            case 5:
                print("Voce coletou a pedra da lua que � um item necess�rio para achar o santu�rio da lua");
                break;
                default:
                print("Item n�o encontrado");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
