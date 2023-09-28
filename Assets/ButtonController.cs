using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform spawnPoint;
    public float shootingForce = 10f;

    private XRGrabInteractable interactable;

    private void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        interactable.selectEntered.AddListener(ShootBall);
    }

    private void ShootBall(SelectEnterEventArgs args)
    {
        GameObject ball = Instantiate(ballPrefab, spawnPoint.position, Quaternion.identity);
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(spawnPoint.forward * shootingForce, ForceMode.Impulse);
    }
}