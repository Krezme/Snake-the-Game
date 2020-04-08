using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
	
	private Animator animator;
	private GameObject player;

	public GameObject menuWindow;
	public GameObject snakeBodyManager;
	private bool menuState = false;

	void Start () {
		animator = menuWindow.GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag("Head");
	}

	void Update () {
		player = GameObject.FindGameObjectWithTag("Head");
		if (Input.GetKeyDown("escape") && menuState == false) {
			/*snakeBodyManager.GetComponent<SnakePrefabController>().enabled = false;
			this.GetComponent<GameManager>().enabled = false;
			player.GetComponent<SnakeController>().enabled = false;
			player.GetComponent<FoodController>().enabled = false;
			player.GetComponent<KillSnakeManager>().enabled = false;*/
			animator.Play("Menu Slide Down");
			menuState = true;		
		} else if (Input.GetKeyDown("escape") && menuState == true) {
			animator.Play("Menu Slide Up");
			/*snakeBodyManager.GetComponent<SnakePrefabController>().enabled = true;
			this.GetComponent<GameManager>().enabled = true;
			player.GetComponent<SnakeController>().enabled = true;
			player.GetComponent<FoodController>().enabled = true;
			player.GetComponent<KillSnakeManager>().enabled = true;*/
			menuState = false;	
		}
	}

	public void InGameMenuSrollDown() {

	}

	public void InGameMenuSrollUp() {

	}
}
