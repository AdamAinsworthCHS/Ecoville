using UnityEngine;
using UnityEngine.UI;

public class TabButton : MonoBehaviour
{
    private GameObject buildingsTab;
    private GameObject policiesTab;
    private GameObject researchTab;
    private Button button;
    public string tab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = this.GetComponent<Button>();
        button.onClick.AddListener(TaskOnClick);

        buildingsTab = GameObject.Find("BuildingsButtonContainer");
        policiesTab = GameObject.Find("PoliciesButtonContainer");
        researchTab = GameObject.Find("ResearchButtonContainer");

        buildingsTab.GetComponent<CanvasGroup>().alpha = 1;
        buildingsTab.GetComponent<CanvasGroup>().interactable = true;

        policiesTab.GetComponent<CanvasGroup>().alpha = 0;
        policiesTab.GetComponent<CanvasGroup>().interactable = false;

        researchTab.GetComponent<CanvasGroup>().alpha = 0;
        researchTab.GetComponent<CanvasGroup>().interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick()
    {
        //when pressed change the tab
        if (tab == "Buildings")
        {
            buildingsTab.GetComponent<CanvasGroup>().alpha = 1;
            buildingsTab.GetComponent<CanvasGroup>().interactable = true;

            policiesTab.GetComponent<CanvasGroup>().alpha = 0;
            policiesTab.GetComponent<CanvasGroup>().interactable = false;

            researchTab.GetComponent<CanvasGroup>().alpha = 0;
            researchTab.GetComponent<CanvasGroup>().interactable = false;
        }
        else if (tab == "Policies")
        {
            buildingsTab.GetComponent<CanvasGroup>().alpha = 0;
            buildingsTab.GetComponent<CanvasGroup>().interactable = false;

            policiesTab.GetComponent<CanvasGroup>().alpha = 1;
            policiesTab.GetComponent<CanvasGroup>().interactable = true;

            researchTab.GetComponent<CanvasGroup>().alpha = 0;
            researchTab.GetComponent<CanvasGroup>().interactable = false;
        }
        else if (tab == "Research")
        {
            buildingsTab.GetComponent<CanvasGroup>().alpha = 0;
            buildingsTab.GetComponent<CanvasGroup>().interactable = false;

            policiesTab.GetComponent<CanvasGroup>().alpha = 0;
            policiesTab.GetComponent<CanvasGroup>().interactable = false;

            researchTab.GetComponent<CanvasGroup>().alpha = 1;
            researchTab.GetComponent<CanvasGroup>().interactable = true;
        }
    }
}
