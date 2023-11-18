using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyColors 
{

    private List<Color> myColors; // Хранилище цветов


    public void LoadMyColors(int i)  /// Какой-то метод, который можно поменять
    {
        myColors = new List<Color>();

        myColors.Add(Color.white);
        myColors.Add(Color.green);  
        myColors.Add(Color.red);
        while (i > myColors.Count)
            myColors.Add(new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f)));
    }

    public Color GetColor(int i)
    {
        if (i>=0 && i<myColors.Count)  return myColors[i]; 
        return Color.white;  // Чтобы не было краша... Правда врет и в логику не очень, может exception здесь лучше сделать
    }

}
