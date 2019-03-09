using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
    public GameObject rocks;
    int score;
    public int A = 2;
	
	void Start () {
        InvokeRepeating("CreateObstacle", 1f, 1.5f);
	
	}
    


    void CreateObstacle()
    {
        Instantiate(rocks);
        StartCoroutine("waitFiveSeconds");
        
    }
  // public void OnGUI()
   // {
    //    if (A == 2)
     //   {
          //  GUI.color = Color.black;
         //   GUILayout.Label(" Your score is" + score.ToString());
    //    }
   // }

    
    IEnumerator waitFiveSeconds()
    {
        yield return new WaitForSeconds(7);
        score++;
    }

    public void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("SCORE: " + score.ToString());
    }
    }
