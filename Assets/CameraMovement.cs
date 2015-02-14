using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public float transitionDuration = 2.5f;
    private float Zoom1;
    public float Zoom2;
    private float ypos1;
    private float ypos2;
    private float xpos1;
    private float xpos2;
    private bool transition = false;
    public float duration = 1.0f;
    private float elapsed = 0.0f;


    public IEnumerator Transition(GameObject target)
    {


        while (elapsed < 1.0f)
        {
            elapsed += Time.deltaTime * (Time.timeScale / transitionDuration);
            Debug.Log("Test");
          
                ypos1 = this.gameObject.camera.transform.position.y;
                ypos2 = target.transform.position.y;
                xpos1 = this.gameObject.camera.transform.position.x;
                xpos2 = target.transform.position.x;
                Zoom1 = Camera.main.orthographicSize;
                Camera.main.orthographicSize = Mathf.Lerp(Zoom1, Zoom2, elapsed);
                this.gameObject.camera.transform.position = new Vector3(Mathf.Lerp(xpos1, xpos2, elapsed), Mathf.Lerp(ypos1, ypos2, elapsed), this.gameObject.camera.transform.position.y);
                
            
            yield return 1;


        }
    }

        public void StartTrasition(GameObject target) {

        
        StartCoroutine(Transition(target));
            }

}