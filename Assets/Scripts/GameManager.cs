
//ООП - Обьектно ориентированное программирование
// Обьект - данные + логика

using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerPointsText;
    public TextMeshProUGUI AIPointsText;
    public int PlayerPoints;
    public int AIPoints;

    public int PlayerSelectedValue;

    public void AddOnePoint()
    {
        PlayerPoints = PlayerPoints + 1;
        PlayerPointsText.text = "ОчкиИгрок: " + PlayerPoints;
    }

    public void AddOnePoint()
    {
        PlayerPoints = AIPoints + 1;
        AIPointsText.text = "ОчкиAI: " + AIPoints;
    }

    public void SubtractOnePointAI()
    {
        AIPoints = AIPoints - 1;
        AIPointsText.text = "ОчкиAI: " + AIPoints;
    }

    public void SubtractOnePoint()
    {
        PlayerPoints = PlayerPoints - 1;
        PlayerPointsText.text = "ОчкиИгрок: " + PlayerPoints;
    }

    public void SelectRock()
    {
        PlayerSelectedValue = 0;
        int aiSelectedValue = UnityEngine.Random.Range(0, 3);
        if (aiSelectedValue == 0)
        {
            Debug.Log("ничья");
        }
        else if (aiSelectedValue == 1)
        {
            Debug.Log("ПК выйграл");
            SubtractOnePoint();
        }
        else if (aiSelectedValue == 2)
        {
            Debug.Log("мы выиграли");
            AddOnePoint();
        }
    }

    public void SelectPaper()
    {
        PlayerSelectedValue = 1;
        
        int aiSelectedValue = UnityEngine.Random.Range(0, 3);
        if (aiSelectedValue == 1)
        {
            Debug.Log("ничья");
        } 
        else if (aiSelectedValue == 2)
        {
            Debug.Log("ПК выйграл");
            SubtractOnePoint();
        } 
        else if (aiSelectedValue == 0)
        {
            Debug.Log("мы выиграли");
            AddOnePoint();
        } 
    }

    public void SelectScissors()
    {
        PlayerSelectedValue = 2;
        
        int aiSelectedValue = UnityEngine.Random.Range(0, 3);
        if (aiSelectedValue == 2)
        {
            Debug.Log("ничья");
        } 
        else if (aiSelectedValue == 0)
        {
            Debug.Log("ПК выйграл");
            SubtractOnePoint();
        } 
        else if (aiSelectedValue == 1)
        {
            Debug.Log("мы выиграли");
            AddOnePoint();
        } 
    }
}