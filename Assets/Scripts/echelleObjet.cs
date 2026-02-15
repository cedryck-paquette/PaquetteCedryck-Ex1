using UnityEngine;

public class echelleObjet : MonoBehaviour
{
    public float tailleMin = 1.5f;
    public float tailleMax = 2.5f;
    public float vitesse = 0.5f;
    static float t = 0.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(
            Mathf.Lerp(tailleMin, tailleMax, t),
            Mathf.Lerp(tailleMin, tailleMax, t)
        );

        t += vitesse * Time.deltaTime;

        if (t > 1.0f)
        {
            float temporaire = tailleMax;
            tailleMax = tailleMin;
            tailleMin = temporaire;
            t = 0.0f;
        }

        

    }
}
