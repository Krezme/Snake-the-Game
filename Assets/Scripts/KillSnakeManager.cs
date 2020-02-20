using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillSnakeManager : MonoBehaviour {

    private SnakeController snakeController;

	// Use this for initialization
	void Start () {
        snakeController = this.GetComponent<SnakeController>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Body") {
            snakeController.isSnakeAlive = false;
            snakeController.enabled = false;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Border") {
            Destroy(this.gameObject);
        }
    }
}
