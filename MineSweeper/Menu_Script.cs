using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Script : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("Minesweeper");
    }   

    public void EndGame(){
        Application.Quit();
    }
}
