using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Den : MonoBehaviour
{
    public static int meat;
    public static int fur;
    public static int bones;
    public static int wood;
    public static int stone;

    public Text meatText;
    public Text furText;
    public Text bonesText;
    public Text woodText;
    public Text stoneText;

    private int speedCost = 2;
    private int denCost = 2;
    private int damageCost = 2;

    private int denSize;

    void Update()
    {
        meatText.text = meat.ToString();
        furText.text = fur.ToString();
        bonesText.text = bones.ToString();
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
    }

    public void SpeedUpgrade()
    {
        if (fur > speedCost)
        {
            Move.speed += 2;
            fur -= speedCost;
            speedCost += 3;
        }
    }

    public void DenSize()
    {
        if (wood > denCost && stone > denCost)
        {
            denSize += 1;
            wood -= denCost;
            stone -= denCost;
            denCost += 5;
        }
    }

    public void DamageUpgrade()
    {
        if (bones > damageCost)
        {
            bones -= damageCost;
            damageCost += 2;
        }
    }
}
