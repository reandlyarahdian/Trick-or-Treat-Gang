using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool coin = false, nocoin = false, enemy = false, hive1 = false, hive0 = false, trap = false;
    public Flower flower;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "CoinedHouse":
                flower = collision.gameObject.GetComponent<Flower>();
                coin = true;
                break;
            case "House":
                flower = collision.gameObject.GetComponent<Flower>();
                nocoin = true;
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
                flower = collision.gameObject.GetComponent<Flower>();
                trap = true;
                break;
            default:
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        coin = false;
        nocoin = false;
        enemy = false;
        hive1 = false;
        hive0 = false;
        trap = false;
        flower = null;
    }
}
