using UnityEngine;
using System.Collections; // Add this line

public class RotateObject : MonoBehaviour
{
    public void RotateAroundThreeTimes()
    {
        StartCoroutine(RotateSmoothly(5, 360f, 1f));
    }

    private IEnumerator RotateSmoothly(int numberOfRotations, float totalRotationAngle, float duration)
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float currentRotationAngle = Mathf.Lerp(0, totalRotationAngle, elapsed / duration);
            transform.rotation = Quaternion.Euler(0, currentRotationAngle, 0);

            elapsed += Time.deltaTime;
            yield return null;
        }

        // Ensure the final rotation is set correctly
        transform.rotation = Quaternion.Euler(0, totalRotationAngle, 0);
    }
}
