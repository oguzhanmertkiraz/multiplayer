﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public GameObject soundControlButton;
    public Sprite audioOffSprite;
    public Sprite audioOnSprite;

	//kullanma
	void Start () {

        if (AudioListener.pause == true)
        {
            soundControlButton.GetComponent<Image>().sprite = audioOffSprite;

        }
        else
        {
            soundControlButton.GetComponent<Image> ().sprite = audioOnSprite;
        }
	}
	

	void Update () {
		
	}
    public void SoundControl()
    {
        if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
        soundControlButton.GetComponent<Image> ().sprite = audioOnSprite;
        }
        else
        {
            AudioListener.pause = true;
            soundControlButton.GetComponent<Image> ().sprite = audioOffSprite;
        }
    }
}
