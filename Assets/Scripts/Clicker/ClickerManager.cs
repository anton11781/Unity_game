using UnityEngine;
using TMPro;

namespace Clicker
{
    public class ClickerManager : MonoBehaviour
    {
        public TextMeshProUGUI ScoreText;
        private int Score;

        private int[] houses = new[]{ 15, 25, 55, 66, 60 };
        public void Click()
        {
            for (int i = 0; i < houses.Length; i++)
            {
                Debug.Log($"В доме #{i} живет {houses[i]}");   
            }
           
            Score++;
            ScoreText.text = Score.ToString();
        }
    }
}