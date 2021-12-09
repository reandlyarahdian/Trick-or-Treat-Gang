using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool coin = false, enemy = false, hive1 = false, hive0 = false, trap = false;
    public Flower flower;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "CoinedHouse":
                coin = true;
                flower = collision.gameObject.GetComponent<Flower>();
                break;
            case "Hive":
                if(collision.name == "Hive 0")
                {
                    hive0 = true;
                }else if (collision.name == "Hive 1")
                {
                    hive1 = true;
                }
                break;
            case "Player":
                enemy = true;
                break;
            case "Trap":
                trap = true;
                flower = collision.gameObject.GetComponent<Flower>();
                break;
            default:
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        coin = false;
        enemy = false;
        hive1 = false;
        hive0 = false;
        trap = false;
        flower = null;
    }
}
