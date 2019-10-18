//开启Log.Info,只有定义了该宏定义Log.info才会输出到Console平台
//可以添加到File -> Build Settings -> Player Setting -> Other Settings -> Scripting Define Symbols中,开启全局Log.Info
//该定义如果放在某个脚本中，只能控制该脚本中的Log.Info的显示和隐藏
#define LOG_INFO

//开启Log.Info,只有定义了该宏定义Log.Warning才会输出到Console平台
//可以添加到File -> Build Settings -> Player Setting -> Other Settings -> Scripting Define Symbols中,开启全局Log.Warning
//该定义如果放在某个脚本中，只能控制该脚本中的Log.Warning的显示和隐藏
#define LOG_WARNING

//同时也可以使用Log.ShowTag = 0；来关闭所有的Log.Info和Log.Warning
//使用Log.ShowTag = 0;需要确保Log.ShowTag在最早出设置并确保运行中不会被覆盖
//建议在正式环境中使用宏定义来开关，使用宏定义可以减少函数调用以及Log.ShowTag & InTag == InTag的判断
//同时Log.ShowTag可以在运行中控制是否打开Log，或者打开哪些log信息，只需要让Log.ShowTag等于某个远程可以更改的值

//注：Log.Error和Log.Exception
#define IGNORE_ERROR

#define IGNORE_EXCEPTION


using System;
using System.Collections.Generic;
using ThirdParty.Debug;
using ThirdParty.Util;
using UnityEngine;

public class LogExample : MonoBehaviour
{
    void Awake()
    {
        //Debug.Log("Log.Info");
        Log.Info("Log.Info");

        //Debug.Log("<color=green>Log.Info with Color</color>")
        Log.Info("Log.Info with Color", ColorName.Green);

        //if(Log.ShowTag & Tag == Tag) show Log.Info
        Log.ShowTag = 10;
        //Debug.Log("<color=green>Log.Info with Color</color>")
        Log.Info("Log.Info with Color And Tag", ColorName.Green, 10);

        //else Hide Log.Info
        Log.ShowTag = 0;
        //Debug.Log("<color=green>Log.Info with Color</color>")
        Log.Info("Log.Info with Color And Tag", ColorName.Green, 10);

        Log.ShowTag = 1;
        //Debug.LogWarning("Log.Warning")
        Log.Warning("Log.Warning");

        //Debug.LogWarning("Log.Warning", gameObject)
        Log.Warning("Log.Warning", gameObject);

        //Debug.LogError("Log.Error")
        Log.Error("Log.Error");

        //Debug.LogError("Log.Error", gameObject)
        Log.Error("Log.Error", gameObject);

        //Debug.LogErrorFormat("Log.Error{0},{1},{2}", 1, 2, 3);
        Log.ErrorFormat("Log.Error{0},{1},{2}", 1, 2, 3);

        //Debug.LogErrorFormat(gameObject, "Log.Error{0},{1},{2}", 1, 2, 3);
        Log.ErrorFormat(gameObject, "Log.Error{0},{1},{2}", 1, 2, 3);

        //Debug.LogException(new Exception("Log.Exception"));
        Log.Exception(new Exception("Log.Exception"));

        int[] iArray = new[] {1, 2, 3, 4, 5};
        
        //StringBuilder stringBuilder = new StringBuilder();
        //stringBuilder.Append("iArray").Append("\n");
        //stringBuilder.Append("[<").Append(0).Append(", ").Append(iArray[0]).Append(">");
        //for (int index = 1; index < iArray.Length; ++index)
        //    stringBuilder.Append(", <").Append(index).Append(", ").Append(iArray[index]).Append(">");
        //stringBuilder.Append("]");
        //Debug.Log(stringBuilder.ToString());
        Log.Info("iArray", iArray);
        

        //Debug.Log($"<color=green>{stringBuilder.ToString()}</color>");
        Log.Info("iArray", iArray, ColorName.Green);

        List<string> sList = new List<string>() {"a", "b", "c", "d", "e"};
        
        //StringBuilder stringBuilder = new StringBuilder();
        //stringBuilder.Append("sList").Append("\n");
        //stringBuilder.Append("[<").Append(0).Append(", ").Append(sList[0]).Append(">");
        //for (int index = 1; index < sList.Count; ++index)
        //    stringBuilder.Append(", <").Append(index).Append(", ").Append(sList[index]).Append(">");
        //stringBuilder.Append("]");
        //Debug.Log(stringBuilder.ToString());
        Log.Info("sList", sList);

        //Debug.Log($"<color=green>{stringBuilder.ToString()}</color>");
        Log.Info("sList", sList, ColorName.Green);

        Queue<float> fQueue = new Queue<float>();
        fQueue.Enqueue(0.1f);
        fQueue.Enqueue(1.2f);
        fQueue.Enqueue(2.3f);
        fQueue.Enqueue(3.4f);
        fQueue.Enqueue(4.5f);

        //StringBuilder stringBuilder = new StringBuilder();
        //stringBuilder.Append("fQueue").Append("\n");
        //using (IEnumerator<float> enumerator = fQueue.GetEnumerator())
        //{
        //    enumerator.MoveNext();
        //    stringBuilder.Append("{<").Append(enumerator.Current).Append(">");
        //    while (enumerator.MoveNext())
        //        stringBuilder.Append(", <").Append(enumerator.Current).Append(">");
        //}
        //stringBuilder.Append("}");
        //Debug.Log(stringBuilder.ToString());
        Log.Info("fQueue", fQueue);
        
        //Debug.Log($"<color=green>{stringBuilder.ToString()}</color>");
        Log.Info("fQueue", fQueue, ColorName.Green);

        Dictionary<int, string> dictionary = new Dictionary<int, string>()
            {{0, "a"}, {1, "b"}, {2, "c"}, {3, "d"}, {4, "e"}, {5, "f"}};
        
        //StringBuilder stringBuilder = new StringBuilder();
        //stringBuilder.Append("dictionary").Append("\n");
        //using (IEnumerator<KeyValuePair<int, string>> enumerator = dictionary.GetEnumerator())
        //{
        //    enumerator.MoveNext();
        //    KeyValuePair<int, string> current = enumerator.Current;
        //    stringBuilder.Append("{<").Append(current.Key).Append(", ").Append(current.Value).Append(">");
        //    while (enumerator.MoveNext())
        //    {
        //        current = enumerator.Current;
        //        stringBuilder.Append(", <").Append(current.Key).Append(", ").Append(current.Value).Append(">");
        //    }
        //}
        //stringBuilder.Append("}");
        //Debug.Log(stringBuilder.ToString());
        Log.Info("Dictionary", dictionary);
        
        //Debug.Log($"<color=green>{stringBuilder.ToString()}</color>");
        Log.Info("Dictionary", dictionary, ColorName.Green);
    }
}