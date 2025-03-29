using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueExercise : MonoBehaviour
{
    private void Awake()
    {
        Queue queue = new Queue();

        for (int i = 0; i < 5; ++ i){
            queue.Enqueue(i);
        }
        Debug.Log($"queue count : {queue.Count}");

        Debug.Log($"현재 0번 요소 : {queue.Peek()}");

        object data = queue.Dequeue();
        Debug.Log($"큐에서 빠져나온 데이터 : {data}");

        Debug.Log($"queue count : {queue.Count}");

        queue.Clear();

        Debug.Log($"queue count : {queue.Count}");
    }
}
