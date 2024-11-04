using UnityEngine;

public class exercicio3 : MonoBehaviour
{
    [SerializeField] int vidaplayer = 10;
    [SerializeField] bool power_up = true;
    [SerializeField] bool livingplayer = true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (livingplayer == true) { return; }
        else {
            if (power_up == true)
            {
                print("Power-up elixir da vida utilizado");

               int vidaplayer2 = vidaplayer/2;

                print($"Ainda não, vida atual {vidaplayer2}");
            }
            else
            {
                print("GAME OVER");
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
