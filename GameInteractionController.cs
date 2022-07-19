using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInteractionController : MonoBehaviour
{
    public int itemValue;
    public static int collectedValueSum;
    public int collectedFoodCount;
    public int unicornStatus;
    public Button eatButton;
    public bool eatBool;
    public Text congratsText;
    public Text scoreText;
    public Text foodCountText;
    public Text HUDText;
    public GameObject endingPanel;
    public Image buddyHead1;
    public Image buddyHead2;
    public Image buddyHead3;
    public Image foodCheck1;
    public Image foodCheck2;
    public Image foodCheck3;
    public Image foodCheck4;
    public static int goalValue;
    public string newLine = System.Environment.NewLine;
    public int starCounter;


    // Start is called before the first frame update
    void Start()
    {
        collectedValueSum = 0;
        collectedFoodCount = 0;
        starCounter = 0;

        eatBool = false;
        goalValue = Random.Range(71,199);
        endingPanel.SetActive(false);

        if(foodCheck1 != null)      foodCheck1.enabled = false;
        if(foodCheck2 != null)      foodCheck2.enabled = false;
        if(foodCheck3 != null)      foodCheck3.enabled = false;
        if(foodCheck4 != null)      foodCheck4.enabled = false;

        if(buddyHead1 != null)      buddyHead1.enabled = false;
        if(buddyHead2 != null)      buddyHead2.enabled = false;
        if(buddyHead3 != null)      buddyHead3.enabled = false;

        

    }

    // Update is called once per frame
    void Update()
    {
        HUDText.text = "Score: "+ collectedValueSum + newLine + "Goal: " + goalValue;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("character hit " + other.gameObject.name);

        if (other.gameObject.tag.Contains("food") & (eatButtonScript.ispressed || Input.GetKey(KeyCode.Space)))
        {
            if (other.gameObject.tag.Contains("1")){foodCheck1.enabled = true;}
            if (other.gameObject.tag.Contains("2")){foodCheck2.enabled = true;}
            if (other.gameObject.tag.Contains("3")){foodCheck3.enabled = true;}
            if (other.gameObject.tag.Contains("4")){foodCheck4.enabled = true;}

            collectedFoodCount++;
            progressBar.itemVal = other.gameObject.GetComponent<coinScript>().foodValue;
            progressBar.hitItem = true;
            collectedValueSum = collectedValueSum + other.gameObject.GetComponent<coinScript>().foodValue;
           // Debug.Log("coin is worth: " + other.gameObject.GetComponent<coinScript>().foodValue + ". Stored Value: " + collectedValueSum);
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag.Contains("Buddy"))
        {
            if (other.gameObject.tag.Contains("1")){buddyHead1.enabled = true;}
            if (other.gameObject.tag.Contains("2")){buddyHead2.enabled = true;}
            if (other.gameObject.tag.Contains("3")){buddyHead3.enabled = true;}
            Destroy(other.gameObject);
            unicornStatus++;
            if (unicornStatus == 3)
            {
                //transformToUnicornFunction();
                //unicornStatus = 0;
            }
            //Somehow need to arrange the buddies in the HUD based on which ones we collect.

        }

        if (other.gameObject.name.Contains("finish"))
        {
            Destroy(other.gameObject);
            gameObject.GetComponent<playerInputController>().allowedToMove = false;
            endingPanel.SetActive(true);
            // replayBut.SetActive(true);
            // nextLevBut.SetActive(true);
            congratsText.text = "finished";

            starCalculate();

            scoreText.text = "Score: " + collectedValueSum + " " + starCounter;
            if (collectedValueSum > goalValue)
            {
                scoreText.text += newLine + "(over by " + (collectedValueSum - goalValue) + ")";
            }
            else if (goalValue > collectedValueSum)
            {
                scoreText.text += newLine + "(under by " + (goalValue - collectedValueSum) + ")";
            }
            else
            {
                scoreText.text += newLine + "(PERFECT SCORE)";
            }
            
            foodCountText.text = "Food Count: " + collectedFoodCount;

        }
    }

    public static int getGoalValue ()
    {
        return goalValue;
    }

    public static int getCarbScore ()
    {
        return collectedValueSum;
    }

    public void starCalculate()
    {
        if (70 <= collectedValueSum && collectedValueSum <= 200)
        {
            starCounter ++;
        }
        
        if(collectedValueSum < goalValue+10 && goalValue-10 < collectedValueSum) //allows for +- 10 buffer
        {
            starCounter ++;
        }

        if(foodCheck1.enabled && foodCheck2.enabled && foodCheck3.enabled && foodCheck4.enabled)
        {
            starCounter ++;
        }
    }

}