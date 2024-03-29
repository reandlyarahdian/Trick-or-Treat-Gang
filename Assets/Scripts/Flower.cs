using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    [SerializeField] PointSO one, two, three, four;
    public int point;
    [SerializeField] Transform flower;
    SpriteRenderer sprite;
    [SerializeField]
    float seconds;

    private void Start()
    {
        flower = this.GetComponent<Transform>();
        sprite = flower.gameObject.GetComponent<SpriteRenderer>();
        randomizeFlower();
    }

    public IEnumerator cooldownFlower()
    {
        FlowerCooldown();
        yield return new WaitForSecondsRealtime(seconds);
        randomizeFlower();
    }

    void randomizeFlower()
    {
        int i = Random.Range(1, 4);

        switch (i)
        {
            case 1:
                FlowerOne();
                break;
            case 2:
                FlowerTwo();
                break;
            case 3:
                FlowerThree();
                break;
        }
    }

    void FlowerOne()
    {
        sprite.sprite = one.sprite;
        point = one.point;
        flower.tag = one.taging;
    }
    void FlowerTwo()
    {
        sprite.sprite = two.sprite;
        point = two.point;
        flower.tag = two.taging;
    }
    void FlowerThree()
    {
        sprite.sprite = three.sprite;
        point = three.point;
        flower.tag = three.taging;
    }
    void FlowerCooldown()
    {
        sprite.sprite = four.sprite;
        point = four.point;
        flower.tag = four.taging;
        seconds = four.seconds;
    }
}
