﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour {

	
    public void BackToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

}
