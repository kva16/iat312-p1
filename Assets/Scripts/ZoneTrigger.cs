using UnityEngine;

public class ZoneTrigger : MonoBehaviour
{
    public int zoneIndex; // Assign this in the Inspector (0 for Zone1, 1 for Zone2, etc.)

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CameraManager cameraManager = Camera.main.GetComponent<CameraManager>();
            if (cameraManager != null)
            {
                cameraManager.MoveToNextZone(zoneIndex);
            }
        }
    }
}
