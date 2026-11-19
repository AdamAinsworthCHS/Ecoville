using UnityEngine;
using UnityEngine.UI;

public class EndTurnButton : MonoBehaviour
{
    private Button button;
    private GameController gameController;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        //when pressed end the turn
        gameController.actions = gameController.maxActions;
        gameController.enviroscore += gameController.enviroscoreGain;
        gameController.money += gameController.revenue;
        gameController.monthCount +=1;

        int randomRoll = Random.Range(0, 100);

        int randomYesNo = Random.Range(0, 100);

        int randomChance = Random.Range(0, 100);

        if (randomRoll >= 30 && randomRoll < 60)
        {
            if (randomChance <= 15)
            {
                RandomEvent();
            }
        } else if (randomRoll >= 60)
        { 
            if (randomYesNo <= 25)
            {
                RandomEventYesNo();
            }
        }
        else
        {
            Debug.Log("No random event this turn.");
        }

        

        
    }

    void RandomEventYesNo()
    {         
        //random event occurs
        int rEvent = Random.Range(0, 5);
        if (rEvent == 0)
        { 
            
        }
        
        
    }

    void RandomEvent()
    {
        int randomEvent = Random.Range(0, 10);

        if (randomEvent == 0)
        {
            gameController.enviroscore -= 10;
            Debug.Log("A natural disaster has occurred! You lose 10 enviroscore.");
        }
        else if (randomEvent == 1)
        {
            gameController.enviroscore += 10;
            Debug.Log("A new technology has been discovered! You gain 10 enviroscore.");
        }
        else if (randomEvent == 2)
        {
            gameController.enviroscore += 5;
            Debug.Log("A new policy has been implemented! You gain 5 enviroscore.");
        } else if (randomEvent == 3)
        {
            gameController.enviroscore -= 5;
            Debug.Log("A new policy has been implemented! You lose 5 enviroscore.");
        } else
        {
            gameController.enviroscore += 15;
            Debug.Log("A new renewable energy source has been discovered! You gain 15 enviroscore.");


        }
    }
