using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{

    public GameObject gameManager;
    public List<GameObject> chats;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                if (this.transform.name == hit.transform.name)
                {
                    int qNum = gameManager.GetComponent<GameManager>().getQuestionNumber();

                    if (qNum != 0)
                    {
                        gameManager.GetComponent<GameManager>().hideLastChat();

                        chats[qNum - 1].SetActive(true);
                        gameManager.GetComponent<GameManager>().setActiveChat(chats[qNum - 1]);
                    }
                }
            }
        }

        /* FOR PC TESTING
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(this.transform.name == hit.transform.name)
                {
                    int qNum = gameManager.GetComponent<GameManager>().getQuestionNumber();
                    Debug.Log(qNum);

                    if (qNum != 0)
                    {
                        gameManager.GetComponent<GameManager>().hideLastChat();

                        chats[qNum - 1].SetActive(true);
                        gameManager.GetComponent<GameManager>().setActiveChat(chats[qNum - 1]);
                    }
                }
            }
        } */
        
    }
}
