using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VoiceCommands : MonoBehaviour
{
    public TextMeshProUGUI uiText;
    public float jumpAmount = 6.0f;
    private bool isGrounded;
    public Rigidbody rb;
    private Animation animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animation>();

        if (animator == null)
        {
            Debug.LogError("Animator component not found on the GameObject.");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (uiText.text.Contains("jump")|| uiText.text.Contains("Jump"))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
                isGrounded = false;
            }
        }
        else if (uiText.text.Contains("spin")|| uiText.text.Contains("Spin"))
        {
            // Perform rigidbody spin action
            StartCoroutine(Spin());
        }
    }

    IEnumerator Spin()
    {
        // Rotate the GameObject (spin) three times
        for (int i = 0; i < 3; i++)
        {
            rb.AddTorque(Vector3.up * 360.0f, ForceMode.Impulse);
            yield return new WaitForSeconds(1.0f); // Adjust the duration between spins if needed
        }
    }
}
