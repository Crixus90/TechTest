using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    [Header("Timer Settings")]
    [SerializeField] float currentTime;
    [SerializeField] bool CountDown;

    private TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = CountDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString("0.0");
    }
}
