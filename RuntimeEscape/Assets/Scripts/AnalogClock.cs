using UnityEngine;
using System;

public class AnalogClock : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;

    void Update()
    {
        DateTime time = DateTime.Now;

        float minute = time.Minute + time.Second / 60f;
        float hour = (time.Hour % 12) + minute / 60f;

        minuteHand.localRotation = Quaternion.Euler(0, 0, -minute * 6f);
hourHand.localRotation = Quaternion.Euler(0, 0, -hour * 30f);
}
}