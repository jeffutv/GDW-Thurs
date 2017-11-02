﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float speed;
	public bool gameActive;
	public GameObject menuPanel;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (gameActive) {
			float moveH = Input.GetAxis ("Horizontal");
			float moveV = Input.GetAxis ("Vertical");
			Vector3 move = new Vector3 (moveH, 0.0f, moveV);
			rb.AddForce (move * speed);
		}

		if (Input.GetButtonUp ("Cancel")) {
			if (gameActive) {
				gameActive = false;
				menuPanel.SetActive (true);
				Time.timeScale = 0;
			} else {
				gameActive = true;
				menuPanel.SetActive (false);
				Time.timeScale = 1;
			}
		}

	}

	public void StartGame() {
		gameActive = true;
//		SceneManager.LoadSceneAsync ("Main Game");
	}

	public void QuitGame() {
		Application.Quit ();
	}
}












