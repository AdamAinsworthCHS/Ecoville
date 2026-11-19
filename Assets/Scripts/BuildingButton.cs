using UnityEngine;
using UnityEngine.UI;

public class BuildingButton : MonoBehaviour
{
    private Button button;
    public GameObject building;
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
        //when pressed make the building
        if (gameController.placingBuilding == false)
        {
            if (gameController.actions > 0)
            {
                if (building.GetComponent<Building>().cost <= gameController.money)
                {
                    gameController.actions -= 1;
                    gameController.money -= building.GetComponent<Building>().cost;
                    gameController.placingBuilding = true;
                    Instantiate(building);
                }
            }
        }
    }
}
