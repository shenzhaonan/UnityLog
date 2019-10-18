#define LOG_INFO

using System.Collections.Generic;
using ThirdParty.Debug;
using ThirdParty.Util;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Log.Info("a", ColorName.Plum);

        int[] ints = new[] {1, 2, 3, 4, 5};
        Log.Info("Ints", ints, ColorName.Brown);

        List<string> ls = new List<string>();
        ls.Add("a");
        ls.Add("b");ls.Add("c");
        Log.Info("List", ls, ColorName.Linen);
        
        Queue<float> queue = new Queue<float>();
        queue.Enqueue(0.1f);
        queue.Enqueue(1.2f);
        queue.Enqueue(2.3f);
        Log.Info("Queue", queue, ColorName.Chocolate);
        
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        dictionary.Add(0, "abc");
        dictionary.Add(1, "bcd");
        dictionary.Add(2, "cde");
        Log.Info("Dictionary", dictionary, ColorName.Lime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
