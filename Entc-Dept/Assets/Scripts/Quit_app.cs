﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit_app : MonoBehaviour
{
    public void quit()
    {
        Debug.Log("Quitted");
        Application.Quit();
    }
}
