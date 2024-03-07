using TMPro;
using UnityEngine;

namespace Runtime.Controllers
{
    public class PlayerMeshController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private TextMeshPro scoreText;

        #endregion

        #endregion

        internal void SetTotalScore(int value)
        {
            scoreText.text = value.ToString();
        }
    }
}