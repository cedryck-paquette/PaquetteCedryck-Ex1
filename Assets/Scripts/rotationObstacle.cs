using UnityEngine;

public class rotationObstacle : MonoBehaviour
{

    public float vitesse = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 rotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, 0.0f, vitesse * Time.deltaTime);
    }
}
