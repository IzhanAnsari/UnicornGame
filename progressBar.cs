using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progressBar : MonoBehaviour
{
    public float carbCount {get; set;}
    public float maxHealth {get; set;}
    public Slider healthbar;
    public static bool hitItem =false;
    public static int itemVal;

    // Start is called before the first frame update
    void Start()
    {
        carbCount = 0;
        maxHealth = 300f;
        healthbar.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(hitItem){
            hitItem = false;
            addCarb(itemVal);
        }
    }

    void addCarb (float carbsToAdd)
    {
        carbCount += carbsToAdd;
        healthbar.value = CalculateHealth();
    }

    float CalculateHealth()
    {
        return carbCount/maxHealth;
    }

}
