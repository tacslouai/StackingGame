using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public bool gameOver;
    public bool collidedWithGround = false;
    public int moveCount = 0;
    public Transform crateSpawnPos;
    public Vector3 cameraTargetPos;
    public TextMeshProUGUI bestScore;
    public TextMeshProUGUI scoreText;
    public int score = 0;
    public GameObject gameOverText;
    //Crate crate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
