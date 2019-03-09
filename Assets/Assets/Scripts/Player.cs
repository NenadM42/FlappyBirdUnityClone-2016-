using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
   public int score = 0;
    int A = 2;
    int B = 4;
   
    AudioSource Click;
    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 150);
    public Vector2 DeadForce = new Vector2(0, 555);

    // Update is called once per frame
    void Update()
    {
         
        // GetComponent<AudioSource>().
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
            

        }

        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }
        
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        Die();
    }

    
    
   public void Die()
    {
        A = 3;
    }

    public void OnGUI()
    {
        
        if (A == 3)
        {
            GUI.color = Color.black;
            GUILayout.Label("                                                           RESTART IN 5 SECONDS! ");
            B = 1;
            StartCoroutine("wait");
            
        }
    }
   public IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        StartCoroutine("end");
    }
    public void end()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    //{
    //  Application.LoadLevel(Application.loadedLevel);
    //}




}