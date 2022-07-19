using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDatabase : MonoBehaviour
{
    public List<GameObject> breakfast1 = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        breakfast1.Add(GameObject.Find("oatmeal"));
        Debug.Log(breakfast1[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    //public GameObject[] breakfast2 = gameObject.find("oatmeal"), gameObject.find("nuts"), gameObject.find("blueberries"), gameObject.find("milk Variant");
    //public GameObject[] lunch1 = gameObject.find("sandwhich"), gameObject.find("strawberries");
    //public GameObject[] lunch2 = gameObject.find("meat"), gameObject.find("potato"), gameObject.find("broccoli"), gameObject.find("strawberries");
    //public GameObject[] snack1 = gameObject.find("grapes"), gameObject.find("nuts");
    //public GameObject[] snack2 = gameObject.find("apple"), gameObject.find("stringCheese");
    //public GameObject[] snack3 = gameObject.find("cheeseCrackers"), gameObject.find("cheeseCrackers"), gameObject.find("cheeseCrackers");
    //public GameObject[] snack4 = gameObject.find("grahamCracker"), gameObject.find("grahamCracker"), gameObject.find("grahamCracker"),gameObject.find("peanutbutter");
    //public GameObject[] dinner1 = gameObject.find("taco"), gameObject.find("blueberries"), gameObject.find("nuts"), gameObject.find("milk Variant");
    //public GameObject[] dinner2 = gameObject.find("meat"), gameObject.find("brownrice"), gameObject.find("broccoli"), gameObject.find("fudgesicle");
}
