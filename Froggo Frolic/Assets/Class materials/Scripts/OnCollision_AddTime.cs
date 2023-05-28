using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnCollision_AddTime : MonoBehaviour
{
    public int timeLeft = 60;
    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");

    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = (" " + timeLeft);

    }
    IEnumerator LoseTime()
    {
       while (true) 
        {
			yield return new WaitForSeconds(1);
			timeLeft --;
		}
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Kiwi")
        {
            timeLeft += 5;
            Destroy(other.gameObject);

        }
    }

}
