using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("Game");

    }

    public void Exit(){
        Application.Quit();
    }
}
