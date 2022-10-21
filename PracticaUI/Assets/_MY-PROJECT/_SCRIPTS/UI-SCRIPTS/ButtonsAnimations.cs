using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsAnimations : MonoBehaviour
{
    public void ScaleUp()
    {
        LeanTween.scale(gameObject, Vector3.one * 1.5f, .5f).setEaseSpring();
    }
    public void ScaleDown()
    {
        LeanTween.scale(gameObject, Vector3.one, .5f);
    }
}
