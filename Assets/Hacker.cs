﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Game state
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;
    string password;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // OnUserInput is called whenever the user hits return
    void OnUserInput(string input)
	{
        if (input == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
	}

    // Clear terminal and show main menu
    void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the police station");
        Terminal.WriteLine("Press 3 for NASA");
        Terminal.WriteLine("");
        Terminal.WriteLine("Enter your selection:");
    }

    void RunMainMenu(string input)
    {
        if (input == "1")
        {
            level = 1;
            password = "Memphis";
            StartGame();
        }
        else if (input == "2")
        {
            level = 2;
            password = "Dylan";
            StartGame();
        }
        else if (input == "3")
        {
            level = 3;
            password = "Hamachi";
            StartGame();
        }
        else
        {
            Terminal.WriteLine("Please choose a valid level");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
        Terminal.WriteLine("Please enter your password:");
    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            WinScreen();
        }
        else
        {
            Terminal.WriteLine("Incorrect, please try again");
        }
    }

    void WinScreen() {
        currentScreen = Screen.Win;
        Terminal.WriteLine("Congrats, you have hacked in!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
