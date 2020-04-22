using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Animator animator;
    [SerializeField] float speed;

    Vector2 movement;
    Rigidbody2D rb;

    public static PlayerMovement playerMovementInstance;
    public static string toPos = "default";

    private void Awake()
    {
        if (playerMovementInstance == null)
        {
            playerMovementInstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (playerMovementInstance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.SqrMagnitude());
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {
        transform.position = ChangeSceneManager.spawnLocation[ChangeSceneManager.toPos];
    }
}
