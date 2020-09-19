using UnityEngine;
using System.Collections;

public class pillar : MonoBehaviour
{
    [Header("旋轉角度"), Range(0,100)]
    public float angle = 90;
    [Header("旋轉速度"), Range(0, 100)]
    public float speed = 10f;

    public void StartRotate()
    {
        StartCoroutine(Rotate());
    }

    public IEnumerator Rotate()
    {
        while(transform.rotation !=Quaternion.Euler(0, angle,0))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, angle, 0), Time.deltaTime * speed);
            yield return null;
        }
    }






}
