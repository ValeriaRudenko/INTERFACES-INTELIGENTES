using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text textVelocity;
    public Text textAccelerator;
    public Text textAltitude;
    public Text textLongitude;
    public Text textLatitude;

    public float smoothing = 0.1f;
    public GameObject rotator;
    float speed = 5f;

    void Start()
    {
        smoothing = 0.5f;
        Input.location.Start();
        Input.compass.enabled = true;
        Input.gyro.enabled = true;
    }

    void Update()
    {
        // Update the device's orientation using the gyroscope
        Quaternion attitude = Input.gyro.attitude;

        // Apply rotations to the 'rotator' GameObject
        rotator.transform.rotation = attitude;
        rotator.transform.Rotate(0f, 0f, 180f, Space.Self);
        rotator.transform.Rotate(90f, 180f, 0f, Space.World);

        // Smoothly interpolate between the current rotation and the 'rotator' rotation
        transform.rotation = Quaternion.Slerp(transform.rotation, rotator.transform.rotation, smoothing);

        // Update the UI text for each value
        textVelocity.text = "Velocidad angular: " + attitude.ToString();
        textAccelerator.text = "Aceleración: " + Input.acceleration.ToString();
        textAltitude.text = "Altitud: " + Input.location.lastData.altitude.ToString();
        textLongitude.text = "Longitud: " + Input.location.lastData.longitude.ToString();
        textLatitude.text = "Latitud: " + Input.location.lastData.latitude.ToString();

        // Translate the GameObject based on accelerometer data
        Vector3 direction = new Vector3(Input.acceleration.x, 0, -Input.acceleration.z);
        transform.Translate(direction * Time.deltaTime * speed, Space.World);
    }
}
