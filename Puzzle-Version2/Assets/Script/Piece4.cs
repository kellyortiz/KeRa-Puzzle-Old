using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece4 : MonoBehaviour
{

    [SerializeField]

    private Transform Place4;
    private Vector2 initialPosition;
    private Vector2 mousePosition;
    private float deltaX, deltaY;
    public bool locked;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = (GameManager)FindObjectOfType(typeof(GameManager));
        initialPosition = transform.position;
    }

    private void OnMouseDown()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - Place4.position.x) <= 0.5f &&
           Mathf.Abs(transform.position.y - Place4.position.y) <= 0.5f)
        {
            transform.position = new Vector2(Place4.position.x, Place4.position.y);
            locked = true;

            gameManager.IsGameOver();
        }
        else
        {
            transform.position = new Vector2(initialPosition.x, initialPosition.y);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}