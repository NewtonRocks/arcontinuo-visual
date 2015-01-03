﻿using UnityEngine;
using System.Collections;

public class StageManager : MonoBehaviour {
	public static StageManager instance;
	[SerializeField] int m_currentStage = 0;
	public static int currentStage{
		get{ return instance.m_currentStage; }
		set{ instance.m_currentStage = value; }
	}

	void Awake(){
		instance = this;
	}
	void Update(){
		if(Input.GetKeyDown(KeyCode.Alpha0)){
			StageManager.currentStage = 0;
		} else if(Input.GetKeyDown(KeyCode.Alpha1)){
			StageManager.currentStage = 1;
		} else if(Input.GetKeyDown(KeyCode.Alpha2)){
			StageManager.currentStage = 2;
		} else if(Input.GetKeyDown(KeyCode.Alpha3)){
			StageManager.currentStage = 3;
		}
	}

}
