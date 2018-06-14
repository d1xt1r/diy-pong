using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour { // Class that is not attached to an game objects. It will be called by the Ball script

    static float timeToMaxDifficulty = 30; // After 60 seconds max difficluty will be reached

    public static float GetDifficultyPercent() {
        //return 1; // Returns the max difficulty instantly
        return Mathf.Clamp01(Time.timeSinceLevelLoad / timeToMaxDifficulty); // Time since the level started / timeToMaxDifficulty clamped between 0 and 1
    }

}
