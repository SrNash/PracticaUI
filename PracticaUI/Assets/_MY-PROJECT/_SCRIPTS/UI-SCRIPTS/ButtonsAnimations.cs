using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsAnimations : MonoBehaviour
{
    [SerializeField]
    Image img;
    [SerializeField]
    Color colorDef, colorHover, colorPress, colorExit;
    private void Start()
    {
        img = GetComponent<Image>();
    }
    public void ScaleUp()
    {
        //LeanTween.color(gameObject, colorHover, 0f);
        LeanTween.value(img.gameObject, setColor, colorDef, colorHover, .25f);
        LeanTween.scale(gameObject, (Vector3.one + new Vector3(0f, .125f, 0f)), .5f).setEaseSpring();
    }
    public void ScaleDown()
    {
        //LeanTween.color(gameObject, colorDef, 0f);
        LeanTween.value(img.gameObject, setColor, colorHover, colorDef, .25f);
        //LeanTween.imageColor();
        LeanTween.scale(gameObject, Vector3.one, .5f);
    }

    void setColor(Color c)
    {
        img.color = c;

        var tempColor = img.color;
        tempColor.a = 1f;
        img.color = tempColor;
    }
}
