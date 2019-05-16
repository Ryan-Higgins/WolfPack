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

    void Update()
    {
        meatText.text = meat.ToString();
        furText.text = fur.ToString();
        bonesText.text = bones.ToString();
        woodText.text = wood.ToString();
        stoneText.text = stone.ToString();
    }
}
