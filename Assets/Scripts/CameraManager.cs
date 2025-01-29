using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour
{
    public Transform[] cameraPositions; // Assign preset positions in Inspector
    public float transitionSpeed = 1.5f; // Adjust to control transition speed

    private Transform targetPosition; // The current camera target

    void Start()
    {
        if (cameraPositions.Length > 0)
        {
            targetPosition = cameraPositions[0]; // Start at Zone 1
            transform.position = targetPosition.position; // Set initial position instantly
        }
    }

    public void MoveToNextZone(int zoneIndex)
    {
        if (zoneIndex >= 0 && zoneIndex < cameraPositions.Length)
        {
            targetPosition = cameraPositions[zoneIndex];
            StartCoroutine(SmoothCameraTransition(targetPosition.position));
        }
    }

    IEnumerator SmoothCameraTransition(Vector3 newPosition)
    {
        float elapsedTime = 0f;
        Vector3 startPos = transform.position;

        while (elapsedTime < transitionSpeed)
        {
            transform.position = Vector3.Lerp(startPos, newPosition, elapsedTime / transitionSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = newPosition; // Ensure final position is accurate
    }
}
