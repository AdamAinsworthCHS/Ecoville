using UnityEngine;
using UnityEngine.UI;

public class BuildingButton : MonoBehaviour
{
    private Button button;
    public GameObject building;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        //when pressed end the turn
        Instantiate(building);
    }
}
