using UnityEngine;

public class MoveScriot : MonoBehaviour
{
    public GameObject car;
    public GameObject location;
    public float speed;
    public GameObject destroyButton;
    public GameObject DonePanel;
    public float time;

    void Awake()
    {
        Time.timeScale = 0f; // Pause the game at the start
    }


    void Update()
    {
        car.transform.position = Vector3.MoveTowards(car.transform.position, location.transform.position, speed * Time.deltaTime);
    }

    public void StartGame()
    {
        Time.timeScale = 1f; // Resume the game
        Destroy(destroyButton);
        StartCoroutine(GameDone());
    }

    private System.Collections.IEnumerator GameDone()
    {
        yield return new WaitForSeconds(time); // Wait for 2 seconds
        Time.timeScale = 0f; // Pause the game again
        DonePanel.SetActive(true); // Show the Done panel
        Debug.Log("Game Over");
    }
}
