
//ООП - Обьектно ориентированное программирование
// Обьект - данные + логика

using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerPointsText;
  //  public TextMeshProUGUI AIPointsText;
    public int PlayerPoints;
 //   public int AIPoints;

    public int PlayerSelectedValue;

    public Choices playerChoice;

    public void AddOnePoint()
    {
        PlayerPoints = PlayerPoints + 1;
        PlayerPointsText.text = "ОчкиИгрок: " + PlayerPoints;
    }
/*
    public void AddOnePointAI()
    {
        AIPoints = AIPoints + 1;
        AIPointsText.text = "ОчкиAI: " + AIPoints;
    }
*/
/*
    public void SubtractOnePointAI()
    {
        PlayerPoints = AIPoints - 1;
        PlayerPointsText.text = "ОчкиAI: " + PlayerPoints;
    }
*/
    public void SubtractOnePoint()
    {
        PlayerPoints = PlayerPoints - 1;
        PlayerPointsText.text = "ОчкиИгрок: " + PlayerPoints;
    }

    // 0-0 1-1 2-2 - Ничья
    // 0-1 = -1 Проиграли 
    // 1-2 = -1 Проиграли
    // 2-0 = 2 Проиграли
    
    //1-0 = 1 Выиграли
    //2-1 = 1 Выиграли
    //0-2 = -2 Выиграли
    public void SelectRock()
    {
        playerChoice = Choices.Rock;
        CheckWin((int)playerChoice);
    }

    public void SelectPaper()
    {
        CheckWin(1);
    }

    public void SelectScissors()
    {
        CheckWin(2);
    }

    private void CheckWin(int playerSelected)
    {
        int aiSelectedValue = UnityEngine.Random.Range(0, 3);
        int delta = playerSelected - aiSelectedValue;
        
        if (delta == 0)
        {
            Debug.Log("ничья");
        } 
        else if (delta == -1 || delta == 2)
        {
            Debug.Log("ПК выиграл");
            SubtractOnePoint();
        } 
        else if (delta == 1 || delta == -2)
        {
            Debug.Log("Мы выиграли");
            AddOnePoint();
        } 
    }
}

public enum Choices
{
    Rock = 0,
    Paper = 1,
    Scissors = 2
}