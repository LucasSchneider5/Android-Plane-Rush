using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spieler : MonoBehaviour {

    public Rigidbody2D rb;

    public float speedMultiplier;
    public float speedIncreaseMilestone;
    private float speedMilestoneCount;
    public float moveSpeed;

    public Transform Gegner;
    public float gegnerRadius;
    public LayerMask woIstGegner;
    private bool onGegner;

    [SerializeField]
    private GameObject GameOverMenu;
    public GameObject deleteScore;
    public GameObject GameEnd;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.right * speedIncreaseMilestone;
	}
	
	void Update () {
        float angle = Vector3.Angle(Vector3.right, rb.velocity);
        if (rb.velocity.y < 0)
        {
            angle = -angle;
        }
        transform.eulerAngles = new Vector3(0, 0, angle);

	    if(transform.position.x > speedMilestoneCount)
        {
            speedMilestoneCount += speedIncreaseMilestone;
            moveSpeed = moveSpeed * speedMultiplier;
        }

        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = new Vector2(rb.velocity.x, 5.5f);
        }

        onGegner = Physics2D.OverlapCircle(Gegner.position, gegnerRadius, woIstGegner);
        if (onGegner == true)
        {
            deleteScore.SetActive(false);
            GameOverMenu.SetActive(true);
            GameEnd.SetActive(false);
            PlayerPrefs.Save();
            //SceneManager.LoadScene(1);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}
}
