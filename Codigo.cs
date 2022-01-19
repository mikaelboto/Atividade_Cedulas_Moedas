using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula : MonoBehaviour
{
    [SerializeField] float money1;
    [SerializeField] int[] money;
    [SerializeField] int[] moeda;


    void Start()

    {
        int nota = 0;
        int moeda1 = 0;

        for (int i = 0; i < money.Length; i++)
        {
            if (money1 >= money[i])
            {
                nota = (int)money1 / money[i];
                money1 = money1 - nota * money[i];
                Debug.Log("Quantidade de notas de " + money[i] + ": " + nota);
            }
        }

        {
            money1 = money1 * 100;
            for (int i = 0; i < moeda.Length; i++)
            {
                if (money1 >= moeda[i])
                {
                    moeda1 = (int)money1 / moeda[i];
                    money1 = (money1 - moeda1 * moeda[i]);
                    Debug.Log("Quantidade de moedas de " + moeda[i] + ": " + moeda1);

                }

            }
        }
    }
}