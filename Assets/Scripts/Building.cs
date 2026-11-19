using UnityEngine;

public class Building : MonoBehaviour
{
    public bool placed;
    public bool canBePlaced;
    Vector2 trueMousePos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placed = false;
        canBePlaced = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (canBePlaced == true && placed == false)
        {
            this.GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (canBePlaced == false && placed == false)
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (placed == false)
        {
            trueMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = trueMousePos;
            if (Input.GetMouseButtonDown(0))
            {
                if (canBePlaced == true)
                {
                    placed = true;
                    this.GetComponent<SpriteRenderer>().color = Color.white;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Building"))
        {
            canBePlaced = false;
            Debug.Log("entered trigger");
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Building"))
        {
            canBePlaced = true;
        }
    }
}
