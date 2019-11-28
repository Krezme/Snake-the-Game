using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour {

    private SnakeController snakeController;

    private int score;

    private Vector3 foodSpawnPoint;

    public GameObject foodPrefab;
    private GameObject food;
    private bool isThereABodyPart;

    private float[] xPositions = new float[36] {0, 0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f, 5, 5.5f, 6, 6.5f, 7, 7.5f, 8, 8.5f, 9, 9.5f, 10, 10.5f, 11, 11.5f, 12, 12.5f, 13, 13.5f, 14, 14.5f, 15, 15.5f, 16, 16.5f, 17, 17.5f};
    private float[] yPositions = new float[20] {0, 0.5f, 1, 1.5f, 2, 2.5f, 3, 3.5f, 4, 4.5f, 5, 5.5f, 6, 6.5f, 7, 7.5f, 8, 8.5f, 9, 9.5f};

    void Start() {
        snakeController = GameObject.FindGameObjectWithTag("Head").GetComponent<SnakeController>();
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Food") { 
            Destroy(other.gameObject);
            snakeController.snakeLenght += 20;
            score += 10;
            FoodSpawner();
        }
    }

    void FoodSpawner() {
        foodSpawnPoint = new Vector3();
        foodSpawnPoint = new Vector3(xPositions[Random.Range(0, xPositions.Length)], yPositions[Random.Range(0, yPositions.Length)], -1);
        isThereABodyPart = false;
        foreach (Vector3 vec3 in snakeController.snakeMoveLocation) {
            if (new Vector3(vec3.x, vec3.y, 0) == new Vector3(foodSpawnPoint.x, foodSpawnPoint.y, 0))
            {
                isThereABodyPart = true;
            }
        }

        if (isThereABodyPart == true)
        {
            FoodSpawner();
        }
        else if (isThereABodyPart == false)
        {
            food = Instantiate(foodPrefab);
            food.transform.position = foodSpawnPoint;
        }
    }
}
