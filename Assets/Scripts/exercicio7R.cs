using System.Collections.Generic;
using UnityEngine;

public class exercicio7R : MonoBehaviour
{
    List<int> nums = new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nums.Add(1); //Indice 0
        nums.Add(2); //Indice 1
        nums.Add(3); //Indice 2
        nums.Add(4); //Indice 3
        nums.Add(4); //Indice 4
        nums.Add(5); //Indice 5
        nums.Add(6); //Indice 6
        nums.Add(7); //Indice 7
        nums.Add(8); //Indice 8

        nums.Sort();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
