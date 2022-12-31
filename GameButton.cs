using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    [SerializeField] float rotation;
    [SerializeField] bool isHit;

    private void Update()
    {
        GetRotation();
    }

    private void GetRotation()
    {
        rotation = Mathf.Abs(Cube.Instance.transform.rotation.eulerAngles.x);
    }

    public void OnButtonClick()
    {
        //face 1 right hit
        if (rotation >= 0 && rotation <= 10 && isHit == false)
        {
            RightHitProcedures();
        }
        //face 1 wrong hit
        else if (rotation > 10 && rotation < 90)
        {
            StartCoroutine(WrongHit());
        }
        //face 2 right hit 
        else if (rotation >= 90 && rotation <= 100 && isHit == false)
        {
            RightHitProcedures();
        }
        //face 2 wrong hit 
        else if (rotation > 100 && rotation < 180)
        {
            StartCoroutine(WrongHit());
        }
        //face 3 right hit 
        else if (rotation >= 180 && rotation <= 190 && isHit == false)
        {
            RightHitProcedures();
        }
        //face 3 wrong hit
        else if (rotation > 190 && rotation < 270)
        {
            StartCoroutine(WrongHit());
        }
        //face 4 right hit
        else if (rotation >= 270 && rotation <= 280 && isHit == false)
        {
            RightHitProcedures();
        }
        //face 4 wrong hit
        else if(rotation > 280 && rotation < 360)
        {
            StartCoroutine(WrongHit());
        }


        //learn more about switch case 
        /*
        switch (rotation)
        {
            //face 1 hit
            case <= 20:
                if (isHit == false)
                {
                    Counter.Instance.increaseScore();
                    isHit = true;
                    StartCoroutine(RightHit());
                }
                else { StartCoroutine(WrongHit()); }
                break;
            //face 1 wrong hit
            case > 20:
                StartCoroutine(WrongHit());
                break;
            case <= 90:
                StartCoroutine(WrongHit());
                break;

        }
        */
    }


    /// <summary>
    /// Start right hit procedures
    /// </summary>
    private void RightHitProcedures()
    {
        Counter.Instance.increaseScore();
        isHit = true;
        StartCoroutine(RightHit());
    }

    IEnumerator WrongHit()
    {
        yield return new WaitForSeconds(1f);
    }

    IEnumerator RightHit()
    {
        yield return new WaitForSeconds(0.5f);
        isHit = false;
    }

}
