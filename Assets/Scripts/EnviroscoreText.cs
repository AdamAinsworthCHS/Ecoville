using UnityEngine;

public class EnviroscoreText : MonoBehaviour
{
    private GameController gameController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameController = GameObject.Find("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = "Enviroscore: " + gameController.enviroscore;
    }
}
