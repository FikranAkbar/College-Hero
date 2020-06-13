using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] JobDisplayManager jobDisplay;
    [SerializeField] LectureDisplayManager lectureDisplay;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Work")
        {
            jobDisplay.ShowJobUI();
        }
        else if(collision.tag == "GoLecture")
        {
            lectureDisplay.ShowLectureUI();
        }
    }
}
