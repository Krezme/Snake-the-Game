using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour {

    
    public float waitForSeconds;

    public GameObject bodyPrefab;
    private GameObject body;

    private GameObject snake;

    private string currentDirection = "Right";
    private float xMovement = 0.5f;
    private float yMovement = 0.5f;
    private bool isDiractionChanged = false;
    public List<Vector2> snakeMoveLocation = new List<Vector2>();
    public int snakeLenght = 2;
    public bool isSnakeAlive = true;


    void Start() {
        snake = GameObject.FindGameObjectWithTag("Snake");
        snakeMoveLocation.Insert(0, new Vector3(3, 5, 0));
        snakeMoveLocation.Insert(0, new Vector3(3.5f, 5, 0));
        StartCoroutine(WaitForSeconds());
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && currentDirection != "Down" && isDiractionChanged == false && currentDirection != "Up") {
            currentDirection = "Up";
            isDiractionChanged = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow) && currentDirection != "Up" && isDiractionChanged == false && currentDirection != "Down")
        {
            currentDirection = "Down";
            isDiractionChanged = true;
        } 
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow) && currentDirection != "Right" && isDiractionChanged == false && currentDirection != "Left")
        {
            currentDirection = "Left";
            isDiractionChanged = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow) && currentDirection != "Left" && isDiractionChanged == false && currentDirection != "Right")
        {
            currentDirection = "Right";
            isDiractionChanged = true;
        }
    }

    IEnumerator WaitForSeconds() {
        
        snakeMoveLocation.Insert(0, transform.position);
        if (currentDirection == "Right")
        {
            transform.position = new Vector3(transform.position.x + xMovement, transform.position.y, -1);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (currentDirection == "Left")
        {
            transform.position = new Vector3(transform.position.x - xMovement, transform.position.y, -1);
            transform.eulerAngles = new Vector3(0, 0, 180);
        }
        else if (currentDirection == "Up")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + yMovement, -1);
            transform.eulerAngles = new Vector3(0, 0, 90);
        }
        else if (currentDirection == "Down")
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - yMovement, -1);
            transform.eulerAngles = new Vector3(0, 0, 270);
        }
        if (isSnakeAlive == true) {
            foreach (GameObject gO in GameObject.FindGameObjectsWithTag("Body"))
            {
                Destroy(gO);
            }
            isDiractionChanged = false;
            if (snakeMoveLocation.Count > snakeLenght) {
                snakeMoveLocation.RemoveAt(snakeMoveLocation.Count - 1);
            }
            for (int i = 0; i < snakeMoveLocation.Count; i++) {
                body = Instantiate(bodyPrefab);
                body.transform.SetParent(snake.transform);
                body.transform.position = new Vector3(snakeMoveLocation[i].x, snakeMoveLocation[i].y, -1);
            }
        }
        yield return new WaitForSecondsRealtime(waitForSeconds);
        if (isSnakeAlive == true) {
            StartCoroutine(WaitForSeconds()); 
        }
    }
}
