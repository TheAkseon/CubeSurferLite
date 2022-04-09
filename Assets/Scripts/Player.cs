using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Text _healthText;

    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private GameObject _losePanel;

    private float _health = 5f;
    private float _score = 0f;

    private void Start()
    {
        _healthText.text = _health.ToString();
        _scoreText.text = _score.ToString();

    }

    private void Update()
    {
        if(_health <= 0f)
        {
            _gamePanel.SetActive(false);
            _losePanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Enemy"))
        {
            _health -= 1;
            _healthText.text = _health.ToString();
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.CompareTag("Friendly"))
        {
            _score += 1;
            _scoreText.text = _score.ToString();
            Destroy(collider.gameObject);
        }
    }
}
