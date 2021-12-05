using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = System.Object;

namespace FrameWork
{
    public class EventManager : Singleton<EventManager>
    {
        private Dictionary<string, Dictionary<Object, Action>> _dict;
        public void RegisterListener(string eventName, Action callBack, Object obj)
        {
            
        }

        public void SendEvent(string eventName)
        {
            
        }
    }
}

