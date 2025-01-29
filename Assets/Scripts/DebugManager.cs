using UnityEngine;

public class DebugManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V)) // Press 'V' to toggle vision cones
        {
            EnemyAI.showVisionCones = !EnemyAI.showVisionCones;
            Debug.Log("Vision Cones: " + (EnemyAI.showVisionCones ? "ON" : "OFF"));
        }
    }
}
