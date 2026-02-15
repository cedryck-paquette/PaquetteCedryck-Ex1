using UnityEngine;

public class mouvementObstacle : MonoBehaviour
{
    public float vitesse = 0.005f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * vitesse);

        if (transform.position.y <= -7)
        {
            float xAleatoire = Random.Range(-6.0f, 6.0f);
            transform.position = new Vector2(xAleatoire, 6.5f);
            vitesse = Random.Range(0.005f, 0.01f);
        }
    }
}
