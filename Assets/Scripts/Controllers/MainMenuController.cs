using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    private Animator mainAnim, ballAnim;

    void Awake()
    {
        mainAnim = GameObject.Find("Main Holder").GetComponent<Animator>();
        ballAnim = GameObject.Find("Balls Holder").GetComponent<Animator>();

    }

    public void PalyGame()
    {
        Application.LoadLevel("Gameplay");
    }

    public void SelectBall()
    {
        mainAnim.Play("FadeOut Animation");
        ballAnim.Play("Fadein Animation");
    }

    public void BackToMenu()
    {
        mainAnim.Play("Fadein Animation");
        ballAnim.Play("FadeOut Animation");
    }


}
