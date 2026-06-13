using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    private float timePassed = 0f;

    void Update()
    {
        timePassed += Time.deltaTime;

        timerText.text =
            "Time: " +
            timePassed.ToString("F1");
    }
}