using UnityEngine;

public class EnvirocoreGainText : MonoBehaviour
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
        GetComponent<TMPro.TextMeshProUGUI>().text = "Enviroscore Gain: " + gameController.enviroscoreGain;
    }
}
