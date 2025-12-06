using UnityEngine;

public class HW2PlayerShoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform bulletTrash;
    public Transform bulletSpam;

    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        if (!_canShoot)
        {
            TimerMethod();
        }


        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(prefab,
                bulletSpam.position, bulletSpam.rotation, bulletTrash);
            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }

    private void TimerMethod()
    {
        if (_canShoot)
        {
            _currentTime += Time.deltaTime;

            if (_currentTime >= Timer)
            {
                _canShoot = true;
                _currentTime = 0f;
            }

        }
    }
}
      