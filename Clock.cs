using System;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour {
    
    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    [SerializeField]
    Transform hoursPivotNY, minutesPivotNY, secondsPivotNY;  // New York
    [SerializeField]
    Transform hoursPivotItaly, minutesPivotItaly, secondsPivotItaly;  // Italy
    [SerializeField]
    Transform hoursPivotSF, minutesPivotSF, secondsPivotSF;  // San Francisco
    [SerializeField]
    Transform hoursPivotChile, minutesPivotChile, secondsPivotChile;  // Chile

    void Update() {
        DateTime utcNow = DateTime.UtcNow;

        // New York: UTC-4 (considering daylight saving time)
        TimeSpan nyTime = utcNow.AddHours(-4).TimeOfDay;
        hoursPivotNY.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)nyTime.TotalHours);
        minutesPivotNY.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)nyTime.TotalMinutes);
        secondsPivotNY.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)nyTime.TotalSeconds);

        // Italy: UTC+2 (considering daylight saving time)
        TimeSpan italyTime = utcNow.AddHours(2).TimeOfDay;
        hoursPivotItaly.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)italyTime.TotalHours);
        minutesPivotItaly.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)italyTime.TotalMinutes);
        secondsPivotItaly.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)italyTime.TotalSeconds);

        // San Francisco: UTC-7 (considering daylight saving time)
        TimeSpan sfTime = utcNow.AddHours(-7).TimeOfDay;
        hoursPivotSF.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)sfTime.TotalHours);
        minutesPivotSF.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)sfTime.TotalMinutes);
        secondsPivotSF.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)sfTime.TotalSeconds);

        // Chile: UTC-3 (considering daylight saving time)
        TimeSpan chileTime = utcNow.AddHours(-3).TimeOfDay;
        hoursPivotChile.localRotation =
            Quaternion.Euler(0f, 0f, hoursToDegrees * (float)chileTime.TotalHours);
        minutesPivotChile.localRotation =
            Quaternion.Euler(0f, 0f, minutesToDegrees * (float)chileTime.TotalMinutes);
        secondsPivotChile.localRotation =
            Quaternion.Euler(0f, 0f, secondsToDegrees * (float)chileTime.TotalSeconds);
    }
}

