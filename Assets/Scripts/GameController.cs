using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Game Stats")]
    public int actions;
    public int maxActions;
    public int money;
    public int politicalPower;
    public int monthCount;
    public float enviroscoreGain;
    public float enviroscore;
    public int revenue;

    [Header("Game Handling Variables")]
    public bool placingBuilding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placingBuilding = false;
        enviroscore = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
