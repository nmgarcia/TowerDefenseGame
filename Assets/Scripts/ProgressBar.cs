using UnityEngine;
using UnityEngine.UI;

namespace TowerDefenseGame.Scripts
{
    public class ProgressBar : MonoBehaviour
    {
        public float maximum;
        public float current;
        public Image mask;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            GetCurrentFill();
        }

        public void GetCurrentFill()
        {
            float fillAmount = current / maximum;
            mask.fillAmount = fillAmount;
        }
    }
}