using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorroutinesKid : MonoBehaviour
{
    public static IEnumerator ImageToColorAnim(Material material, Color target, int frames)
    {
        Color deltaColor = (target - material.color) / frames;

        Color tempColor = material.color;

        for (int i = 0; i < frames; i++)
        {
            tempColor += deltaColor;
            //material.shade = tempColor;

            yield return null;
        }
        print("chenged");
    }
}
