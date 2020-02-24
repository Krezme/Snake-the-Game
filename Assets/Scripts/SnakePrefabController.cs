using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakePrefabController : MonoBehaviour {

    public GameObject[] snakeSpritesHead;
    public GameObject[] snakeSpritesBody;

    private GameObject gameManager;

    static public int choosenSnakeStatic;
    public int choosenSnake;

    void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameManager");
        choosenSnake = choosenSnakeStatic;
    }

    public void DefaultSnakeActivation() {
        choosenSnakeStatic = 0;
        choosenSnake = choosenSnakeStatic;
    }

    public void DesertSnakeActivation() {
        choosenSnakeStatic = 1;
        choosenSnake = choosenSnakeStatic;
    }

    public void DarkGreenSnakeActivation() {
        choosenSnakeStatic = 2;
        choosenSnake = choosenSnakeStatic;
    }
}
