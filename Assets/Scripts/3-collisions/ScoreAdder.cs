using UnityEngine;

/**
 * This component increases a given "score" field whenever it is triggered.
 */
public class ScoreAdder : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger adding score to the score field.")]
    [SerializeField] string triggeringTag;
    [SerializeField] NumberField scoreField;
    [SerializeField] int pointsToAdd;
    public GameObject spaceship;
    HeartSystem hs;

    void Awake()
    {
        spaceship = GameObject.Find("PlayerSpaceship");
        hs = spaceship.GetComponent<HeartSystem>();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag) {
            scoreField.AddNumber(pointsToAdd);
        }
        if (scoreField.GetNumber() % 10 == 0 && scoreField.GetNumber() != 0)
        {
            hs.addLife();
        }
    }

    public void SetScoreField(NumberField newTextField) {
        this.scoreField = newTextField;
    }
}
