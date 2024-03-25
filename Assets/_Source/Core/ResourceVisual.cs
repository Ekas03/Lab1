using System;
using UnityEngine;
using TMPro;

namespace _Source.Core
{
    public class ResourceVisual : MonoBehaviour
    {
        public GameResource resourceType;
        public TextMeshProUGUI text;
        public ResourceBank resourceBank;

        private void Awake()
        {
            if (resourceBank != null)
            {
                UpdateText(resourceBank.GetResource(resourceType).Value);
                resourceBank.GetResource(resourceType).OnValueChanged += UpdateText;
            }
            else
            {
                Debug.LogError("ResourceBank not found!");
            }
        }
        private void Start()
        {
            
        }

        private void OnDestroy()
        {
            if (resourceBank != null)
            {
                resourceBank.GetResource(resourceType).OnValueChanged -= UpdateText;
            }
        }

        private void UpdateText(int newValue)
        {
            if (text != null)
            {
                text.text = resourceType.ToString() + ": " + newValue;
            }
        }
    }
    
}
