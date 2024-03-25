using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Source.Core
{ 
    public class ResourceBank : MonoBehaviour
    {
        private Dictionary<GameResource, ObservableInt> resourceDict = new Dictionary<GameResource, ObservableInt>();

        public ResourceBank()
        {
            foreach (GameResource resource in System.Enum.GetValues(typeof(GameResource)))
            {
                resourceDict.Add(resource, new ObservableInt(0));
            }
        }

        public void ChangeResource(GameResource resource, int value)
        {
            if (resourceDict.ContainsKey(resource))
            {
                resourceDict[resource].Value += value;
            }
        }

        public ObservableInt GetResource(GameResource resource)
        {
            return resourceDict.ContainsKey(resource) ? resourceDict[resource] : null;
        }
    }
    
}
