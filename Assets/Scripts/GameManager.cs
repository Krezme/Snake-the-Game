using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject snakePrefab;
    public Vector3 startPos;
    public GameObject bodyPrefab;
    private int amountOfParts = 0;
    private GameObject currectBodyPart;
    public GameObject headPrefab;
    private GameObject head;
    private GameObject snake;

	void Awake () {
        snake = Instantiate(snakePrefab);
        head = Instantiate(headPrefab);
        head.transform.SetParent(snake.transform);
        head.transform.position = startPos;
    }
}
