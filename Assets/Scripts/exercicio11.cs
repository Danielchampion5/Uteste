using UnityEngine;

public class exercicio11 : MonoBehaviour
{
    [SerializeField] int resposta = 2;
    [SerializeField] int resposta2 = 1;
    [SerializeField] int resposta3 = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (resposta) {
            case 1:
                print("a");

                switch (resposta2)
                {
                    case 1:
                        print("b");
                        switch (resposta3) {
                            case 1:
                                print("c");
                                break;
                            case 2:
                                print("d");
                                break;
                            case 3:
                                print("e");
                                break;
                            default:
                                print("f");
                                break;
                        }
                        break;
                    case 2:
                        print("g");
                        switch (resposta3)
                        {
                            case 1:
                                print("h");
                                break;
                            case 2:
                                print("i");
                                break;
                            case 3:
                                print("j");
                                break;
                            default:
                                print("k");
                                break;
                        }
                        break;
                    case 3:
                        print("l");
                        switch (resposta3)
                        {
                            case 1:
                                print("m");
                                break;
                            case 2:
                                print("n");
                                break;
                            case 3:
                                print("o");
                                break;
                            default:
                                print("p");
                                break;
                        }
                        break;
                    default:
                        print("q");
                        break;
                }
                break;
            case 2:
                print("r");
                switch (resposta2)
                {
                    case 1:
                        print("s");
                        switch (resposta3)
                        {
                            case 1:
                                print("t");
                                break;
                            case 2:
                                print("u");
                                break;
                            case 3:
                                print("v");
                                break;
                            default:
                                print("w");
                                break;
                        }
                        break;
                    case 2:
                        print("x");
                        switch (resposta3)
                        {
                            case 1:
                                print("y");
                                break;
                            case 2:
                                print("z");
                                break;
                            case 3:
                                print("a1");
                                break;
                            default:
                                print("b1");
                                break;
                        }
                        break;
                    case 3:
                        print("c1");
                        switch (resposta3)
                        {
                            case 1:
                                print("d1");
                                break;
                            case 2:
                                print("e1");
                                break;
                            case 3:
                                print("f1");
                                break;
                            default:
                                print("g1");
                                break;
                        }
                        break;
                }
                break;
            
            case 3:
                print("h1");
                switch (resposta2)
                {
                    case 1:
                        print("i1");
                        switch (resposta3)
                        {
                            case 1:
                                print("j1");
                                break;
                            case 2:
                                print("k1");
                                break;
                            case 3:
                                print("l1");
                                break;
                            default:
                                print("m1");
                                break;
                        }
                        break;
                    case 2:
                        print("n1");
                        switch (resposta3)
                        {
                            case 1:
                                print("o1");
                                break;
                            case 2:
                                print("p1");
                                break;
                            case 3:
                                print("q1");
                                break;
                            default:
                                print("r1");
                                break;
                        }
                        break;
                    case 3:
                        print("s1");
                        switch (resposta3)
                        {
                            case 1:
                                print("t1");
                                break;
                            case 2:
                                print("u1");
                                break;
                            case 3:
                                print("v1");
                                break;
                            default:
                                print("w1");
                                break;
                        }
                        break;
                }
                break;

                default:
                print("x1");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
