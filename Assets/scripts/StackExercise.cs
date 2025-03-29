using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExercise : MonoBehaviour
{
    void Awake()
    {
        Stack stack = new Stack();

        for (int i = 0; i < 5; ++i)
        {
            stack.Push(i);
        }

        Debug.Log($"stack count : {stack.Count}");

        Debug.Log($"마지막에 추가된 요소 : {stack.Peek()}");

        Debug.Log($"stack count : {stack.Count}");

        object data = stack.Pop();

        Debug.Log($"스택에서 빠져나온 데이터 : {data}");

        Debug.Log($"stack count : {stack.Count}");

        stack.Clear();

        Debug.Log($"stack count : {stack.Count}");
    }

    
}
