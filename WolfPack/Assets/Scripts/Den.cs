using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Den : MonoBehaviour
{
    public static int meat;
    public static int fur;
    public static int bones;
    public static int wood;
    public static int stone;

    public static List<GameObject> pack;

    public Text meatText;
    public Text furText;
    public Text bonesText;
    public Text woodText;
    public Text stoneText;

    public Text speedText;
    public Text denText;
    public Text damageText;

    private int speedCost = 2;
    private int denCost = 2;
    private int damageCost = 2;

    private int denSize;

    void Start()
    {
        pack = new List<GameObject>();
    }

    void Update()
    {
        meatText.text = meat.ToString();
        furText.text = fur.ToString();
        bonesText.text = bones.ToString();
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();

        speedText.text = "Speed Cost: " + speedCost;
        denText.text = "Size Cost: " + denCost;
        damageText.text = "Damage Cost: " + damageCost;
    }

    public void SpeedUpgrade()
    {
        if (fur >= speedCost)
        {
            Move.speed += 2;
            fur -= speedCost;
            speedCost += 3;
        }
    }

    public void DenSize()
    {
        if (wood >= denCost && stone >= denCost)
        {
            denSize += 1;
            wood -= denCost;
            stone -= denCost;
            denCost += 5;
        }
    }

    public void DamageUpgrade()
    {
        if (bones >= damageCost)
        {
            bones -= damageCost;
            damageCost += 2;
        }
    }
}
