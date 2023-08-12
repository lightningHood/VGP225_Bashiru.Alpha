using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridScript : MonoBehaviour
{
    public Button button;
    public Text buttonText;

    private GameController gameController;

    public void SetSpac()
    {
        if(gameController.playerMove == true) {
        buttonText.text = gameController.GetPlayerSide();
        button.interactable = false;
        gameController.EndTurn();
        }
    }

    public void SetGameControllerReference(GameController controller)
    {
        gameController = controller;
    }
}
