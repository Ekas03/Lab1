using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

namespace _Source.Core
{
    public class ProductionBuilding : MonoBehaviour
    {
        public GameResource resourseType;
        public GameResource prodLvl;
        public ResourceBank resourceBank;
        public Slider slider;
        public float productionTime;
        private Coroutine coroutine;
        
        public void StartProduction()
        {
            if (coroutine == null)
            {
                coroutine = StartCoroutine(ProduceResource());
            }
            else
            {
                return;
            }
        }

        private IEnumerator ProduceResource()
        {
            slider.value = 0;
            var start = Time.time;
            var end = Time.time + productionTime * (1 - resourceBank.GetResource(prodLvl).Value / 100f);
            while (Time.time < end)
            {
                slider.value = (Time.time - start) / productionTime;
                yield return null;
            }
            resourceBank.ChangeResource(resourseType, 1);
            slider.value = 0;
            coroutine = null;
        }
    }

}
