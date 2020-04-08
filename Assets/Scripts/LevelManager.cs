using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public void LoadGameNormal() {
        Application.LoadLevel("Game");
    }

    public void LoadGameBorderless()
    {
        Application.LoadLevel("GameBorderless");
    }

    public void LoadSnakeLibrary() {
        Application.LoadLevel("SnakeLibrary");
    }

    public void LoadMenu() {
        Application.LoadLevel("Menu");
    }

    public void LoadGameMode() {
        Application.LoadLevel("GameMode");
    }

    public void QuitGame() {
        Debug.Log("Quitting Application");
        Application.Quit();
    }
}
