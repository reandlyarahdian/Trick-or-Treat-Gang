using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Actioning : MonoBehaviour
{
    private Node node;

    private void Start()
    {
        if(node == null)
        {
            node = GetComponentInChildren<Node>();
        }
    }

    public void Reaction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (node.coin)
            {
                coin(node.flower);
            }
            else if (node.hive0)
            {
                hive(0);
            }
            else if (node.hive1)
            {
                hive(1);
            }
            else if (node.enemy)
            {
                enemy();
            }
            else if (node.trap)
            {
                trap(node.flower);
            }
        }
    }

    private void enemy()
    {
        Debug.Log("Attacked");
    }

    private void hive(int index)
    {
        if(index == 0) 
        {
            Debug.Log(index);
        }
        else
        {
            Debug.Log(index);
        }
    }

    private void coin(Flower flower)
    {
        StartCoroutine(flower.cooldownFlower());
    }
    public void trap(Flower flower)
    {
        StartCoroutine(flower.cooldownFlower());
    }
}
